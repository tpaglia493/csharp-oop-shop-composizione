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
        public List<Product> products;

        //STATES

        //CONSTRUCTOR
        public Shop(string name, string city, string street, int streetNumber ) 
        {
            this.name = name;   
            this.city = city;   
            this.street = street;   
            this.streetNumber = streetNumber;
            this.products = new();
        }

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
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetCity(string city)
        {
            this.city = city;
        }
        public void SetStreet(string street)
        {
            this.street = street;        
        }
        public void SetStreetNumber(int streetNumber)
        {
            this.streetNumber = streetNumber;
        }

        //METHODS

        public string GetAddress()
        {
            string address = $"Name of the shop: {this.name} \n{this.streetNumber}, {this.street},  {this.city}";
            return address;
        }

        public void AddSingleProductToList(Product productName)
        {products.Add(productName);
            
        }


    }
}
