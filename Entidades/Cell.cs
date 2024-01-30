using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampoMinado_C_Sharp.Entidades
{
    public class Cell : Button
    {
        public short X {  get; set; } = 0;  
        public short Y { get; set; } = 0;
        public bool Bomb { get; set; } = false;
        public bool Flag { get; set; } = false;
        public bool Revealed { get; set; } = false;
        public int BombsAround { get; set; } = 0;

    }
}
