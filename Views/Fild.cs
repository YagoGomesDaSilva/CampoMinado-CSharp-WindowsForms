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

        //private int _amontBombs;
        //private  int _mapDimension;
        Constants.AmountBombs _amontBombs;
        Constants.MapDimension _mapDimension;
        List<List<Cell>> fild = new List<List<Cell>>();




        public Fild(Constants.AmountBombs AB, Constants.MapDimension MD)
        {
            InitializeComponent();
            this._amontBombs = AB;
            this._mapDimension = MD;
            this.SizeFilde(this._mapDimension);
            this.CreateFild();

        }

        private void SizeFilde(Constants.MapDimension MD)
        {
            if (MD == Constants.MapDimension.easy) { this.Size = new System.Drawing.Size(490, 535); }
            if (MD == Constants.MapDimension.medium) { this.Size = new System.Drawing.Size(715, 760); }
            if (MD == Constants.MapDimension.hard) { this.Size = new System.Drawing.Size(940, 985); }
            //540; 580
        }

        public void CreateFild()
        {
            int row_displacement = 0;
            int column_displacement = 0;


            for (int i = 0; i < Convert.ToInt32(this._mapDimension); i++)
            {
                List<Cell> row = new List<Cell>(); // Criar uma lista para representar uma linha

                for (int j = 0; j < Convert.ToInt32(this._mapDimension); j++)
                {
                    Cell cell = new Cell();
                    cell.Text = $"{i}-{j}";
                    ConficurationCell(cell, row_displacement, column_displacement);
                    row_displacement += 45;
                    row.Add(cell); // Adicionar a célula à linha
                    Controls.Add(cell);// Adicionar os botões a um formulário para visualização
                }
                row_displacement = 0;
                column_displacement += 45;
                fild.Add(row); // Adicionar a linha à matriz
            }

        }

        public void ConficurationCell(Cell cell, int row_displacement = 0, int column_displacement = 0)
        {
            cell.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            cell.Location = new Point(12 + row_displacement, 35 + column_displacement);
            cell.Size = new Size(45, 45);
            cell.UseVisualStyleBackColor = true;
        }

       
    }
}

