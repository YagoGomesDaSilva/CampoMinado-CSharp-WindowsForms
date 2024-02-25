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
        #region Builders
        public Login()
        {
            InitializeComponent();
        }
        #endregion  

        #region Methods
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
                        this.Visible = false;
                        _ = new Views.RegistrationData(tag).ShowDialog() == DialogResult.OK;
                        break;
                    case "FORGOT":
                        this.Visible = false;
                        _ = new Views.RegistrationData(tag).ShowDialog() == DialogResult.OK;
                        break;
                    default: break;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                this.Visible = true;
            }
        }
        #endregion

        #region Eventos
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

        #endregion
    }
}
