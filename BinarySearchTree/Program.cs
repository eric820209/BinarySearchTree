using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyBST<Product> MyProductTree = new MyBST<Product>();
                var TestList = RamomHelper.InitTestArray(800000, 1000000);
                TimeStoper timeStoper = new TimeStoper();
                timeStoper.start();
                foreach (var testvalue in TestList)
                {
                    Product p = new Product { ProductId = testvalue, ProductName = "食物蔬果調理機", Price = testvalue };
                    MyProductTree.Add(p.ProductId, p);
                }
                timeStoper.stop();
                Console.WriteLine($"BTS新增5000筆所花時間{timeStoper.getSpan()}");
                //Console.ReadLine();

                List<Product> products = new List<Product>();
                TimeStoper timeStoper2 = new TimeStoper();
                timeStoper2.start();
                foreach (var testvalue in TestList)
                {
                    Product p = new Product { ProductId = testvalue, ProductName = "食物蔬果調理機", Price = testvalue };
                    products.Add(p);
                }
                timeStoper2.stop();
                Console.WriteLine($"List新增5000筆所花時間{timeStoper2.getSpan()}");


                //============================查詢======================
                var index = TestList.ToArray()[280000];
                timeStoper.start();
                Product BTSp = MyProductTree.Search(index);
                timeStoper.stop();
                Console.WriteLine($"{BTSp.ProductId},BTS查詢所花時間{timeStoper.getSpan()}");

                timeStoper2.start();
                Product Listp = products.Where(x => x.ProductId == index).Single();
                timeStoper2.stop();
                Console.WriteLine($"{Listp.ProductId},List查詢所花時間{timeStoper2.getSpan()}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }

        }
    }
}
