using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    interface IUserInterface
    {
        public string GetUserInput(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }
    }
}
