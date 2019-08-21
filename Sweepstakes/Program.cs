using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            MarketingFirm market = new MarketingFirm(factory.ChooseManager());
            market.RunSweepstakes();
        }
    }
}
