using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Vacuum
    {
        public int ItemNumber { get; set;}
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public int Wattage { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public string Grade { get; set; }
        public int BatteryVoltage { get; set; }

        public Vacuum(int itemNumber, string brand, int quantity, int wattage, string color, decimal price, string grade, int batteryVoltage) 
        {
            ItemNumber = itemNumber;
            Brand = brand;
            Quantity = quantity;
            Wattage = wattage;
            Color = color;
            Price = price;
            Grade = grade;
            BatteryVoltage = batteryVoltage;
        }

        public override string ToString()
        {
            return $"Vacuum Details:\nItem Number: {ItemNumber}\nBrand: {Brand}\nQuantity: {Quantity}\nWattage: {Wattage}W\nColor: {Color}\nPrice: ${Price}\nGrade: {Grade}\nBattery Voltage: {BatteryVoltage}V";
        }
    }
}
