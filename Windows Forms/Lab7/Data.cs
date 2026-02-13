using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Data
    {
        public int currentConsumable = 0;
        public int currentPart = 0;
        public int[] PartsToShow = {0, 1, 2}; 
        public List<Consumables> Consumables = new List<Consumables>();
        public List<Parts> Parts = new List<Parts>();
        public Data()
        {
            Consumables.Add(new Consumables("Медіатор", 2023, "Banger", "Ukraine", "Steel", "-", 10.4, 20.5));
            Consumables.Add(new Consumables("Струна", 2022, "Kawasaki", "Japan", "Aluminium", "-", 10.3, 20.8));
            Consumables.Add(new Consumables("Паличка", 2024, "Slams", "USA", "Wooden", "-", 10.1, 21.9));
            Parts.Add(new Parts("Колковий механізм", 2024, "Rocks", "Italy", "Steel", 12, 2, 4));
            Parts.Add(new Parts("Дека", 2025, "Mechanisms", "Germany", "Wooden", 10, 150, 70));
            Parts.Add(new Parts("Порожек", 2023, "Soundzzz", "France", "Steel", 12, 2, 5));
            Parts.Add(new Parts("Підставка", 2022, "Soundgarden", "USA", "Plastic", 12, 3, 3));
        }
        public void DecrementConsumable()
        {
            if (currentConsumable == 0) currentConsumable = Consumables.Count - 1;
            else currentConsumable--;
        }
        public void IncrementConsumable()
        {
            if (currentConsumable == Consumables.Count - 1) currentConsumable = 0;
            else currentConsumable++;            
        }
        public bool CheckParts()
        {
            if (Parts.Count() < 3)
            {               
                for(int i = 0; i < 3; i++)
                {
                    if(i < Parts.Count()) PartsToShow[i] = i;
                    else PartsToShow[i] = -1;
                }
                return true;
            }
            else return false;
            
        }
        public void SetParts()
        {
            for (int i = 0; i < 3; i++)
            {
                PartsToShow[i] = currentPart;
                if (currentPart == Parts.Count() - 1) currentPart = 0;
                else ++currentPart;
            }
            currentPart = PartsToShow[0];
        }
        public void IncrementPart()
        {
            if(!CheckParts())
            {
                if (currentPart == Parts.Count() - 1) currentPart = 0;
                else ++currentPart;
                SetParts();
                currentPart = PartsToShow[0];
            }
        }       
        public void DecrementPart()
        {
            if (!CheckParts())
            {
                if (currentPart == 0) currentPart = Parts.Count() - 1;
                else --currentPart;
                SetParts();
                currentPart = PartsToShow[0];
            }
        }
    }
}
