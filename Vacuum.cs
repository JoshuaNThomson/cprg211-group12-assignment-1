using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Dishwasher
    {
        int ItemNumber { get; set; }
        string Brand { get; set; }
        int Quantaty { get; set; }
        int Wattage { get; set; }
        string Color { get; set; }
        double Price { get; set; }
        string SoundRating { get; set; }

        public Dishwasher(int itemNumber, string brand, int quantity, int wattage, string color, double price, string soundRating) 
        {
            ItemNumber = itemNumber;
            Brand = brand;
            Quantaty = quantity;
            Wattage = wattage;
            Color = color;
            Price = price;
            SoundRating = soundRating;
        }

        public override string ToString()
        {
            return $"Dishwasher Details:\nItem Number: {ItemNumber}\nBrand: {Brand}\nQuantity: {Quantity}\nWattage: {Wattage}W\nColor: {Color}\nPrice: ${Price}\n Sound Rating: {SoundRating}";
        }
    }
}
}
