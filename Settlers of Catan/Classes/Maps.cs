using System.Security.Cryptography.X509Certificates;

namespace SOCForm.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Maps
    {
        public Hexagon[,] tiles = new Hexagon[12,12];
        Random rdm = new Random();
    }
}
