namespace ProtoTest
{
    partial class UserInput
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
            this.button = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(113, 249);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(100, 30);
            this.button.TabIndex = 17;
            this.button.Text = "Применить";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(87, 209);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(150, 22);
            this.textBoxEmail.TabIndex = 16;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(84, 189);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(138, 17);
            this.labelEmail.TabIndex = 15;
            this.labelEmail.Text = "Электронная почта";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(84, 135);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(62, 17);
            this.labelBirthDate.TabIndex = 13;
            this.labelBirthDate.Text = "Возраст";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(87, 100);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(150, 22);
            this.textBoxSurname.TabIndex = 12;
            this.textBoxSurname.TextChanged += new System.EventHandler(this.textBoxSurname_TextChanged);
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(84, 80);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(70, 17);
            this.labelSurname.TabIndex = 11;
            this.labelSurname.Text = "Фамилия";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(87, 44);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(150, 22);
            this.textBoxName.TabIndex = 10;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(84, 24);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 17);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Имя";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(87, 155);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(150, 22);
            this.textBoxAge.TabIndex = 18;
            this.textBoxAge.TextChanged += new System.EventHandler(this.textBoxAge_TextChanged);
            this.textBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAge_KeyPress);
            // 
            // UserInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 303);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserInput";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxAge;
    }
}

