using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealOrNoDeal
{
    public class Game
    {
        private List<int> boxes;
        private int currentTurn;
        static Random random;

        public Game()
        {
            boxes = new List<int>() { 1, 5, 10, 25, 50, 100, 250, 500,
                1000, 2500, 5000, 10000, 50000, 100000, 500000, 1000000};
            currentTurn = 0;
            random = new Random();
        }

        public int getTurn()
        {
            return currentTurn;
        }

        public int OpenBox()
        {
            int r = random.Next(boxes.Count);
            int chosenBox = boxes[r];
            boxes.RemoveAt(r);
            currentTurn++;
            return chosenBox;
        }

        public List<int> getBoxes()
        {
            return boxes;
        }

        public int calculateOffer()
        {
            int average = 0;
            foreach(int box in boxes)
                average += box;
            average = (average / boxes.Count);
            return (average * currentTurn) / 20;
        }

    }
}
