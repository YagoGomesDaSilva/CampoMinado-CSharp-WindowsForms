namespace CampoMinado_C_Sharp.Views
{
    partial class Fild
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
            GroupBoxFild = new GroupBox();
            groupBox1 = new GroupBox();
            lbl_TimeRecord = new Label();
            panel1 = new Panel();
            GroupBoxFild.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBoxFild
            // 
            GroupBoxFild.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GroupBoxFild.Controls.Add(groupBox1);
            GroupBoxFild.Location = new Point(12, -1);
            GroupBoxFild.Name = "GroupBoxFild";
            GroupBoxFild.Size = new Size(500, 75);
            GroupBoxFild.TabIndex = 0;
            GroupBoxFild.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(lbl_TimeRecord);
            groupBox1.Location = new Point(400, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(94, 50);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // lbl_TimeRecord
            // 
            lbl_TimeRecord.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_TimeRecord.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TimeRecord.Location = new Point(9, 13);
            lbl_TimeRecord.Name = "lbl_TimeRecord";
            lbl_TimeRecord.Size = new Size(76, 30);
            lbl_TimeRecord.TabIndex = 0;
            lbl_TimeRecord.Text = "99999";
            lbl_TimeRecord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(GroupBoxFild);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(524, 80);
            panel1.TabIndex = 1;
            // 
            // Fild
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 541);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Fild";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fild";
            GroupBoxFild.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox GroupBoxFild;
        private Panel panel1;
        private Label lbl_TimeRecord;
        private GroupBox groupBox1;
    }
}