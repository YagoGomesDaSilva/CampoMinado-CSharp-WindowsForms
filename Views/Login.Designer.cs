namespace CampoMinado_C_Sharp.Views
{
    partial class Login
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
            btn_Login = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_Register = new Button();
            lbl_ForgotPassword = new LinkLabel();
            SuspendLayout();
            // 
            // btn_Login
            // 
            btn_Login.Anchor = AnchorStyles.None;
            btn_Login.Location = new Point(96, 155);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(91, 23);
            btn_Login.TabIndex = 3;
            btn_Login.Tag = "LOGIN";
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += ClickComponent;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(80, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 23);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(80, 109);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '●';
            textBox2.Size = new Size(128, 23);
            textBox2.TabIndex = 2;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(110, 30);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(113, 85);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // btn_Register
            // 
            btn_Register.Anchor = AnchorStyles.None;
            btn_Register.Location = new Point(96, 184);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(91, 23);
            btn_Register.TabIndex = 4;
            btn_Register.Tag = "REGISTER";
            btn_Register.Text = "Cadastrar";
            btn_Register.UseVisualStyleBackColor = true;
            btn_Register.Click += ClickComponent;
            // 
            // lbl_ForgotPassword
            // 
            lbl_ForgotPassword.Anchor = AnchorStyles.None;
            lbl_ForgotPassword.AutoSize = true;
            lbl_ForgotPassword.Location = new Point(96, 210);
            lbl_ForgotPassword.Name = "lbl_ForgotPassword";
            lbl_ForgotPassword.Size = new Size(91, 15);
            lbl_ForgotPassword.TabIndex = 5;
            lbl_ForgotPassword.TabStop = true;
            lbl_ForgotPassword.Tag = "FORGOT";
            lbl_ForgotPassword.Text = "Esqueci a Senha";
            lbl_ForgotPassword.Click += ClickComponent;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(lbl_ForgotPassword);
            Controls.Add(btn_Register);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btn_Login);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Login;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button btn_Register;
        private LinkLabel lbl_ForgotPassword;
    }
}