using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product { ProductId = 1, ProductName = "食物蔬果調理機", Price = 3960m };
            Product product2 = new Product { ProductId = 2, ProductName = "MA-1飛行外套", Price = 1990m };
            Product product3 = new Product { ProductId = 3, ProductName = "人氣露營帳篷", Price = 2999m };
            Product product4 = new Product { ProductId = 4, ProductName = "荷蘭鑄鐵鍋", Price = 738m };
            Product product5 = new Product { ProductId = 5, ProductName = "美國鷹牌防水手套", Price = 800m };
            Product product6 = new Product { ProductId = 6, ProductName = "國際牌鋰電池10入", Price = 170m };


            MyBST<Product> MyProductTree = new MyBST<Product>();
            MyProductTree.Add(product1.ProductId,product1);
            MyProductTree.Add(product5.ProductId, product5);
            MyProductTree.Add(product4.ProductId, product4);
            MyProductTree.Add(product3.ProductId, product3);
            MyProductTree.Add(product6.ProductId, product6);
            MyProductTree.Add(product2.ProductId, product2);

            var item = MyProductTree.Search(3);
            Console.WriteLine($"{item.ProductId}:{item.ProductName}");
        }
    }
}
