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
    public partial class SelectLevel : Form
    {
        public SelectLevel()
        {
            InitializeComponent();
            this.lbl_Welcome.Text = "Bem Vindo ao\n campo minado do GOD!";
            this.lbl_information.Text = "Selecione o level do game";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string? route = string.Empty;
            if (sender is Button)
            {
                route = ((Button)sender).Tag.ToString();
            }

            switch(route)
            {
                case "EASY":
                    MessageBox.Show("EASY");
                    break;
                
                case "MEDIUM":
                    MessageBox.Show("MEDIUM");
                    break;
                
                case "HARD":
                    MessageBox.Show("HARD");
                    break;

                default:
                    MessageBox.Show("cu");
                    break;
            }
        }
    }
}
