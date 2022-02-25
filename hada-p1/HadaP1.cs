using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class HadaP1
    {
        // Convierte de segundos a minutos
        public static double Seconds2Minutes(double s)
        {
            if(s != 0)
            {
                return s / 60;
            }
            return 0;
        }
        // Convierte de minutos a segundos
        public static double Minutes2Seconds(double m)
        {
            m * 60;
        }

        // Convierte horas a minutos
        public static double Hours2Minutes(double h)
        {
            return h * 60;
        }
    }
}
