using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Classes
{

        public struct DiscountInfo
        {
            public string Code { get; }
            public decimal Rate { get; }

            public DiscountInfo(string code, decimal rate)
            {
                Code = code;
                Rate = rate;
            }
        }
    }

