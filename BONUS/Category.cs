using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Composizione_Shop
{
    public class Category
    {
        //ATTRIBUTES
        private string categoryName;

        private string categoryDescription;
   
        //CONSTRUCTOR
        public Category(string categoryName, string categoryDescription)
            {  
            this.categoryName = categoryName;
            this.categoryDescription = categoryDescription;
            } 

        //METHODS 
        public string GetCategoryInfo()
        {
            string info = this.categoryName + " - " + this.categoryDescription+ "\n"; 
            return info;
        }
    }
}
