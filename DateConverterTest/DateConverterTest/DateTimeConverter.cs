using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateConverterTest
{
    public class DateTimeConverter
    {

        public string ToMinutes(DateTime now, DateTime post)
        {
            var dif = now - post;

            if (dif.Minutes == 1)
            {
                return dif.Minutes + (" minuto atras");
            }

            else
            {
                return dif.Minutes + (" minutos atras");
            }


     
        }

        public string ToHours(DateTime now, DateTime post)
        {
            var dif = now - post;

            if (dif.Hours == 1)
            {
                return ("1 hora atras");
            }

            else
            {
                return dif.Hours + (" horas atras");
            }
        }

        public string ToDays(DateTime now, DateTime post)
        {
            var dif = now - post;

            if (dif.Days == 1)
            {
                return ("1 dia atras");
            }

            else
            {
                return dif.Days + (" dias atras");
            }
        }

        public string ToWeeks(DateTime now, DateTime post)
        {
            var dif = now - post;

            if (dif.Days >= 7)
            {
                return ("1 semana atras");
            }

            else
            {
                return null;
            }
        }

        public string ToMonths(DateTime now, DateTime post)
        {
            var dif = now - post;

            if (dif.Days == 30)
            {
                return ("1 mes atras");
            }

            else
            {
                int totalMes = dif.Days;

                totalMes = totalMes / 30;

                return totalMes.ToString() + " meses atras";
            }
        }


    }
}
