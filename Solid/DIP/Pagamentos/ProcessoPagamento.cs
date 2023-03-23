using DIP.Factory;
using DIP.Model;
using System;

namespace DIP.Pagamentos {
    class ProcessoPagamento {

        //regras de negocio nivel alto
        public void Pagar(string id) {
            DbProduct product = DbProductFactory.Create();
            string productData = product.GetProductById(id);
            Console.WriteLine(productData);
        }
    }
}
