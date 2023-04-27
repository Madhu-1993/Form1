namespace Form1
{
    partial class BookData
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtb_id = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.textauthor = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.butSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShowAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "b_id";
            // 
            // txt_name
            // 
            this.txt_name.AutoSize = true;
            this.txt_name.Location = new System.Drawing.Point(94, 152);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(45, 13);
            this.txt_name.TabIndex = 1;
            this.txt_name.Text = "b_name";
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Location = new System.Drawing.Point(94, 227);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(37, 13);
            this.author.TabIndex = 2;
            this.author.Text = "author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "price";
            // 
            // txtb_id
            // 
            this.txtb_id.Location = new System.Drawing.Point(239, 71);
            this.txtb_id.Name = "txtb_id";
            this.txtb_id.Size = new System.Drawing.Size(100, 20);
            this.txtb_id.TabIndex = 4;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(239, 145);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(100, 20);
            this.textname.TabIndex = 5;
            // 
            // textauthor
            // 
            this.textauthor.Location = new System.Drawing.Point(239, 220);
            this.textauthor.Name = "textauthor";
            this.textauthor.Size = new System.Drawing.Size(100, 20);
            this.textauthor.TabIndex = 6;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(239, 297);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(100, 20);
            this.textPrice.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(88, 372);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // butSearch
            // 
            this.butSearch.Location = new System.Drawing.Point(239, 372);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(75, 23);
            this.butSearch.TabIndex = 9;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(400, 175);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(400, 239);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(492, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(296, 347);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(606, 12);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 13;
            this.btnShowAll.Text = "ShowAll";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // BookData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textauthor);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.txtb_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.author);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Name = "BookData";
            this.Text = "BookData";
            this.Load += new System.EventHandler(this.BookData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_name;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtb_id;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textauthor;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShowAll;
    }
}