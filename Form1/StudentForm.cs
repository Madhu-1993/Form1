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
    public partial class StudentForm : Form
    {
        SqlConnection con;
        SqlCommandBuilder scb;
        SqlDataAdapter da;
        DataSet ds;
        public StudentForm()
        {
            InitializeComponent();
            con=new SqlConnection(ConfigurationManager.ConnectionStrings["dafaultConnection"].ConnectionString);
        }

        private DataSet GetAllStudent()
        {
            string qry = "select*from Student";
            da = new SqlDataAdapter(qry, con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            scb=new SqlCommandBuilder(da);
            ds=new DataSet();
            da.Fill(ds, "Student");
            return ds;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllStudent();
                DataRow row = ds.Tables["Student"].NewRow();
                row["Rollno"] = txt_rollno.Text;
                row["Sname"] = txtsname.Text;
                row["Branch"] = txtbrnch.Text;
                row["Percentage"] = txtper.Text;
                ds.Tables["Student"].Rows.Add(row);
                int res = da.Update(ds.Tables["Student"]);
                if(res>0)
                {
                    MessageBox.Show("Record Inserted");
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
                ds = GetAllStudent();
                DataRow row= ds.Tables["Student"].Rows.Find(txt_rollno.Text);
                if(row!=null)
                {
                    txt_rollno.Text = row["Student"].ToString();
                    txtsname.Text = row["Student"].ToString();
                    txtbrnch.Text = row["Student"].ToString();
                    txtper.Text = row["Student"].ToString();
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
                ds=GetAllStudent();
                DataRow row = ds.Tables["Student"].Rows.Find(txt_rollno.Text);
                if(row!=null)
                {
                  //  row["Rollno"] = txt_rollno.Text;
                    row["Sname"] = txtsname.Text;
                    row["Branch"] = txtbrnch.Text;
                    row["Percentage"] = txtper.Text;
                    int res = da.Update(ds.Tables["Student"]);
                    if(res>0)
                    {
                        MessageBox.Show("Record is updated");
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
                ds = GetAllStudent();
                DataRow row = ds.Tables["Student"].Rows.Find(txt_rollno.Text);
                if(row!=null)
                {
                    row.Delete();
                    int res = da.Update(ds.Tables["Student"]);
                    if(res>0)
                    {
                        MessageBox.Show("Recorrd daleted");
                    }
                }
                else
                {
                    MessageBox.Show("record not found");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowAllStudent_Click(object sender, EventArgs e)
        {
            ds = GetAllStudent();
            dataGridView1.DataSource = ds.Tables["Student"];
        }
    }
}
