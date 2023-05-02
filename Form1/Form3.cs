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
    public partial class Form3 : Form
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader dr;
        public Form3()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //step1
                string qry = "Insert into Customer values(@Cus_id,@Cus_name,@Age,@Country)";
               //step 2
                com = new SqlCommand(qry, con);
                //step3
                com.Parameters.AddWithValue("@Cus_id", Convert.ToInt32(txtId.Text));
                com.Parameters.AddWithValue("@Cus_name", txtNmae.Text);
                com.Parameters.AddWithValue("@Age", Convert.ToInt32(txtAge.Text));
                com.Parameters.AddWithValue("@Country", txtContry.Text);
                con.Open();
                int res = com.ExecuteNonQuery();
                if (res > 0)
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void ClearForm()
        {
            txtId.Clear();
            txtNmae.Clear();
            txtAge.Clear();
            txtContry.Clear();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                //step1
                String qry="select* from Customer where IDataAdapter = @Cus_id";
                com = new SqlCommand(qry,con);
                com.Parameters.AddWithValue("@Cus_id", Convert.ToInt32(txtId.Text));
                con.Open();
                dr = com.ExecuteReader();
                if(dr.HasRows) //if record is present then return true else false
                {
                    while(dr.Read())
                    {
                        txtNmae.Text = dr["Cus_name"].ToString();
                        txtContry.Text = dr["Country"].ToString();
                        txtAge.Text = dr["Cus_id"].ToString();
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "update Customer set name=@Cus_name,age=@Age,Country=@Country";
                com = new SqlCommand(qry,con);
                com.Parameters.AddWithValue("@Cus_name", txtNmae.Text);
                com.Parameters.AddWithValue("@Age", Convert.ToInt32(txtAge.Text));
                com.Parameters.AddWithValue("@Country", txtContry.Text);
                con.Open();
                int res = com.ExecuteNonQuery();
                if(res>0)
                {
                    MessageBox.Show("Record Added");
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

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from Customer where id=@Cus_id";
                com = new SqlCommand(qry, con);
                com.Parameters.AddWithValue("@Cus_id", Convert.ToInt32(txtId.Text));
                con.Open();
                int res = com.ExecuteNonQuery();
                if(res>0)
                {
                    MessageBox.Show("Record Deleted");
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
    }
}
