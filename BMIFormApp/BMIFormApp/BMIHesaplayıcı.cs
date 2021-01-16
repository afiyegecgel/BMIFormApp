using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIFormApp
{
    public class BMIHesaplayıcı
    {
        public double BMIHesapla(double kilo, double boy)
        {
            double BMIValue = kilo / (boy * boy);
            return BMIValue;
        }

    }
}
