using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericConverter.Function
{
    class Modal
    {
        protected static string Satuan(int angka)
        {
            string x = "";

            switch (angka)
            {
                case 1:
                    x = "One";
                    break;
                case 2:
                    x = "Two";
                    break;
                case 3:
                    x = "Three";
                    break;
                case 4: 
                    x = "Four";
                    break;
                case 5:
                    x = "Five";
                    break;
                case 6:
                    x = "Six";
                    break;
                case 7:
                    x = "Seven";
                    break;
                case 8:
                    x = "Eight";
                    break;
                case 9:
                    x = "Nine";
                    break;
            
            }

            return x;
        }
        protected static string Belasan(int angka)
        {
            string x = "";

            switch (angka)
            {
                case 10:
                    x = "Ten ";
                    break;
                case 11:
                    x = "Eleven ";
                    break;
                case 12:
                    x = "Twelve ";
                    break;
                case 13:
                    x = "Thirteen ";
                    break;
                case 14:
                    x = "FourTeen ";
                    break;
                case 15:
                    x = "FiveTeen ";
                    break;
                case 16:
                    x = "SixTeen ";
                    break;
                case 17:
                    x = "SevenTeen ";
                    break;
                case 18:
                    x = "EighTeen ";
                    break;
                case 19:
                    x = "NineTeen ";
                    break;            
            }

            return x;
        }
        protected static string Puluhan(int angka)
        {
            string x = "";

            switch (angka)
            {
                case 1:
                    x = "Ten";
                    break;
                case 2:
                    x = "Twenty";
                    break;
                case 3:
                    x = "Thirty";
                    break;
                case 4:
                    x = "Fourty";
                    break;
                case 5:
                    x = "Fivety";
                    break;
                case 6:
                    x = "Sixty";
                    break;
                case 7:
                    x = "Seventy";
                    break;
                case 8:
                    x = "Eighty";
                    break;
                case 9:
                    x = "Ninety";
                    break;
            }

            return x;
        }
    }
}
