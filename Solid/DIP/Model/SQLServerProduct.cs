using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Model {
    class SQLServerProduct : DbProduct {

        //classe de baixo nivel
        public string GetProductById(string id) { 

        
        return $"SQLServer: Exibindo dados do produto {id}";

        }
    }
}
