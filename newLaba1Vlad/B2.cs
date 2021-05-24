using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLaba1Vlad
{
    public class B2 : D1
    {
        private string b2;

        public B2(string b2)
        {
            this.b2 = b2;
        }

        public override void Show()
        {
            Console.WriteLine($"Class type: {nameof(B2)}. b2 = {b2}.");
        }
    }
}
