using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decimal_to_binary_to_hex_converter
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }


        private void convertButton_Click(object sender, EventArgs e)
        {
            if (decimalN.Checked == true)
            {
                int input = int.Parse(boxInput.Text);

                if (input > 0)
                {
                    DecimalToBinary();
                    DecimalToHexa();
                    decimalDisplay.Text = "Decimal:- " + boxInput.Text;
                }
                else
                {
                    MessageBox.Show("Numbers below zero not allowed");
                }
            }
            if (binaryN.Checked == true)
            {
                string input = boxInput.Text;
                bool valid = false;
                bool continueExe = false;

                for (int a = input.Length - 1; a >= 0; a -= 1)
                {
                    valid = false;

                    if ((input[a].ToString() == "1") || (input[a].ToString() == "0"))
                    {
                        valid = true;
                    }
                    else
                    {
                        continueExe = false;
                        break;
                    }
                }

                if (valid)
                {
                    continueExe = true;
                }

                if (continueExe)
                {
                    BinaryToDecimal();
                    BinaryToHexa();
                    binaryDisplay.Text = "0b" + input;
                }
                else
                {
                    MessageBox.Show("The input is not in Binary System");
                }
            }
            if (hexaN.Checked == true)
            {
                string input = boxInput.Text;
                bool valid = false;
                bool continueExe = true;

                for (long a = input.Length - 1; a >= 0; a -= 1)
                {
                    bool stopLoop = false;
                    string letter = input[(int)a].ToString();
                    valid = false;

                    switch (letter)
                    {
                        case "1":
                        case "2":
                        case "3":
                        case "4":
                        case "5":
                        case "6":
                        case "7":
                        case "8":
                        case "9":
                        case "A":
                        case "B":
                        case "C":
                        case "D":
                        case "E":
                        case "F": valid = true; break;
                        default: stopLoop = true; break;  
                    }

                    if (stopLoop)
                    {
                        continueExe = false;
                        break;
                    }
                }

                if (valid)
                {
                    continueExe = true;
                }
                if (continueExe)
                {
                    HexaToDeciaml();
                    HexaToBinary();
                    hexDisplay.Text = "0x" + boxInput.Text;
                }
                else
                {
                    MessageBox.Show("The input is not in Hexadecimal System");
                }
            }
        }
        void DecimalToBinary()
        {
                long decimaln = 0L;
                string binaryToDisplay = "0b";
                string decimalString = boxInput.Text;
                bool parse = long.TryParse(decimalString, out decimaln);
                List<int> remainders = new List<int>();            
               if (!parse)
                {
                    MessageBox.Show("Invalid Input");
                }
                else
                {
                      for (long a = decimaln; a != 0; a /= 2)
                      {
                         int remainder = (int)a % 2;
                         remainders.Add(remainder);
                      }
                      for (int b = remainders.Count - 1; b >= 0; b -= 1)
                      {
                         binaryToDisplay += remainders.ElementAt(b).ToString();
                      }
                      binaryDisplay.Text = binaryToDisplay;
                  }
          }
          void DecimalToHexa()
         {
             long decimaln;
             string HexaToDisplay = "0x";
             string decimalString = boxInput.Text;
             bool parse = long.TryParse(decimalString, out decimaln);
             List<int> remainders = new List<int>();

             if (!parse)
             {
                 MessageBox.Show("Invalid Input");
             }
             else
             {
                 for (long a = decimaln; a != 0; a /= 16)
                 {
                     int remainder = (int)a % 16;
                     remainders.Add(remainder);
                 }
                 for (int b = remainders.Count - 1; b >= 0; b -= 1)
                 {
                     string digit = remainders.ElementAt(b).ToString();

                     switch (digit)
                     {
                         case "10": digit = "A"; break;
                         case "11": digit = "B"; break;
                         case "12": digit = "C"; break;
                         case "13": digit = "D"; break;
                         case "14": digit = "E"; break;
                         case "15": digit = "F"; break;
                         default: digit = digit; break;
                     }

                     HexaToDisplay += digit;
                 }
                 hexDisplay.Text = HexaToDisplay;
             }
         }

          long BinaryToDecimal()
          {
              long binary;
              double number = 0;
              int exponent = 0;
              string binaryString = boxInput.Text;
              bool parse = long.TryParse(binaryString, out binary);
              if (!parse)
              {
                  MessageBox.Show("Invalid Input");
              }
              else
              {
                  for (int a = binaryString.Length - 1; a >= 0; a -=1)
                  {
                      int b = int.Parse(binaryString[a].ToString());
                      number += b * Math.Pow(2,exponent);
                      exponent += 1;
                  }
              }
              decimalDisplay.Text = number.ToString();
              return (long)number;
          }
          void BinaryToHexa()
          {
              long decimalCon = BinaryToDecimal();
              List <long> remainders = new List <long>();
              string hexa = "0x";
             
            for (long a = decimalCon; a != 0;a /= 16)
            {
                long remainder = a % 16;
                remainders.Add(remainder);
            }
            for (int b = remainders.Count - 1; b >= 0; b -= 1)
            {
                string digit = remainders.ElementAt(b).ToString();
                switch (digit)
                {
                    case "10": digit = "A"; break;
                    case "11": digit = "B"; break;
                    case "12": digit = "C"; break;
                    case "13": digit = "D"; break;
                    case "14": digit = "E"; break;
                    case "15": digit = "F"; break;
                    default: digit = digit; break;
                }
                hexa += digit;
            }
            hexDisplay.Text = hexa;

          }

        double HexaToDeciaml ()
         {
            string hexaString = boxInput.Text;
            double number = 0;
            long exponent = 0;
            
            for (int a = hexaString.Length - 1; a >= 0; a -= 1)
            {
                string digitChar = hexaString[a].ToString();

                switch(digitChar)
                {
                    case "A": digitChar = "10"; break;
                    case "B": digitChar = "11"; break;
                    case "C": digitChar = "12"; break;
                    case "D": digitChar = "13"; break;
                    case "E": digitChar = "14"; break;
                    case "F": digitChar = "15"; break;
                    default: digitChar = digitChar; break;
                }
                int digit = int.Parse(digitChar);

                number += digit * Math.Pow(16, exponent);
                exponent += 1;
            }
            decimalDisplay.Text = "Decimal:- " + number.ToString();
            return number;
         }
        void HexaToBinary()
        {
            long deciConv = (long)HexaToDeciaml();
            long remainder = 0;
            List<long> remainders = new List<long>();
            string binaryConv = "0b";

              for (long a = deciConv; a != 0; a /= 2)
              {
                  remainder = a % 2;
                  remainders.Add(remainder);
              }
            for (long b = remainders.Count - 1; b >= 0; b -= 1)
            {
                string digit = remainders.ElementAt((int)b).ToString();
                binaryConv += digit;
            }
            binaryDisplay.Text = binaryConv;
        }
    }
}

