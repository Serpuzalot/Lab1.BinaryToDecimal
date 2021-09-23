using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.BinaryToDecimal
{
    public class BinaryToDecimalConvert
    {
        private List<int> _numList;
        private int _dotPosition = int.MinValue;

        public BinaryToDecimalConvert(double num)
        {
            if (!CheckEnterData(num))
            {
                return;
            }
            string numStr = num.ToString();

            _numList = new List<int>();
            for (int i = 0; i < numStr.Length; i++)
            {
                if (i != _dotPosition)
                {
                    _numList.Add(Convert.ToInt32(numStr[i].ToString()));
                }
                
            }


        }

        bool CheckEnterData(double num)
        {
            string str = num.ToString();
            if (dotCheck(str) == true && numCheck(str) == true)
            {
                if (num != null && num >= 0)
                {
                    return true;
                }
            }
            return false;
        }

        private bool dotCheck(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ',' || str[i] == '.' && _dotPosition == int.MinValue)
                {
                    _dotPosition = i;
                }
                else if (_dotPosition != int.MinValue && str[i] == ',' || str[i] == '.')
                {
                    return false;
                }

            }
            return true;
        }

        private bool numCheck(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (i != _dotPosition)
                {
                    int num = int.Parse(str[i].ToString());
                    bool a = num == 1 || num == 0;
                    if (!a)
                    {
                        return false;
                    }
                }

            }
            return true;
        }

    }
}
