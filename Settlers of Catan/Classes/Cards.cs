using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOCForm.Classes
{
    class Cards
    {
        public int cardSelect;
        public Random r;
        private void randomCard()
        {
            r = new Random();
           
            //    //set randoms
            cardSelect = r.Next(0, 5);
            
        }
    }
}
