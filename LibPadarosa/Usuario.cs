﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPadarosa
{
    public class Usuario
    {
        public int Id { get; set; } 
        public string NomeCompleto { get; set; }
        public string Email { get; set; }  
        public string Senha { get; set; }
        public double Preco { get; set; }
    }
}
