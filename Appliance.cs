using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    abstract class Appliance
    {
        private long itemNumber;
        private string brand;
        private int quantity;
        private double wattage;
        private string color;
        private double price;

        public bool isAvailable()
        {
            if (quantity == 0)
                return false;
            else
                return true;
        }

        public void checkout()
        {
            return;
        }

        public string formatForFile()
        {
            return $"{this.itemNumber};{this.brand};{this.quantity};{this.wattage};{this.color};{this.price}";
        }

        public override string ToString()
        {
            return $"Item#: {this.itemNumber}\n" +
                $"Brand: {this.brand}\n" +
                $"Quantity: {this.quantity}\n" +
                $"Wattage: {this.wattage} Watts\n" +
                $"Color: {this.color}\n" +
                $"Price: {this.price}";
        }

    }
}
