using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{//CRUD Operasyonlarında CREATE, READ, UPDATE, DELETE komutları yer alır
    class ProductManager //CRUD Operasyonları içerir
    {
     public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }  

     public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");

        }

        
    }
}
