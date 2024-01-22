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
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBoxFild
            // 
            GroupBoxFild.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GroupBoxFild.Location = new Point(12, 3);
            GroupBoxFild.Name = "GroupBoxFild";
            GroupBoxFild.Size = new Size(500, 74);
            GroupBoxFild.TabIndex = 0;
            GroupBoxFild.TabStop = false;
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
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox GroupBoxFild;
        private Panel panel1;
    }
}