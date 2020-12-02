using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ADI.Models
{
    [Serializable]
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
