using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Form1
{
    public partial class ProductData : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public ProductData()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Inseert into Prod values (@p_id,@p_name,@company,@price)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@p_id", txtId.Text);
                cmd.Parameters.AddWithValue("@p_name", txt_name.Text);
                cmd.Parameters.AddWithValue("@company", txt_company.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                con.Open();
                int res=cmd.ExecuteNonQuery();
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
            txtId.Clear();
            txt_name.Clear();
            txt_company.Clear();
            txtPrice.Clear();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Select *from Prod where id=@p_id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@p_id", Convert.ToInt32(txtId.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        txtId.Text = dr["p_id"].ToString();
                        txt_name.Text = dr["p_name"].ToString();
                        txt_company.Text = dr["Company"].ToString();
                        txtPrice.Text = dr["price"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record not Found");
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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Update Prod set name=@p_name, company=@company, price=@price";
                cmd.Parameters.AddWithValue("@p_name", txt_name.Text);
                cmd.Parameters.AddWithValue("@company", txt_company.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from Prod where id=@p_id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@p_id", Convert.ToInt32(txtId.Text));
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

        private void btnShowall_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select *from Prod";
                cmd = new SqlCommand(qry, con);
                con.Open();
                if(dr.HasRows)
                {
                    DataTable table = new DataTable();
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
    }
}
