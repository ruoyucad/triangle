using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
   

    public class TriangleTester
    {

        public void DisplayMenu()
        {
            Console.WriteLine("Welcome to Triangle Analyzer !");
            Console.WriteLine("1.Enter triangle dimensions");
            Console.WriteLine("2.Exit");
            string selection = Console.ReadLine();
            int selectionInt;
            if (int.TryParse(selection, out selectionInt))
            {
                if (selectionInt == 1) Analyze();
                else if (selectionInt == 2) { Environment.Exit(2); }
            }
            else
            {
                Console.WriteLine("select provided options please!\n");
                DisplayMenu();
            }          
        }

        public void Analyze()
        {
            int dim1, dim2, dim3;

            Console.WriteLine("Please enter the first dimention: ");
            string ds1 = Console.ReadLine();
            bool isInt1 = int.TryParse(ds1, out dim1);
            Console.WriteLine("Please enter the second dimention: ");
            string ds2 = Console.ReadLine();
            bool isInt2 = int.TryParse(ds2, out dim2);
            Console.WriteLine("Please enter the third dimention: ");
            string ds3 = Console.ReadLine();
            bool isInt3 = int.TryParse(ds3, out dim3);

            if (isInt1 || isInt2 || isInt3)
            {
                GetTriangleType(dim1, dim2, dim3);
            }
            else
            {
                Console.WriteLine("Check Your Input Again Idiot !!");
            }
        }

        public static bool GetTriangleType(int x, int y, int z)
        {
            //Placing items in an array for processing 
            int[] values = new int[3] { x, y, z };
            string[] types = new string[4] { " Scalene", " Isosceles", " Equilateral", "Error Input" };
            if (x <= 0 || y <= 0 || z <= 0)
            {
                Console.WriteLine("Does not form a triangle");
                Console.WriteLine(types[3]);
                return false;
            }
            else if (values.Distinct().Count() == 1) //one unique side
            {
                Console.WriteLine("Does form a triangle");
                Console.WriteLine(types[0]);
                return true;
            }
            else if (values.Distinct().Count() == 2) //two unique side
            {
                Console.WriteLine("Does form a triangle");
                Console.WriteLine(types[1]);
                return true;
            }
            else if (values.Distinct().Count() == 3) // three unique side
            {
                Console.WriteLine("Does form a triangle");
                Console.WriteLine(types[2]);
                return true;
            }
            else
            {
                Console.WriteLine("Does not form a triangle");
                Console.WriteLine(types[3]);
                return false;
            }
        }
    }
}
