using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPadarosa
{
    public class Produto
    {
       public int Id { get; set; }
        public string Nome { get; set;}
        public double Preco { get; set;}
        public int IdCategoria { get; set; }    
        public int IdRespcadastro { get; set; }
    }
}
