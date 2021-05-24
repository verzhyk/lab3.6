using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLaba1Vlad
{
    public class D3 : D1
    {
        private string d3;

        public D3(string d3)
        {
            this.d3 = d3;
        }

        public override void Show()
        {
            Console.WriteLine($"Class type: {nameof(D3)}. d3 = {d3}.");
        }
    }
}
