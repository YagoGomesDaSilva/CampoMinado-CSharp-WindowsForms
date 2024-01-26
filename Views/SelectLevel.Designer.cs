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
            lbl_Welcome = new Label();
            btn_easy = new Button();
            lbl_information = new Label();
            btn_medium = new Button();
            btn_hard = new Button();
            btn_records = new Button();
            SuspendLayout();
            // 
            // lbl_Welcome
            // 
            lbl_Welcome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_Welcome.BorderStyle = BorderStyle.FixedSingle;
            lbl_Welcome.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Welcome.Location = new Point(250, 10);
            lbl_Welcome.Margin = new Padding(0);
            lbl_Welcome.Name = "lbl_Welcome";
            lbl_Welcome.Size = new Size(482, 85);
            lbl_Welcome.TabIndex = 0;
            lbl_Welcome.Text = "lbl_Welcome";
            lbl_Welcome.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Welcome.UseMnemonic = false;
            // 
            // btn_easy
            // 
            btn_easy.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_easy.Location = new Point(180, 220);
            btn_easy.Name = "btn_easy";
            btn_easy.Size = new Size(150, 80);
            btn_easy.TabIndex = 0;
            btn_easy.Tag = "EASY";
            btn_easy.Text = "btn_easy";
            btn_easy.UseVisualStyleBackColor = true;
            btn_easy.Click += btn_Click;
            // 
            // lbl_information
            // 
            lbl_information.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl_information.BorderStyle = BorderStyle.FixedSingle;
            lbl_information.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_information.Location = new Point(250, 133);
            lbl_information.Margin = new Padding(0);
            lbl_information.Name = "lbl_information";
            lbl_information.Size = new Size(482, 39);
            lbl_information.TabIndex = 5;
            lbl_information.Text = "lbl_information";
            lbl_information.TextAlign = ContentAlignment.MiddleCenter;
            lbl_information.UseMnemonic = false;
            // 
            // btn_medium
            // 
            btn_medium.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_medium.Location = new Point(417, 220);
            btn_medium.Name = "btn_medium";
            btn_medium.Size = new Size(150, 80);
            btn_medium.TabIndex = 1;
            btn_medium.Tag = "MEDIUM";
            btn_medium.Text = "btn_medium";
            btn_medium.UseVisualStyleBackColor = true;
            btn_medium.Click += btn_Click;
            // 
            // btn_hard
            // 
            btn_hard.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_hard.Location = new Point(652, 220);
            btn_hard.Name = "btn_hard";
            btn_hard.Size = new Size(150, 80);
            btn_hard.TabIndex = 3;
            btn_hard.Tag = "HARD";
            btn_hard.Text = "btn_hard";
            btn_hard.UseVisualStyleBackColor = true;
            btn_hard.Click += btn_Click;
            // 
            // btn_records
            // 
            btn_records.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_records.Location = new Point(417, 340);
            btn_records.Name = "btn_records";
            btn_records.Size = new Size(150, 50);
            btn_records.TabIndex = 4;
            btn_records.Tag = "RECORDS";
            btn_records.Text = "btn_records";
            btn_records.UseVisualStyleBackColor = true;
            btn_records.Click += btn_Click;
            // 
            // SelectLevel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(btn_records);
            Controls.Add(btn_hard);
            Controls.Add(btn_medium);
            Controls.Add(lbl_information);
            Controls.Add(btn_easy);
            Controls.Add(lbl_Welcome);
            Name = "SelectLevel";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelectLevel";
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_Welcome;
        private Button btn_easy;
        private Label lbl_information;
        private Button btn_medium;
        private Button btn_hard;
        private Button btn_records;
    }
}