using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public float Valor_total { get; set; }
        public DateTime Data_pedido { get; set; }
        public List<Cliente> Clientes { get; set; }
        public List<Funcionario> Funcionarios { get; set; }
        public Pedido() 
        { 
           Clientes = new List<Cliente>();
           Funcionarios = new List<Funcionario>();
        } 
    }
}


