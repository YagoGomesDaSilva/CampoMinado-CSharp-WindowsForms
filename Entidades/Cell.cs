using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampoMinado_C_Sharp.Entidades
{
    public class Cell
    {
        private bool _bomb = false;
        private bool _flag = false;
        private int _id = 0;

        public bool Bomb
        {
            get => _bomb;
            set => _bomb = value;
        }

        public bool Flag
        {
            get => _flag;
            set => _flag = value;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }
    }
}
