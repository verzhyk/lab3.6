using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLaba1Vlad
{
    public class D2 : D1
    {
        private string d2;

        public D2(string d2)
        {
            this.d2 = d2;
        }

        public override void Show()
        {
            Console.WriteLine($"Class type: {nameof(D2)}. d2 = {d2}.");
        }
    }
}
