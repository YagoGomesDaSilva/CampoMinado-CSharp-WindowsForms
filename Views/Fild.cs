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
        //proximo passo : , bandeira,
        #region Attributes
        const string FLAG_TEXT = "🚩";
        Constants.AmountBombs _amontBombs;
        Constants.MapDimension _mapDimension;
        List<List<Cell>> fild = new List<List<Cell>>();
        #endregion

        #region Builders
        public Fild(Constants.AmountBombs AB, Constants.MapDimension MD)
        {
            InitializeComponent();
            this._amontBombs = AB;
            this._mapDimension = MD;
            this.SizeFilde(this._mapDimension);
            this.CreateFild();
            this.PlantBombs();
            this.IndexAroundBombs();
            //this.ShowIndexes();

        }
        #endregion

        #region Methods
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
                        ConficurationCell(cell, row_displacement, column_displacement, i, j);
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

        public void ConficurationCell(Cell cell, int row_displacement = 0, int column_displacement = 0, short i = 0, short j = 0)
        {
            try
            {
                cell.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                cell.Location = new Point(12 + row_displacement, 80 + column_displacement);
                cell.X = i;
                cell.Y = j;
                cell.Size = new Size(45, 45);
                cell.UseVisualStyleBackColor = true;
                cell.BringToFront();
                cell.MouseDown += Cell_Click;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
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
       
        public void IndexAroundBombs()
        {
            try
            {
                short mapDimension = Convert.ToInt16(this._mapDimension);
                for (short i = 0; i <  mapDimension; i++) 
                {
                    for (short j = 0; j < mapDimension; j++)
                    {

                        if (this.fild[i][j].Bomb is true)
                        {

                            for (short r = -1; r < 2; r++)
                            {
                                for (short c = -1; c < 2; c++)
                                {

                                    if (i + r > mapDimension -1 || i + r < 0 || j + c > mapDimension -1 || j + c < 0)
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

        public void RevealCell(Cell cell)
        {
            try
            {
                if (cell.Bomb is true) { cell.Revealed = true; cell.Text = cell.Bomb.ToString(); return; }

                if (cell.Revealed == false)
                {
                    if (cell.BombsAround == 0)
                    {
                        this.RevealRecursiveCells(cell);
                    }
                    else
                    {
                        cell.Revealed = true;
                        cell.Text = cell.BombsAround.ToString();
                    }
                }
                else
                {
                    this.RevealAround(cell);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void RevealRecursiveCells(Cell cell)
        {
            try
            {
                short mapDimension = Convert.ToInt16(this._mapDimension);
                short x = cell.X;
                short y = cell.Y;
                this.RecursiveCells(mapDimension, x, y);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void RecursiveCells(short mapDimension, int x, int y)
        {
            try
            {
                if (!(x <= -1 || x > mapDimension - 1 || y <= -1 || y > mapDimension -1))
                {                 
                    if (this.fild[x][y].BombsAround == 0 && this.fild[x][y].Revealed is false)
                    {
                        if (this.fild[x][y].Flag is false)
                        {
                            this.fild[x][y].Revealed = true;
                            this.fild[x][y].Text = this.fild[x][y].BombsAround.ToString();
                        }

                        RecursiveCells(mapDimension, x, y - 1);//esquerda
                        RecursiveCells(mapDimension, x, y + 1);//direita
                        RecursiveCells(mapDimension, x + 1, y);//baixo
                        RecursiveCells(mapDimension, x - 1, y);//cima

                        RecursiveCells(mapDimension, x - 1, y - 1);//diagonal superior esquerda
                        RecursiveCells(mapDimension, x + 1, y + 1);// diagonal inferior dierita

                        RecursiveCells(mapDimension, x + 1, y - 1);//diagonal inferior esquerda
                        RecursiveCells(mapDimension, x - 1, y + 1);//diagonal superior direita

                    }
                    else if (this.fild[x][y].BombsAround >= 1 && this.fild[x][y].BombsAround <= 5)
                    {
                        if (this.fild[x][y].Flag is false)
                        {
                            this.fild[x][y].Revealed = true;
                            this.fild[x][y].Text = this.fild[x][y].BombsAround.ToString();
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void RevealAround(Cell cell)
        {
            try
            {
                short mapDimension = Convert.ToInt16(this._mapDimension);

                if (cell.Revealed)
                {
                    for (short r = -1; r < 2; r++)
                    {
                        for (short c = -1; c < 2; c++)
                        {

                            if (cell.X + r > mapDimension - 1 || cell.X + r < 0 || cell.Y + c > mapDimension - 1 || cell.Y + c < 0)
                            {
                                continue;
                            }
                            else if (this.fild[cell.X + r][cell.Y + c].Bomb is true) 
                            {
                                if (this.fild[cell.X + r][cell.Y + c].Flag is false)
                                    this.fild[cell.X + r][cell.Y + c].Text = this.fild[cell.X + r][cell.Y + c].Bomb.ToString();
                            }
                            else
                            {
                                if (this.fild[cell.X + r][cell.Y + c].Flag is false)
                                {
                                    this.fild[cell.X + r][cell.Y + c].Revealed = true;
                                    this.fild[cell.X + r][cell.Y + c].Text = this.fild[cell.X + r][cell.Y + c].BombsAround.ToString();
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

        public void PutAndRemoveFlag(Cell cell)
        {
            try
            {            
                if (cell.Revealed is false)
                {
                    if(cell.Flag is false)
                    {
                        cell.Flag = true;
                        cell.Text = FLAG_TEXT;
                    }
                    else
                    { 
                        cell.Flag = false;
                        cell.Text = string.Empty;
                    }
                }           
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        #endregion

        #region Eventos
        private void Cell_Click(object? sender, MouseEventArgs e)
        {
            try
            {
                if (sender is Cell cell)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        this.RevealCell(cell);
                    }

                    if (e.Button == MouseButtons.Right)
                    {
                        this.PutAndRemoveFlag(cell);
                    }

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }    
        }
        #endregion

    }
}

