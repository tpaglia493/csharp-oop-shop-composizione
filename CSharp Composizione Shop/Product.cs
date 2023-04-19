using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Composizione_Shop
{
    public class Product
    {
        //ATTRIBUTES & PROPERTIES
        private int code;
        private string name;
        public string Name { get { return this.name; } set { this.name = value; } }

        private string description;
        public string Description { get { return this.description; } set { this.description = value; } }

        private float price;
        public float Price { get { return this.price; } set { this.price = value; } }

        private float iva;

        public float Iva { get { return this.iva; } set { this.iva = value; } }
        //STATES


        //CONSTRUCTOR

        public Product(string name)
        {
            this.name = name;
            CodeGenerator();
        }

        public Product(string name, string description, float price, float iva)
        {
            this.name= name;
            CodeGenerator();
            this.description = description;
            this.price = price;
            this.iva = iva;
        }



        //GETTERS
        public int getCode()
        {
            return this.code;
        }

    

        //METHODS

        private void CodeGenerator() 
        {
            Random code = new Random();
            this.code = code.Next(1, 99999999);
        }
        public string getFormattedCodePadLeft8()
        {
            string codeString = this.code.ToString();
            string codeStringPadded = codeString.PadLeft(8, '0');
            return codeStringPadded;

        }

        public string GetInfo()
        {
            string info = this.code +" " + Name;
                 return info;
        }

        public float GetIvaPrice()
        {
            float ivaPrice = price + (price * iva) / 100;
            return ivaPrice;
        }
       
    }
}