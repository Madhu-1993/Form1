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
    public partial class BookForm : Form
    {
        SqlConnection con;
        SqlCommandBuilder scb;
        SqlDataAdapter da;
        DataSet ds;
        public BookForm()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["dafault Connection"].ConnectionString);
        }

        private DataSet GetAllBook()
        {
            string qry = "select*from Book";
            da = new SqlDataAdapter(qry, con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            scb=new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Book");
            return ds;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllBook();
                DataRow row = ds.Tables["Book"].NewRow();
                row["id"] = txtbId.Text;
                row["name"] = txtbName.Text;
                row["author"] = txtAuthor.Text;
                row["price"] = txtPrice.Text;
                ds.Tables["Book"].Rows.Add(row);
                int res = da.Update(ds.Tables["Book"]);
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

        private void BookForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                ds=GetAllBook();
                DataRow row = ds.Tables["Book"].Rows.Find(txtbId.Text);
                if(row!=null)
                {
                    txtbId.Text = row["id"].ToString();
                    txtbName.Text = row["name"].ToString();
                    txtAuthor.Text = row["author"].ToString();
                    txtPrice.Text = row["price"].ToString();
                }
                else
                {
                    MessageBox.Show("Reocrd not found");
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
                ds = GetAllBook();
                DataRow row = ds.Tables["Book"].Rows.Find(txtbId.Text);
                if(row!=null)
                {
                    row["id"] = txtbId.Text;
                    row["name"]= txtbName.Text;
                    row["author"]= txtAuthor.Text;
                    row["price"]=txtPrice.Text;
                    int res = da.Update(ds.Tables["Book"]);
                    if(res>0)
                    {
                        MessageBox.Show("Record updated");
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds=GetAllBook();
                DataRow row = ds.Tables["Book"].Rows.Find(txtbId.Text);
                if(row!=null)
                {
                    row.Delete();
                    int res = da.Update(ds.Tables["Book"]);
                    if(res>0)
                    {
                        MessageBox.Show("Record deleted");
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            ds = GetAllBook();
            dataGridView1.DataSource = ds.Tables["Book"];
        }
    }
}
