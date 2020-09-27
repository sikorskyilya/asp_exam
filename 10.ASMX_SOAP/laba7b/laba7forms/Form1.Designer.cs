namespace laba7forms
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
            this.Get = new System.Windows.Forms.Button();
            this.Post = new System.Windows.Forms.Button();
            this.Put = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numUpd = new System.Windows.Forms.TextBox();
            this.nameUpd = new System.Windows.Forms.TextBox();
            this.idUpd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Get
            // 
            this.Get.Location = new System.Drawing.Point(39, 425);
            this.Get.Name = "Get";
            this.Get.Size = new System.Drawing.Size(715, 23);
            this.Get.TabIndex = 0;
            this.Get.Text = "Get";
            this.Get.UseVisualStyleBackColor = true;
            this.Get.Click += new System.EventHandler(this.Get_Click);
            // 
            // Post
            // 
            this.Post.Location = new System.Drawing.Point(19, 77);
            this.Post.Name = "Post";
            this.Post.Size = new System.Drawing.Size(75, 23);
            this.Post.TabIndex = 1;
            this.Post.Text = "Post";
            this.Post.UseVisualStyleBackColor = true;
            this.Post.Click += new System.EventHandler(this.Post_Click);
            // 
            // Put
            // 
            this.Put.Location = new System.Drawing.Point(265, 36);
            this.Put.Name = "Put";
            this.Put.Size = new System.Drawing.Size(75, 23);
            this.Put.TabIndex = 2;
            this.Put.Text = "Put";
            this.Put.UseVisualStyleBackColor = true;
            this.Put.Click += new System.EventHandler(this.Put_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(31, 77);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(31, 38);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(152, 22);
            this.id.TabIndex = 4;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(80, 14);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(152, 22);
            this.name.TabIndex = 5;
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(80, 47);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(152, 22);
            this.num.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Number";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(35, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(719, 266);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(35, 284);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(715, 135);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.name);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.num);
            this.tabPage1.Controls.Add(this.Post);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(707, 106);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numUpd);
            this.tabPage2.Controls.Add(this.nameUpd);
            this.tabPage2.Controls.Add(this.idUpd);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.Put);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(707, 106);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numUpd
            // 
            this.numUpd.Location = new System.Drawing.Point(94, 66);
            this.numUpd.Name = "numUpd";
            this.numUpd.Size = new System.Drawing.Size(152, 22);
            this.numUpd.TabIndex = 8;
            // 
            // nameUpd
            // 
            this.nameUpd.Location = new System.Drawing.Point(94, 37);
            this.nameUpd.Name = "nameUpd";
            this.nameUpd.Size = new System.Drawing.Size(152, 22);
            this.nameUpd.TabIndex = 7;
            // 
            // idUpd
            // 
            this.idUpd.Location = new System.Drawing.Point(94, 9);
            this.idUpd.Name = "idUpd";
            this.idUpd.Size = new System.Drawing.Size(152, 22);
            this.idUpd.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Id";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.id);
            this.tabPage3.Controls.Add(this.Delete);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(707, 106);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Get);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Get;
        private System.Windows.Forms.Button Post;
        private System.Windows.Forms.Button Put;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idUpd;
        private System.Windows.Forms.TextBox nameUpd;
        private System.Windows.Forms.TextBox numUpd;
    }
}

