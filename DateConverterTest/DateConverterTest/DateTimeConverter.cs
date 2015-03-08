using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateConverterTest
{
    public class DateTimeConverter
    {

        public string ToDate(DateTime now, DateTime post)
        {
            var dif = post - now;

            if (dif.Minutes == 1)
            {
                return dif.Minutes + (" minuto atras");
            }

            else
            {
                return dif.Minutes + (" minutos atras");
            }
         
        }

    }
}
