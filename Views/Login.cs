using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampoMinado_C_Sharp.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ClickComponent(object sender, EventArgs e)
        {
            try
            {
                if (sender is Button btn) { this.ManageEvents(btn.Tag.ToString()); }

                if (sender is LinkLabel ll) { this.ManageEvents(ll.Tag.ToString()); }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            } 
        }

        private void ManageEvents(string? tag)
        {
            try
            {
                switch (tag) 
                {
                    case "LOGIN":
                        this.DialogResult = DialogResult.OK;
                        break;                     
                    case "REGISTER":
                        MessageBox.Show(tag.ToString());
                        break;
                    case "FORGOT":
                        MessageBox.Show(tag.ToString());
                        break;
                    default: break;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
