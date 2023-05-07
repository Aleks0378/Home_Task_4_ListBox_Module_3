namespace Home_Task_4_ListBox_Module_3
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
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.but_edit = new System.Windows.Forms.Button();
            this.but_delete = new System.Windows.Forms.Button();
            this.but_clear = new System.Windows.Forms.Button();
            this.but_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(87, 26);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(328, 22);
            this.name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname";
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(87, 64);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(328, 22);
            this.surname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "E-mail";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(87, 102);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(328, 22);
            this.mail.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mobile";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(87, 142);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(207, 22);
            this.phone.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(38, 195);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(389, 228);
            this.listBox1.TabIndex = 9;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // but_edit
            // 
            this.but_edit.Enabled = false;
            this.but_edit.Location = new System.Drawing.Point(463, 195);
            this.but_edit.Name = "but_edit";
            this.but_edit.Size = new System.Drawing.Size(116, 26);
            this.but_edit.TabIndex = 10;
            this.but_edit.Text = "Edit";
            this.but_edit.UseVisualStyleBackColor = true;
            this.but_edit.Click += new System.EventHandler(this.but_edit_Click);
            // 
            // but_delete
            // 
            this.but_delete.Enabled = false;
            this.but_delete.Location = new System.Drawing.Point(463, 239);
            this.but_delete.Name = "but_delete";
            this.but_delete.Size = new System.Drawing.Size(116, 26);
            this.but_delete.TabIndex = 11;
            this.but_delete.Text = "Delete";
            this.but_delete.UseVisualStyleBackColor = true;
            this.but_delete.Click += new System.EventHandler(this.but_delete_Click);
            // 
            // but_clear
            // 
            this.but_clear.Location = new System.Drawing.Point(463, 70);
            this.but_clear.Name = "but_clear";
            this.but_clear.Size = new System.Drawing.Size(116, 26);
            this.but_clear.TabIndex = 13;
            this.but_clear.Text = "Clear";
            this.but_clear.UseVisualStyleBackColor = true;
            this.but_clear.Click += new System.EventHandler(this.but_clear_Click);
            // 
            // but_add
            // 
            this.but_add.Location = new System.Drawing.Point(463, 26);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(116, 26);
            this.but_add.TabIndex = 12;
            this.but_add.Text = "Add";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.but_clear);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.but_delete);
            this.Controls.Add(this.but_edit);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button but_edit;
        private System.Windows.Forms.Button but_delete;
        private System.Windows.Forms.Button but_clear;
        private System.Windows.Forms.Button but_add;
    }
}

