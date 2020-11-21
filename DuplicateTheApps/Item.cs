using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateTheApps.Model
{
    class Item
    {
        public string nama { get; set; }
        public int harga { get; set; }

        public string getName() 
        { 
            return this.nama; 
        }


    }
}
