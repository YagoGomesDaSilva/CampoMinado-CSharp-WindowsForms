using CampoMinado_C_Sharp.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampoMinado_C_Sharp.Views
{
    public partial class Fild : Form
    {

        Constants.AmountBombs _amontBombs;
        Constants.MapDimension _mapDimension;

        public Fild(Constants.AmountBombs AB, Constants.MapDimension MD)
        {
            InitializeComponent();
            this._amontBombs = AB;
            this._mapDimension = MD;
        }
    }
}
