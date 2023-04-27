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
    public partial class BookData : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public BookData()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Insert into Book1 values(@b_id,@b_name,@author,@price)";
                cmd=new SqlCommand(qry,con);
                cmd.Parameters.AddWithValue("@b_id",txtb_id.Text);
                cmd.Parameters.AddWithValue("@b_name", textname.Text);
                cmd.Parameters.AddWithValue("@author", textauthor.Text);
                cmd.Parameters.AddWithValue("@price", textPrice.Text);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if(res>0)
                {
                    MessageBox.Show("Record inserted");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void ClearForm()
        {

            txtb_id.Clear();
            textname.Clear();
            textauthor.Clear();
            textPrice.Clear();
        }
        private void butSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select*from Book1 where id=@b_id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@b_id", Convert.ToInt32(txtb_id.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        txtb_id.Text = dr["b_id"].ToString();
                        textname.Text = dr["b_name"].ToString();
                        textauthor.Text = dr["author"].ToString();
                        textPrice.Text = dr["price"].ToString();
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
            finally
            {
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "update Book1 set id=@b_id, name=@b_name, author=@author ,price=@price";
                cmd= new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@b_name", textname);
                cmd.Parameters.AddWithValue("@author", textauthor);
                cmd.Parameters.AddWithValue("@price", textPrice);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if(res>0)
                {
                    MessageBox.Show("Record updated");
                    ClearForm();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from Book1 where id=@b_id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@b_id", Convert.ToInt32(txtb_id));
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if(res>0)
                {
                    MessageBox.Show("Record deleted");
                    ClearForm();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select* from Book1";
                cmd = new SqlCommand(qry, con);
                con.Open();
                if(dr.HasRows)
                {
                    DataTable table=new DataTable();
                    table.Load(dr);
                    dataGridView1.DataSource = table;
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
            finally
            {
                con.Close();
            }
        }

        private void BookData_Load(object sender, EventArgs e)
        {

        }
    }
}
