using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Computador : BaseModel
    {
        public string Modelo { get; set; }
        public string Empresa { get; set; }
        public decimal Preco { get; set; }
    }
}
