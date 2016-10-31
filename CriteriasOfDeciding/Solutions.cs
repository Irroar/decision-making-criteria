using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriteriasOfDeciding
{
    internal class Solutions
    {
        private List<double> _tempArray;
        private List<double> _results;
        private int _i;
        private int _j;

        private List<double> FindMin(double[,] array, int count, string state)
        {
            _tempArray = new List<double>();
            _results = new List<double>();
            if (state == "Row")
            {
                for (_i = 0; _i < count; _i++)
                {
                    for (_j = 0; _j < count; _j++)
                    {
                        _tempArray.Add(array[_i, _j]);
                    }
                    _results.Add(_tempArray.Min());
                    _tempArray.Clear();
                }    
            }
            else if (state == "Col")
            {
                for (_j = 0; _j < count; _j++)
                {
                    for (_i = 0; _i < count; _i++)
                    {
                        _tempArray.Add(array[_i, _j]);
                    }
                    _results.Add(_tempArray.Min());
                    _tempArray.Clear();
                }
            }
            return _results;
        }

        private List<double> FindMax(double[,] array, int count, string state)
        {
            _tempArray = new List<double>();
            _results = new List<double>();
            if (state == "Row")
            {
                for (_i = 0; _i < count; _i++)
                {
                    for (_j = 0; _j < count; _j++)
                    {
                        _tempArray.Add(array[_i, _j]);
                    }
                    _results.Add(_tempArray.Max());
                    _tempArray.Clear();
                }
            }
            else if (state == "Col")
            {
                for (_j = 0; _j < count; _j++)
                {
                    for (_i = 0; _i < count; _i++)
                    {
                        _tempArray.Add(array[_i, _j]);
                    }
                    _results.Add(_tempArray.Max());
                    _tempArray.Clear();
                }
            }
            return _results;
        }

        private static double[] ExpectedValue(double[,] array, int count, string[] q, string state)
        {
            var eir = new double[count];

            if (state == "Row")
            {
                for (var i = 0; i < count; i++)
                {
                    for (var j = 0; j < count; j++)
                    {
                        eir[i] = eir[i] + array[i, j] * double.Parse(q[j]);
                    }
                }
            }
            else if (state == "Col")
            {
                for (var i = 0; i < count; i++)
                {
                    for (var j = 0; j < count; j++)
                    {
                        eir[i] = eir[i] + array[j, i] * double.Parse(q[j]);
                    }
                }
            }
            return eir;
        }

        // Mini-Max criteria
        public double MinMax(double[,] array, int count)
        {
            return FindMin(array, count, "Row").Max();
        }

        // B-L criteria
        public double BLc(double[,] array, int count, string[] q)
        { 
            return ExpectedValue(array, count, q, "Row").Max();
        }

        // S criteria
        public double S(double[,] array, int count)
        {
            var temparray = new double[count, count];

            for (var i = 0; i < count; i++)
            {
                for (var j = 0; j < count; j++)
                {
                    temparray[i, j] = (FindMax(array, count, "Col")[j]) - array[i, j];
                }
            }
           return FindMax(temparray, count, "Row").Min();
        }

        // HW criteria
        public double Hw(double[,] array, int count, double c)
        {
            var eir = new double[count];

                for (var j = 0; j < count; j++)
                {
                    eir[j] = c*(FindMin(array, count, "Col")[j]) + (1 - c)*FindMax(array, count, "Col")[j];
                }       
            return eir.Max();
        }

        // H-L criteria
        public double Hl(double[,] array, int count, double v, string[] q)
        {
            var eir = new double[count];
                for (var j = 0; j < count; j++)
                {
                    eir[j] = v*ExpectedValue(array, count, q, "Row")[j] + (1 - v)*FindMin(array, count, "Col")[j];
                }
            return eir.Max();
        }

        // G criteria
        public double G(double[,] array, int count, string[] q)
        {
            var temparray = new double[count, count];

            for (var i = 0; i < count; i++)
            {
                for (var j = 0; j < count; j++)
                {
                    temparray[i, j] = array[i, j]*double.Parse(q[j]);
                }
            }
            return FindMin(temparray, count, "Col").Max() ;   
        }

        // BL-MM criteria 
        public double Bl_Mm(double[,] array, int count, string[] q)
        {
            var temparray = new double[count, count];
            _j = 0;
            var referenceValue = MinMax(array, count);

            for (var i = 0; i < count; i++)
            {
                temparray[i, _j] = ExpectedValue(array, count, q, "Row")[i];
            }

            for (var i = 0; i < count; i++)
            {
                temparray[i, _j + 1] = referenceValue - FindMin(array, count, "Col")[i];
            }

            var k = Array.IndexOf(array, referenceValue);
            MessageBox.Show(k.ToString());

            return 0;
        }
    }
}
