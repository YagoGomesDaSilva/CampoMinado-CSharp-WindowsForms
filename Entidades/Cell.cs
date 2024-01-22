using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampoMinado_C_Sharp.Entidades
{
    public class Cell : Button
    {
        public bool Bomb { get; set; }
        public bool Flag { get; set; }
        public int Id { get; set; } = 0;

    }
}
