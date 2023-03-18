using CoffeeShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
    
{

    class Coffee
    {
        public int TotalCoffee;
        public double TotalPrice;
    }



    class Capachino : Coffee
    {

        public double CapachinoPrice;
        public int cup1;
        public void Cup1(int x)
        {
            CapachinoPrice = (30 * x);
            Console.WriteLine("Capachino- " + x + "/cup ------"+x+"*30= " + CapachinoPrice + "/-tk");
            cup1 = x+cup1;
            CapachinoPrice = 30 * cup1;

        }
         
    }

    class Expresso : Coffee
    {

        public double ExpressoPrice;
        public int cup2;
        public void Cup2(int x)
        {
            ExpressoPrice = (40 * x);
            Console.WriteLine("Expresso- " + x + "/cup ------" + x + "*40= " + ExpressoPrice + "/-tk");
            cup2 = x + cup2;
            ExpressoPrice = 40 * cup2;

        }

    }


    class ColdCoffee : Coffee
    {

        public double ColdCoffeePrice;
        public int cup3;
        public void Cup3(int x)
        {
            ColdCoffeePrice = (50 * x);
            Console.WriteLine("Cold-Coffee- " + x + "/cup ------" + x + "*50= " + ColdCoffeePrice + "/-tk");
            cup3 = x + cup3;
            ColdCoffeePrice = 50 * cup3;

        }

    }

    public class Program
    {
        public static void Main(string[] args)
        {
            string confirm;
            Capachino cap = new Capachino();
            Coffee coffee = new Coffee();
            Expresso expresso= new Expresso();
            ColdCoffee coldCoffee = new ColdCoffee();

            do
            {
                

                //Console.WriteLine("Which coffee do you want?");
                string[] Cname = { "Capachino", "Expresso", "Cold Coffee" };
                for (int i = 0; i < Cname.Length; i++)
                {
                    Console.WriteLine(Cname[i] + "    =Press " + (i + 1));
                }

                int press = Convert.ToInt32(Console.ReadLine());
                switch (press)
                {
                    case 1:
                        Console.WriteLine("No of cups=");
                        int cup1 = Convert.ToInt32(Console.ReadLine());

                        cap.Cup1(cup1);
                        break;

                    case 2:
                        Console.WriteLine("No of cups=");
                        int cup2= Convert.ToInt32(Console.ReadLine());

                        expresso.Cup2(cup2);
                        break;
                    case 3:
                        Console.WriteLine("No of cups=");
                        int cup3 = Convert.ToInt32(Console.ReadLine());

                        coldCoffee.Cup3(cup3);
                        break;

                    default:
                        Console.WriteLine("invalid option");
                        break;


                }

                Console.WriteLine("Order more? y/n");
                confirm = Console.ReadLine().ToLower();

            } while (confirm == "y");

            coffee.TotalCoffee = cap.cup1+expresso.cup2+ coldCoffee.cup3;
            coffee.TotalPrice = cap.CapachinoPrice+expresso.ExpressoPrice+coldCoffee.ColdCoffeePrice;

            Console.WriteLine("Total Coffee= "+ cap.cup1 + " Capachino, "+ expresso.cup2+" Expresso, "+ coldCoffee.cup3+" Cold-Coffee");
            Console.WriteLine("Total price= " + coffee.TotalPrice+"/-tk");

            Console.ReadLine();



        }
    }
}
