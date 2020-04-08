using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Sene Apulu
 * 3.24.2020
 * Retail Item Class
 * CSC 153 
 */


namespace myClassLib
{
    public class RetailItem
    {
        //fields
        private string _desc;  //Item's description
        private int _onHand;   //Item's quantity
        private double _price; //Item's price.


        //constructors
        public RetailItem()
        {
            Description = "";
            UnitsOnHand = 0;
            Price = 0.00;
            
        }

        public RetailItem(string desc, int quant, double price) 
        {
            Description = desc;
            UnitsOnHand = quant;
            Price = price;
        }

        //properties
        public string Description
        {
            get
            {
                return _desc;
            }
            set
            {
                _desc = value;
            }
        }

        public int UnitsOnHand
        {
            get 
            {
                return _onHand;
            }
            set 
            {
                _onHand = value;
            }           
        }

        public double Price 
        {
            get 
            {
                return _price;
            }
            set 
            {
                _price = value;
            }
        }

        //methods
        public double ShowTotal() 
        {
            double total = Price * UnitsOnHand;
            return total;
        }

        public static void DisplayItemList(List<RetailItem> retailList) 
        {
            foreach (var item in retailList)
            {
                Console.WriteLine(myClassLib.StdMsgs.ShowItemInfo(item));
            }
        }
    }
}