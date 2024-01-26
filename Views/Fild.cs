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
        List<List<Cell>> fild = new List<List<Cell>>();

        public Fild(Constants.AmountBombs AB, Constants.MapDimension MD)
        {
            InitializeComponent();
            this._amontBombs = AB;
            this._mapDimension = MD;
            this.SizeFilde(this._mapDimension);
            this.CreateFild();
            this.PlantBombs();

        }

        private void SizeFilde(Constants.MapDimension MD)
        {     
            if (MD == Constants.MapDimension.easy) { this.Size = new System.Drawing.Size(490, 580); }
            if (MD == Constants.MapDimension.medium) { this.Size = new System.Drawing.Size(715, 805); }
            if (MD == Constants.MapDimension.hard) { this.Size = new System.Drawing.Size(940, 1030); }
        }

        public void CreateFild()
        {
            int row_displacement = 0;
            int column_displacement = 0;

            for (short i = 0; i < Convert.ToInt32(this._mapDimension); i++)
            {
                List<Cell> row = new List<Cell>(); // Criar uma lista para representar uma linha

                for (short j = 0; j < Convert.ToInt32(this._mapDimension); j++)
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
            cell.Location = new Point(12 + row_displacement, 80 + column_displacement);
            cell.Size = new Size(45, 45);
            cell.UseVisualStyleBackColor = true;
            cell.Click += Cell_Click;
        }

        private void Cell_Click(object? sender, EventArgs e)
        {
            if(sender is Cell cell) { MessageBox.Show(cell.Bomb.ToString()); }
        }

        public void PlantBombs()
        {
            Random row = new Random();
            Random column = new Random();
            short amontBombs = Convert.ToInt16(this._amontBombs);
            short mapDimension = Convert.ToInt16(this._mapDimension);
            short cont = 0;
            while (amontBombs != cont)
            {
                short i = (short)row.Next(0, mapDimension);
                short j = (short)column.Next(0, mapDimension);

                if (this.fild[i][j].Bomb == false)
                {
                    this.fild[i][j].Bomb = true;
                    cont++;
                }
            }   
        }


    }
}

