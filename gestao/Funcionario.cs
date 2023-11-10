using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string NomeUsuario { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime Data_Nasc { get; set; }
        public string Celular { get; set; }
        public string Senha { get; set; }
        public string Endereco { get; set; }
        public List<Cargo> Cargo { get; set; }
    }
}
