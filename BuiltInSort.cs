using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BuiltInSort
{
    class BuiltInSort
    {
        
        void PrintArray(CatalogueItem[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.WriteLine(
                "Id: " + arr[i].Id + ", "
                + "Name: " + arr[i].ItemName + ", "
                + "Category: " + arr[i].Category);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            BuiltInSort ob = new BuiltInSort();
            CatalogueItem[] arr = {
new CatalogueItem( 3, "Life of Pi","Books"),
new CatalogueItem( 7, "Deelongie 4 way toaster","Home and Kitchen"),
new CatalogueItem( 2, "Glorbarl knife set","Home and Kitchen"),
new CatalogueItem( 4, "Diesorn vacuum cleaner","Appliances"),
new CatalogueItem( 5, "Jennie Olivier sauce pan","Home and Kitchen"),
new CatalogueItem( 6, "This book will save your life","Books"),
new CatalogueItem( 9, "Kemwould hand mixer","Appliances"),
new CatalogueItem( 1, "Java for Dummies","Books"),
};
            Console.WriteLine("The Unsorted array is\r\n");
            ob.PrintArray(arr);

            string [] categoryArray = {"","","","","","","",""};
            { }
            for (int i=0; i < arr.Length;  i++)
            {
                var id = arr[i].Id;
                var name = arr[i].ItemName;
                var category = arr[i].Category;
                var item = category + ", Id: " + id + ", Name: " + name;
                categoryArray[i] = item;
            }
            Array.Sort(categoryArray);
            Console.WriteLine();
            Console.WriteLine("The array sorted by category using C# built in sort is:\r\n");            
            for (int i = 0; i < categoryArray.Length; i++)
            {
                Console.WriteLine(categoryArray[i]);
            }
                        
            Console.Read();
        }
    }
}
