namespace Form1
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtrollno = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.Label();
            this.txt_Branch = new System.Windows.Forms.Label();
            this.txt_per = new System.Windows.Forms.Label();
            this.txt_rollno = new System.Windows.Forms.TextBox();
            this.txtsname = new System.Windows.Forms.TextBox();
            this.txtbrnch = new System.Windows.Forms.TextBox();
            this.txtper = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShowAllStudent = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtrollno
            // 
            this.txtrollno.AutoSize = true;
            this.txtrollno.Location = new System.Drawing.Point(89, 95);
            this.txtrollno.Name = "txtrollno";
            this.txtrollno.Size = new System.Drawing.Size(37, 13);
            this.txtrollno.TabIndex = 0;
            this.txtrollno.Text = "Rollno";
            // 
            // txtname
            // 
            this.txtname.AutoSize = true;
            this.txtname.Location = new System.Drawing.Point(89, 157);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(46, 13);
            this.txtname.TabIndex = 1;
            this.txtname.Text = "S_name";
            // 
            // txt_Branch
            // 
            this.txt_Branch.AutoSize = true;
            this.txt_Branch.Location = new System.Drawing.Point(89, 228);
            this.txt_Branch.Name = "txt_Branch";
            this.txt_Branch.Size = new System.Drawing.Size(41, 13);
            this.txt_Branch.TabIndex = 2;
            this.txt_Branch.Text = "Branch";
            // 
            // txt_per
            // 
            this.txt_per.AutoSize = true;
            this.txt_per.Location = new System.Drawing.Point(89, 298);
            this.txt_per.Name = "txt_per";
            this.txt_per.Size = new System.Drawing.Size(62, 13);
            this.txt_per.TabIndex = 3;
            this.txt_per.Text = "Percentage";
            // 
            // txt_rollno
            // 
            this.txt_rollno.Location = new System.Drawing.Point(320, 88);
            this.txt_rollno.Name = "txt_rollno";
            this.txt_rollno.Size = new System.Drawing.Size(100, 20);
            this.txt_rollno.TabIndex = 4;
            // 
            // txtsname
            // 
            this.txtsname.Location = new System.Drawing.Point(320, 154);
            this.txtsname.Name = "txtsname";
            this.txtsname.Size = new System.Drawing.Size(100, 20);
            this.txtsname.TabIndex = 5;
            // 
            // txtbrnch
            // 
            this.txtbrnch.Location = new System.Drawing.Point(320, 224);
            this.txtbrnch.Name = "txtbrnch";
            this.txtbrnch.Size = new System.Drawing.Size(100, 20);
            this.txtbrnch.TabIndex = 6;
            // 
            // txtper
            // 
            this.txtper.Location = new System.Drawing.Point(320, 295);
            this.txtper.Name = "txtper";
            this.txtper.Size = new System.Drawing.Size(100, 20);
            this.txtper.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 365);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(137, 365);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(276, 365);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(419, 365);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShowAllStudent
            // 
            this.btnShowAllStudent.Location = new System.Drawing.Point(608, 40);
            this.btnShowAllStudent.Name = "btnShowAllStudent";
            this.btnShowAllStudent.Size = new System.Drawing.Size(90, 23);
            this.btnShowAllStudent.TabIndex = 12;
            this.btnShowAllStudent.Text = "ShowAllSrtud";
            this.btnShowAllStudent.UseVisualStyleBackColor = true;
            this.btnShowAllStudent.Click += new System.EventHandler(this.btnShowAllStudent_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(526, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 300);
            this.dataGridView1.TabIndex = 13;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnShowAllStudent);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtper);
            this.Controls.Add(this.txtbrnch);
            this.Controls.Add(this.txtsname);
            this.Controls.Add(this.txt_rollno);
            this.Controls.Add(this.txt_per);
            this.Controls.Add(this.txt_Branch);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtrollno);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtrollno;
        private System.Windows.Forms.Label txtname;
        private System.Windows.Forms.Label txt_Branch;
        private System.Windows.Forms.Label txt_per;
        private System.Windows.Forms.TextBox txt_rollno;
        private System.Windows.Forms.TextBox txtsname;
        private System.Windows.Forms.TextBox txtbrnch;
        private System.Windows.Forms.TextBox txtper;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShowAllStudent;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}