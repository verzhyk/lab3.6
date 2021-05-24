using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLaba1Vlad
{
    class Program
    {
        static void Main(string[] args)
        {
            D1 d1 = new D1("d1 class");
            D2 d2 = new D2("d2 class");
            D3 d3 = new D3("d3 class");
            B1 b1 = new B1("b1 class");
            B2 b2 = new B2("b2 class");

            d1.Show();
            d2.Show();
            d3.Show();
            b1.Show();
            b2.Show();


        }
    }
}
