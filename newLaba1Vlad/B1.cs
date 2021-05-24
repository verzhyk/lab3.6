using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLaba1Vlad
{
    public class B1 : D1
    {
        private string b1;

        public B1(string b1)
        {
            this.b1 = b1;
        }

        public override void Show()
        {
            Console.WriteLine($"Class type: {nameof(B1)}. b1 = {b1}.");
        }
    }
}
