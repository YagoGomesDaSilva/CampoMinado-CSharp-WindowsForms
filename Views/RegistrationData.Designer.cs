namespace CampoMinado_C_Sharp.Views
{
    partial class RegistrationData
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
            lbl_User = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lbl_Email = new Label();
            textBox3 = new TextBox();
            lbl_Password = new Label();
            btn_Validate = new Button();
            btn_Save = new Button();
            lbl_Title = new Label();
            SuspendLayout();
            // 
            // lbl_User
            // 
            lbl_User.AutoSize = true;
            lbl_User.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_User.Location = new Point(12, 83);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new Size(67, 21);
            lbl_User.TabIndex = 0;
            lbl_User.Text = "Usuario:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(85, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 23);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(85, 114);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 23);
            textBox2.TabIndex = 3;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Email.Location = new Point(28, 112);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(51, 21);
            lbl_Email.TabIndex = 2;
            lbl_Email.Text = "Email:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(85, 143);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '●';
            textBox3.Size = new Size(187, 23);
            textBox3.TabIndex = 5;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Password.Location = new Point(23, 141);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(56, 21);
            lbl_Password.TabIndex = 4;
            lbl_Password.Text = "Senha:";
            // 
            // btn_Validate
            // 
            btn_Validate.Location = new Point(105, 187);
            btn_Validate.Name = "btn_Validate";
            btn_Validate.Size = new Size(75, 23);
            btn_Validate.TabIndex = 6;
            btn_Validate.Text = "Validar";
            btn_Validate.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(105, 216);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(75, 23);
            btn_Save.TabIndex = 7;
            btn_Save.Text = "Salvar";
            btn_Save.UseVisualStyleBackColor = true;
            // 
            // lbl_Title
            // 
            lbl_Title.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Title.Location = new Point(12, 29);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(260, 23);
            lbl_Title.TabIndex = 8;
            lbl_Title.Text = "Titulo";
            lbl_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegistrationData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(lbl_Title);
            Controls.Add(btn_Save);
            Controls.Add(btn_Validate);
            Controls.Add(textBox3);
            Controls.Add(lbl_Password);
            Controls.Add(textBox2);
            Controls.Add(lbl_Email);
            Controls.Add(textBox1);
            Controls.Add(lbl_User);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "RegistrationData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrationData";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_User;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lbl_Email;
        private TextBox textBox3;
        private Label lbl_Password;
        private Button btn_Validate;
        private Button btn_Save;
        private Label lbl_Title;
    }
}