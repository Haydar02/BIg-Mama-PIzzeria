using System;
using System.Collections.Generic;
using System.Text;

namespace BIg_Mama_PIzzeria
{
    class Store
    {
        public void Start () {
        
          

            Pizza p1 = new Pizza("Margritte", "mozzorolla",59);
            Pizza p2 = new Pizza("Calsona", " ham" , 65);
            Pizza p3 = new Pizza("Solo", "shrimp", 70);

            

            Customers c1 = new Customers(" (Peter Hansen ):", "( Maglegårdsvej )", 21555212, "( peter@hotmail.com )");
            Customers c2 = new Customers("(  Jens Larsen )", "( Amagerlandvej )", 23114532, "( jens@gmail.com ) ");
            Customers c3 = new Customers(" ( Ali Mustafa )", " ( peterbangvej )", 56147781, "( ali@hotmail.dk )");
          
            Order o1 = new Order(121, p1, c1);
            Order o2 = new Order(122, p2, c2);
            Order o3 = new Order(15, p3, c3);
          

            Console.WriteLine(o1.ToString());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(o2.ToString());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(o3.ToString());
            Console.WriteLine();
            Console.WriteLine();



        }
    }    
}
