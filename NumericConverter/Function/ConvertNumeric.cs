using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericConverter.Function
{ 
    class ConvertNumeric : Modal
    {
        public static string WordsSpliter(string number)
        {
            string words = "";

            if (!number.Contains("."))
            {
                number = number + ".00";
            }

            var resultDollar = number.Substring(0, number.IndexOf('.'));
            var resultCents = number.Substring(number.LastIndexOf('.') + 1);

            if (resultCents.Length < 2)
                resultCents = "0" + resultCents;

            words = NumericConvertToWords(resultDollar) + " Dollars and " + NumericConvertToWords(resultCents.Substring(0, 2)) + " Cents";

            return words;
        }
        private static string NumericConvertToWords(string number)
        {
            if (number == "0" || number =="00") // check zero value
            {
                return "Zero";
            }

            if (number.Length > 6)
                number = ConvertMillions(Convert.ToInt32(number));
            else if (number.Length > 3 && number.Length < 7)
                number = ConvertThousands(Convert.ToInt32(number));
            else
                number = ConvertHundreds(Convert.ToInt32(number));
            return number;
        }
        private static string ConvertHundreds(int number)
        {
            string words = "";

            var sisa = number % 100;
            var x = Math.Abs(number / 100);
            if (x != 0)
                words += Satuan(x) + " Hundred ";

            if (number.ToString().Length == 3 && sisa != 0)
            {
                words += "and ";
            }

            if (sisa > 19 || (sisa < 11 && sisa != 0))
            {
                if (sisa.ToString().Contains("0"))
                {
                    x = Math.Abs(sisa / 10);
                    sisa = sisa % 10;
                    if (x != 0)
                        words += Puluhan(x);
                }
                else
                {
                    x = Math.Abs(sisa / 10);
                    sisa = sisa % 10;
                    if (x != 0)
                        words += Puluhan(x) + "-";
                }

                if (sisa != 0)
                {
                    x = Math.Abs(sisa / 1);
                    sisa = sisa % 1;
                    if (x != 0)
                        words += Satuan(x);
                }
            }
            else
            {
                words += Belasan(sisa);
            }

            return words;
        }
        private static string ConvertThousands(int number)
        {
            string words = "";
            string hundred = number.ToString();

            if (number.ToString().Length > 3)
            {
                number = Convert.ToInt32(number.ToString().Remove(number.ToString().Length - 3));
                words = ConvertHundreds(number) + " Thousand ";
                number = Convert.ToInt32(hundred.Substring(hundred.ToString().Length - 3));
                if (number.ToString() != "0")
                    words += "and " + ConvertHundreds(number);
            }
            else
            {
                words = ConvertHundreds(number);
            }
            return words;
        }
        private static string ConvertMillions(int number)
        {
            string words = "";
            string Thousand = number.ToString();

            if (number.ToString().Length > 6)
            {
                number = Convert.ToInt32(number.ToString().Remove(number.ToString().Length - 6));
                words = ConvertHundreds(number) + " Million ";
                number = Convert.ToInt32(Thousand.Substring(Thousand.ToString().Length - 6));
                if (number.ToString() != "0")
                    words += "and " + ConvertThousands(number);
            }
            else
            {
                words = ConvertThousands(number);
            }
            return words;
        }

    }
}
