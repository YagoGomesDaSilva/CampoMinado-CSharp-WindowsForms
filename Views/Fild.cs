using CampoMinado_C_Sharp.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CampoMinado_C_Sharp.Entidades.Constants;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            this.IndexAroundBombs();
            this.ShowIndexes();

        }

        private void SizeFilde(Constants.MapDimension MD)
        {
            try
            {
                if (MD is Constants.MapDimension.easy) { this.Size = new System.Drawing.Size(490, 580); }
                if (MD is Constants.MapDimension.medium) { this.Size = new System.Drawing.Size(715, 805); }
                if (MD is Constants.MapDimension.hard) { this.Size = new System.Drawing.Size(940, 1030); }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void CreateFild()
        {
            try
            {
                int row_displacement = 0;
                int column_displacement = 0;
                short mapDimension = Convert.ToInt16(this._mapDimension);

                for (short i = 0; i < mapDimension; i++)
                {
                    List<Cell> row = new List<Cell>(); // Criar uma lista para representar uma linha

                    for (short j = 0; j < mapDimension; j++)
                    {
                        Cell cell = new Cell();
                        //cell.Text = $"{i}-{j}";
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
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void ConficurationCell(Cell cell, int row_displacement = 0, int column_displacement = 0)
        {
            try
            {
                cell.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                cell.Location = new Point(12 + row_displacement, 80 + column_displacement);
                cell.Size = new Size(45, 45);
                cell.UseVisualStyleBackColor = true;
                cell.Click += Cell_Click;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Cell_Click(object? sender, EventArgs e)
        {
            if(sender is Cell cell) { MessageBox.Show(cell.Bomb.ToString()); }
        }

        public void PlantBombs()
        {
            try
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

                    if (this.fild[i][j].Bomb is false)
                    {
                        this.fild[i][j].Bomb = true;
                        cont++;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        public void IndexAroundBombs(short mapDimension, List<List<Cell>> fild, short i, short j)
        {
            for (short r = -1; r < 2; r++)
            {
                for (short c = -1; r < 2; c++)
                {

                    if (i + r > mapDimension || i + r < 0 || j + c > mapDimension || j + c < 0)
                    {
                        continue;
                    }
                    else if (this.fild[i + r][j + c].Bomb is true) { }
                    else
                    {
                        this.fild[i + r][j + c].BombsAround++;
                    }
                }
            }
        }
       
        public void IndexAroundBombs()
        {
            try
            {
                int mapDimension = Convert.ToInt16(this._mapDimension);
                for (int i = 0; i <  mapDimension; i++) 
                {
                    for (int j = 0; j < mapDimension; j++)
                    {

                        if (this.fild[i][j].Bomb is true)
                        {

                            for (int r = -1; r < 2; r++)
                            {
                                for (int c = -1; c < 2; c++)
                                {

                                    if (i + r > mapDimension -1 || i + r < 0 || j + c > mapDimension -1 || j + c < 0)
                                    {
                                        continue;
                                    }
                                    else if (this.fild[i + r][j + c] is null) { }
                                    else if (this.fild[i + r][j + c].Bomb is true) { }
                                    else
                                    {
                                        this.fild[i + r][j + c].BombsAround++;
                                    }
                                }
                            }

                        }

                    }
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void ShowIndexes()
        {
            try
            {
                short mapDimension = Convert.ToInt16(this._mapDimension);
                for (short i = 0; i < mapDimension; i++)
                {
                    for (short j = 0; j < mapDimension; j++)
                    {

                        if (this.fild[i][j].Bomb is true)
                        {
                            this.fild[i][j].Text = this.fild[i][j].Bomb.ToString();
                        }
                        else
                        {
                            this.fild[i][j].Text = this.fild[i][j].BombsAround.ToString();
                        }
                    }
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

    }
}

