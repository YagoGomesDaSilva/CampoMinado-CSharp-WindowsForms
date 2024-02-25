using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CampoMinado_C_Sharp.Entidades
{
    public class Record
    {
        public int RecordId { get; set; }
        public Constants.Dificulty? RecordDificulty { get; set; }  
        public int RecordScore { get; set; }
    }
}
