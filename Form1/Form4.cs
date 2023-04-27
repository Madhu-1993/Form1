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
    public partial class Form4 : Form
    {
        SqlConnection con;
        SqlCommandBuilder scb;
        SqlDataAdapter da;
        DataSet ds;
        public Form4()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString);
        }

        public DataSet GetAllCust()
        {
            string qry = "select* from Customer";
            da = new SqlDataAdapter(qry, con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            //add the pk to the col which is in the dataset
            scb=new SqlCommandBuilder(da);
            ds=new DataSet();
            da.Fill(ds, "Customer");
            return ds;
            // customer table name 
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllCust();
                DataSet row = ds.Tables["Customer"].NewRow();
                row["Cus_id"] = txtId.Text;
                row["Cus_name"] = txtNmae.Text;
                row["Age"] = txtAge.Text;
                row["Country"] = txtContry.Text;
                ds.Tables["Customer"].Rows.Add(row);
                int res = da.Update(ds.Tables["Customer"]);
                if(res>0)
                {
                    MessageBox.Show("Record inserted");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowALL_Click(object sender, EventArgs e)
        {
            ds=GetAllCust();
            dataGridView1.DataSource = ds.Tables["Customer"];
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                ds=GetAllCust();
                DataRow row = ds.Tables["Customer"]. Rows.Find(txtId.Text);
                if(row!=null)
                {
                    txtId.Text = row["Cus_id"].ToString();
                    txtNmae.Text = row["Cus_name"].ToString();
                    txtAge.Text = row["Age"].ToString();
                    txtContry.Text = row["Country"].ToString();
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ex.Message");
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                ds=GetAllCust();
                DataRow row = ds.Tables["Customer"].Rows.Find(txtId.Text);
                if(row!=null)
                {
                    row.Delete();
                    int res = da.Update(ds.Tables["Customer"]);
                    if(res>0)
                    {
                        MessageBox.Show("Record Deleted");
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllCust();
                DataRow row = ds.Tables["Customer"] .Rows.Find(txtId.Text);

                if(row!=null )
                {
                    row["Cus_id"] = txtId.Text;
                    row["Cus_name"] = txtNmae.Text;
                    row["Age"] = txtAge.Text;
                    row["Country"] = txtContry.Text;

                    int res = da.Update(ds.Tables["Customer"]);

                    if(res>0)
                    {
                        MessageBox.Show("Record Updated");
                    }
                }
                else
                {
                    MessageBox.Show("Record not updated");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
