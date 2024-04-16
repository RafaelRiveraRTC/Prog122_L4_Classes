using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog122_L4
{
    //In your new class
    // change "internal" to public
    
    public class Product
    {
        //fields are variables that are associated with a class object

        public string _title;
        public string _director;
        public string _raiting;
        public decimal _price;

        //constructors
        //New product() <------------

        // a constructor is built like a method 
        // but
        // no reurn type

        //same exact name as a class

        public Product(string title, string director, string rating, decimal price )
        {
            _title = title;
            _director = director;
            _raiting = rating;
            _price = price;
        } 


      

        //Properties


    }//class 


}//namespace


