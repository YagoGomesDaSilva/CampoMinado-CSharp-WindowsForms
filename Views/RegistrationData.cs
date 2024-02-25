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
    public partial class RegistrationData : Form
    {
        const string REGISTER = "REGISTER";
        const string FORGOT = "FORGOT";

        #region Builders
        public RegistrationData(string parameter)
        {
            InitializeComponent();
            this.ScreenType(parameter);
            this.Shown += InitialMessage;

        }
        #endregion

        #region Methods
        private void ScreenType(string parameter)
        {
            if(parameter == REGISTER) { this.lbl_Title.Text = "Realize o seu cadastro!"; }
            if(parameter == FORGOT) { this.lbl_Title.Text = "Modifique sua senha!"; }
        }
        #endregion

        #region Events
        private void InitialMessage(object? sender, EventArgs e)
        {
            MessageBox.Show("Valide a existencia do usuario!");
        }
        #endregion
    }
}
