using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class ProductForm : Form
    {
        SqlConnection con;
        SqlCommandBuilder scb;
        SqlDataAdapter da;
        DataSet ds;

        public ProductForm()
        {
            InitializeComponent();
            con=new SqlConnection(ConfigurationManager.ConnectionStrings["dafaultConnection"].ConnectionString);
        }
        private DataSet GetAllProduct()
        {
            string qry = "select*from Product";
            da = new SqlDataAdapter(qry, con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Product");
            return ds;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllProduct();
                DataRow row = ds.Tables["Prduct"].NewRow();
                row["p_id"] = txtId.Text;
                row["p_name"] = txtName.Text;
                row["company"] = txtcompany.Text;
                row["price"] = txtprice.Text;
                ds.Tables["Product"].Rows.Add(row);
                int res = da.Update(ds.Tables["Product"]);
                if(res>0)
                {
                    MessageBox.Show("Record is inserted");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllProduct();
                DataRow row = ds.Tables["Product"].Rows.Find(txtId.Text);
                if(row!=null)
                {
                    txtId.Text = row["Id"].ToString();
                    txtName.Text = row["name"].ToString();
                    txtcompany.Text = row["company"].ToString();
                    txtprice.Text = row["price"].ToString();
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds=GetAllProduct();
                DataRow row = ds.Tables["Product"].Rows.Find(txtId.Text);
                if(row!=null)
                {
                    //row["id"]=txtId.Text;
                    row["name"]=txtName.Text;
                    row["company"]=txtcompany.Text;
                    row["price"]= txtprice.Text;
                    int res = da.Update(ds.Tables["Product"]);
                    if(res>0)
                    {
                        MessageBox.Show("Record Updated");
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllProduct();
                DataRow row = ds.Tables["Product"].Rows.Find(txtId.Text);
                if(row!=null)
                {
                    row.Delete();
                    int res = da.Update(ds.Tables["Product"]);
                    if(res>0)
                    {
                        MessageBox.Show("Record dalaeted");
                    }
                }
                else
                {
                    MessageBox.Show("Record not deleted");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ds=GetAllProduct();
            dataGridView1.DataSource = ds.Tables["Product"];
        }
    }
}
