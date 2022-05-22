using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillYourBackpack
{
    class Backpack
    {
        private List<Item> bestItems = null;

        private double MaxWeight;

        private double bestPrice;

        public Backpack(double maxWeight)
        {
            MaxWeight = maxWeight;
        }

        public void MakeAllSets(List<Item> items)
        {
            if (items.Count > 0)
                CheckSet(items);

            for (int i = 0; i < items.Count; i++)
            {
                List<Item> newSet = new List<Item>(items);

                newSet.RemoveAt(i);

                MakeAllSets(newSet);
            }
        }

        private void CheckSet(List<Item> items)
        {
            if (bestItems == null)
            {
                if (CalcWeigth(items) <= MaxWeight)
                {
                    bestItems = items;
                    bestPrice = CalcPrice(items);
                }
            }
            else
            {
                if (CalcWeigth(items) <= MaxWeight && CalcPrice(items) > bestPrice)
                {
                    bestItems = items;
                    bestPrice = CalcPrice(items);
                }
            }
        }

        private double CalcWeigth(List<Item> items)
        {
            double sumWeight = 0;

            foreach (Item i in items)
            {
                sumWeight += i.Weight;
            }

            return sumWeight;
        }

        private double CalcPrice(List<Item> items)
        {
            double sumPrice = 0;

            foreach (Item i in items)
            {
                sumPrice += i.Price;
            }

            return sumPrice;
        }

        public List<Item> GetBestSet()
        {
            return bestItems;
        }
    }
}