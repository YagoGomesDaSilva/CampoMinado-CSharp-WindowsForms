namespace CampoMinado_C_Sharp.Views
{
    partial class SelectLevel
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
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_information = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Welcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Welcome.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Welcome.Location = new System.Drawing.Point(250, 10);
            this.lbl_Welcome.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(482, 85);
            this.lbl_Welcome.TabIndex = 0;
            this.lbl_Welcome.Text = "lbl_Welcome";
            this.lbl_Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Welcome.UseMnemonic = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(180, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 80);
            this.button1.TabIndex = 1;
            this.button1.Tag = "EASY";
            this.button1.Text = "btn_easy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_Click);
            // 
            // lbl_information
            // 
            this.lbl_information.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_information.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_information.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_information.Location = new System.Drawing.Point(250, 133);
            this.lbl_information.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_information.Name = "lbl_information";
            this.lbl_information.Size = new System.Drawing.Size(482, 39);
            this.lbl_information.TabIndex = 5;
            this.lbl_information.Text = "lbl_information";
            this.lbl_information.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_information.UseMnemonic = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Location = new System.Drawing.Point(417, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 80);
            this.button2.TabIndex = 6;
            this.button2.Tag = "MEDIUM";
            this.button2.Text = "btn_medium";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Location = new System.Drawing.Point(652, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 80);
            this.button3.TabIndex = 7;
            this.button3.Tag = "HARD";
            this.button3.Text = "btn_hard";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.Location = new System.Drawing.Point(417, 340);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 50);
            this.button4.TabIndex = 8;
            this.button4.Tag = "RECORDS";
            this.button4.Text = "btn_records";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_Click);
            // 
            // SelectLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_information);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Welcome);
            this.Name = "SelectLevel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectLevel";
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbl_Welcome;
        private Button button1;
        private Label lbl_information;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}