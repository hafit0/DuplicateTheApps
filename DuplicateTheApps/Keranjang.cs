using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateTheApps.Model
{
    class Keranjang
    {
        private List<Item> items;

        public Keranjang()
        {
            this.items = new List<Item>();
            items.Add(new Item() { nama = "Es teh", harga = 3000 });
            items.Add(new Item() { nama = "Mie goreng Tante", harga = 7000 });
            items.Add(new Item() { nama = "Mie goreng telur", harga = 8000 });
            items.Add(new Item() { nama = "Burjo", harga = 6000 });
            items.Add(new Item() { nama = "Mie DOKDOK", harga = 10000 });
            items.Add(new Item() { nama = "Nasi Goreng", harga = 12000 });
        }

        public List<Item> GetItems()
        {
            return items;
        }
        public int CountItems()
        {
            return this.items.Count();
        }
        public List<Item> findAll()
        {
            return this.items;
        }
        public void remove(int position)
        {
            this.items.RemoveAt(position);
        }
    }
}
