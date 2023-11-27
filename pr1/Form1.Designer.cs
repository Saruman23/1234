namespace pr1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Search = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.ТеstBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(13, 236);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(254, 110);
            this.Search.TabIndex = 0;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Edit
            // 
            this.Edit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit.Location = new System.Drawing.Point(403, 13);
            this.Edit.Margin = new System.Windows.Forms.Padding(4);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(171, 78);
            this.Edit.TabIndex = 1;
            this.Edit.Text = "Изменить ";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(417, 187);
            this.exit.Margin = new System.Windows.Forms.Padding(4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(157, 42);
            this.exit.TabIndex = 2;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // ТеstBtn
            // 
            this.ТеstBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ТеstBtn.Location = new System.Drawing.Point(329, 236);
            this.ТеstBtn.Name = "ТеstBtn";
            this.ТеstBtn.Size = new System.Drawing.Size(245, 110);
            this.ТеstBtn.TabIndex = 3;
            this.ТеstBtn.Text = "Тест";
            this.ТеstBtn.UseVisualStyleBackColor = true;
            this.ТеstBtn.Click += new System.EventHandler(this.ТеstBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 78);
            this.button1.TabIndex = 4;
            this.button1.Text = "Оценки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AutBtn
            // 
            this.AutBtn.Location = new System.Drawing.Point(104, 131);
            this.AutBtn.Name = "AutBtn";
            this.AutBtn.Size = new System.Drawing.Size(151, 67);
            this.AutBtn.TabIndex = 5;
            this.AutBtn.Text = "Авторизация";
            this.AutBtn.UseVisualStyleBackColor = true;
            this.AutBtn.Click += new System.EventHandler(this.AutBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(587, 356);
            this.Controls.Add(this.AutBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ТеstBtn);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курсач Писниченко 181";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button ТеstBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AutBtn;
    }
}

