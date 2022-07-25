using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPadarosa
{
    public class Ordem
    {
        public int Id { get; set; } 
        public int IdFicha { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade{ get; set; }
        public int IdResp { get; set; }
        public bool Situacao { get; set; }   
    }
}
