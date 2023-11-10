using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Models

{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime Data_Nasc {  get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }


    }
}
