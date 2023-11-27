namespace pr1
{
    partial class Edit
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Updatebtn1 = new System.Windows.Forms.Button();
            this.Deletebtn1 = new System.Windows.Forms.Button();
            this.Addbtn1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Updatebtn2 = new System.Windows.Forms.Button();
            this.Deletebtn2 = new System.Windows.Forms.Button();
            this.Addbtn2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(773, 376);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.Updatebtn1);
            this.tabPage1.Controls.Add(this.Deletebtn1);
            this.tabPage1.Controls.Add(this.Addbtn1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(765, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Работники";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 7);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(747, 284);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Updatebtn1
            // 
            this.Updatebtn1.Location = new System.Drawing.Point(602, 299);
            this.Updatebtn1.Margin = new System.Windows.Forms.Padding(4);
            this.Updatebtn1.Name = "Updatebtn1";
            this.Updatebtn1.Size = new System.Drawing.Size(153, 49);
            this.Updatebtn1.TabIndex = 3;
            this.Updatebtn1.Text = "Обновить";
            this.Updatebtn1.UseVisualStyleBackColor = true;
            this.Updatebtn1.Click += new System.EventHandler(this.Updatebtn1_Click);
            // 
            // Deletebtn1
            // 
            this.Deletebtn1.Location = new System.Drawing.Point(8, 299);
            this.Deletebtn1.Margin = new System.Windows.Forms.Padding(4);
            this.Deletebtn1.Name = "Deletebtn1";
            this.Deletebtn1.Size = new System.Drawing.Size(172, 45);
            this.Deletebtn1.TabIndex = 2;
            this.Deletebtn1.Text = "Удалить";
            this.Deletebtn1.UseVisualStyleBackColor = true;
            this.Deletebtn1.Click += new System.EventHandler(this.Deletebtn1_Click);
            // 
            // Addbtn1
            // 
            this.Addbtn1.Location = new System.Drawing.Point(313, 299);
            this.Addbtn1.Margin = new System.Windows.Forms.Padding(4);
            this.Addbtn1.Name = "Addbtn1";
            this.Addbtn1.Size = new System.Drawing.Size(160, 45);
            this.Addbtn1.TabIndex = 1;
            this.Addbtn1.Text = "Добавить";
            this.Addbtn1.UseVisualStyleBackColor = true;
            this.Addbtn1.Click += new System.EventHandler(this.Addbtn1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.Updatebtn2);
            this.tabPage2.Controls.Add(this.Deletebtn2);
            this.tabPage2.Controls.Add(this.Addbtn2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(765, 347);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Профессии";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 8);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(757, 283);
            this.dataGridView2.TabIndex = 5;
            // 
            // Updatebtn2
            // 
            this.Updatebtn2.Location = new System.Drawing.Point(620, 299);
            this.Updatebtn2.Margin = new System.Windows.Forms.Padding(4);
            this.Updatebtn2.Name = "Updatebtn2";
            this.Updatebtn2.Size = new System.Drawing.Size(131, 45);
            this.Updatebtn2.TabIndex = 4;
            this.Updatebtn2.Text = "Обновить";
            this.Updatebtn2.UseVisualStyleBackColor = true;
            this.Updatebtn2.Click += new System.EventHandler(this.Updatebtn2_Click);
            // 
            // Deletebtn2
            // 
            this.Deletebtn2.Location = new System.Drawing.Point(8, 299);
            this.Deletebtn2.Margin = new System.Windows.Forms.Padding(4);
            this.Deletebtn2.Name = "Deletebtn2";
            this.Deletebtn2.Size = new System.Drawing.Size(114, 45);
            this.Deletebtn2.TabIndex = 3;
            this.Deletebtn2.Text = "Удалить";
            this.Deletebtn2.UseVisualStyleBackColor = true;
            this.Deletebtn2.Click += new System.EventHandler(this.Deletebtn2_Click);
            // 
            // Addbtn2
            // 
            this.Addbtn2.Location = new System.Drawing.Point(317, 299);
            this.Addbtn2.Margin = new System.Windows.Forms.Padding(4);
            this.Addbtn2.Name = "Addbtn2";
            this.Addbtn2.Size = new System.Drawing.Size(124, 45);
            this.Addbtn2.TabIndex = 2;
            this.Addbtn2.Text = "Добавить";
            this.Addbtn2.UseVisualStyleBackColor = true;
            this.Addbtn2.Click += new System.EventHandler(this.Addbtn2_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 418);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение данных";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Addbtn1;
        private System.Windows.Forms.Button Addbtn2;
        private System.Windows.Forms.Button Deletebtn1;
        private System.Windows.Forms.Button Deletebtn2;
        private System.Windows.Forms.Button Updatebtn1;
        private System.Windows.Forms.Button Updatebtn2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}