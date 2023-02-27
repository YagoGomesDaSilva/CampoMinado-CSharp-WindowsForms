using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CampoMinado_C_Sharp.Entidades
{
    public class Constants
    {
        public enum Dificulty
        {
            easy, medium, hard
        }

        public enum AmountBombs
        {
            easy = 10, medium = 25, hard = 50
        }

        public enum MapDimension
        {
            easy = 10, medium = 20, hard = 30
        }


    }
}
