using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_IEnumerable_Product
{
    class Shop : IEnumerable
    {
        Item[] items = new Item[0];
        public void AddItem(Item item)
        {
            Array.Resize(ref items, items.Length + 1);
            items[items.Length - 1] = item;
        }

        public IEnumerator GetEnumerator() // неіменований ітератор
        {
           foreach (Item item in items)
            {
                yield return item; // повертається у зовнішній світ черговий продукт, та повертаємося назад сюди (цикл продовжується)
            }
        }
        public IEnumerable<Item> GetReverse()
        {
            for (int i = items.Length - 1; i >= 0 ; i--)
            {
                yield return items[i];
            }
        }
        public IEnumerable<Item> GetItemsLimit(int priceLimit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Price <= priceLimit)
                    yield return items[i];
            }
        }
        public override string ToString()
        {
            return $"{String.Join<Item>("\n",items)}";
        }
    }
}
