using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class StudentData : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public StudentData()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select* from Stud";
                cmd = new SqlCommand(qry, con);
                con.Open();
                if (dr.HasRows)
                {
                    DataTable table = new DataTable();
                    table.Load(dr);
                    dataGridView1.DataSource = table;
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into Stud values (@roll_no, @s_name, @branch, @percentage)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@roll_no", txt_id.Text);
                cmd.Parameters.AddWithValue("@s_name", txtname.Text);
                cmd.Parameters.AddWithValue("@branch", txt_branch.Text);
                cmd.Parameters.AddWithValue("@percentage", txtPer.Text);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Record Inserted");
                }
            }
            catch (Exception ex)
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
            txt_id.Clear();
            txtname.Clear();
            txt_branch.Clear();
            txtPer.Clear();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select*from Stud where id=@roll_no";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@roll_n0", Convert.ToInt32(txt_id.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while(dr.Read())
                    {
                        txt_id.Text = dr["rollno"].ToString();
                        txtname.Text = dr["s_name"].ToString();
                        txt_branch.Text = dr["Bramch"].ToString();
                        txtPer.Text = dr["percentage"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record not Found");
                }
            }
            catch (Exception ex)
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
                string qry = "update Stud set name=@s_name, Branch=@branch, percentage=@percentage";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@s_name", txtname);
                cmd.Parameters.AddWithValue("@branch", txt_branch);
                cmd.Parameters.AddWithValue("@percentage", txtPer);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Record updated");
                    ClearForm();
                }
            }
            catch (Exception ex)
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
                string qry = "delete from Stud where id=@roll_no";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@roll_no", Convert.ToInt32(txt_id));
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Record Deleted");
                    ClearForm();
                }
            }
            catch (Exception ex)
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
