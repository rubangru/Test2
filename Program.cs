using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var1_OKR
{
    interface Drawable
    {
        void draw();
    }
    enum block
    {
        you = '☺',
        empty = '-',
        obstacles = '#'
    }
    class cell
    {
        private char cell_1;
        protected char getCell
        {
            get
            {
                return cell_1;
            }
            set
            {
                cell_1 = value;
            }
        }
    }
    class pole : cell, Drawable
    {
        private char[] mass = new char[120];
        void Drawable.draw()
        {
            Random rand = new Random();
            bool check = true;
            for (int i = 1; i <= mass.Length; i++)
            {
                switch (rand.Next(0, 8))
                {
                    case 0:
                        getCell = Convert.ToChar(block.empty);
                        break;
                    case 1:
                        getCell = Convert.ToChar(block.empty);
                        break;
                    case 2:
                        getCell = Convert.ToChar(block.obstacles);
                        break;
                    default:
                        if (check == true)
                        {
                            getCell = Convert.ToChar(block.you);
                            check = false;
                        }
                        else
                        {
                            getCell = Convert.ToChar(block.empty);
                        }
                        break;
                }

                Console.Write(" " + getCell);
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }

    class Program
    {


        static void Main(string[] args)
        {
            Drawable obj = new pole();
            obj.draw();



            Console.ReadKey();
        }
    }
}
