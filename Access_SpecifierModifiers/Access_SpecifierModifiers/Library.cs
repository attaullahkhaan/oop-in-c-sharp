using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_SpecifierModifiers
{
    internal class Library : Student
    {
        public void Show(string n)
        {
            name = n;
            Console.WriteLine(name);
        }
    }
}
