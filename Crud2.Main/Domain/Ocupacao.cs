using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud2.Main.Domain
{
    public class Ocupacao
    {
        public virtual int Ocupacaoid { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Codigocbo { get; set; }
    }
}
