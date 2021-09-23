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

        bool CheckEnterData(double num)
        {
            string str = num.ToString();
            if (DotCheck(str) == true && NumCheck(str) == true)
            {
                if (num != null && num >= 0)
                {
                    return true;
                }
            }
            return false;
        }

        private bool DotCheck(string str)
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

        private bool NumCheck(string str)
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

        private double GetResultBehindDot()
        {
            double result = 0;
            int start;
            if (_dotPosition == int.MinValue)
            {
                start = _numList.Count - 1;
            }
            else
            {
                start = _dotPosition - 1;
            }
            for (int i = start; i >= 0; i--)
            {
                if (_numList[i] == 1)
                {
                    result += 1 * Math.Pow(2, (start) - i);
                }
            }
            return result;
        }

        private double GetResultAfterDot()
        {
            double result = 0;
            int counter = 1;
            for(int i = _dotPosition ; i < _numList.Count; i++)
            {
                if(_numList[i] == 1)
                {
                    result += 1.0 * Math.Pow(2, -counter);
                }
                counter++;
            }
            return result;
        }

        public double GetResult(double num)
        {
            if (!CheckEnterData(num))
            {
                return double.NaN;
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
            double result = 0;
            result += GetResultBehindDot();
            if(_dotPosition != int.MinValue)
            {
                result += GetResultAfterDot();
            }
            return result;
        }

    }
}
