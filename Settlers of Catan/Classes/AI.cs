using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOCForm.Classes
{
    class AI
    {
        private int difficulty;//this number will range between 1-10
      

        Dice dice = new Dice();
        Resource card = new Resource();
        public string item;
        public int count;

        private void takeTurn()
        {
            dice.roll();
            card.drawCards(15);
            tradeAssessment(difficulty, count, item);

        }

        private void tradeAssessment(int difficulty, int itemCount, string item)
        {
            //if trade proproasal is greater than 70% of total inventory of an item trades will be rejected by "hard" AI

        }
    }
}
