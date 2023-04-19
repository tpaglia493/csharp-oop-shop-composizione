using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Composizione_Shop
{
    
    public class Shop
    {
        //ATRIBUTES
        private string name;
        private string city;
        private string street;
        private int streetNumber;
        private List<Product> products = new();

        //STATES

        //CONSTRUCTOR

        //GETTERS
        public string GetName()
        {
            return name;
        }
        public string GetCity()
        {
            return city;
        }
        public string GetStreet()
        {
            return street;
        }
        public int GetStreetNumber()
        {
            return streetNumber;
        }
        //SETTERS

        //METHODS

        public string GetAddress()
        {
            string address = $"Name of the shop: {this.name} /n{this.streetNumber}, {this.street},  {this.city}";
            return address;
        }
    }
}
