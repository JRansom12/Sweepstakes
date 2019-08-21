using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm //inject the Sweepstakes objects
        //implement dependency injection
    {
        Sweepstakes primeRib = new Sweepstakes();
        Sweepstakes fordRanger = new Sweepstakes();
        Sweepstakes tokyoMarathon = new Sweepstakes();
        Sweepstakes treeFiddy = new Sweepstakes();

    }
}
