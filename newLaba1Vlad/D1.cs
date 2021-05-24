using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLaba1Vlad
{
    public class D1
    {
        private string d1;

        public D1()
        {
            
        }
        public D1(string d1)
        {
            this.d1 = d1;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Class type: {nameof(D1)}. d1 = {d1}.");
        }
    }
}
