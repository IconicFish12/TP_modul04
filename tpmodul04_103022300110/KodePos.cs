using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul04_103022300110
{
    enum KodePosEnum
    {
        Batununggal = 40266,
        Kujangsari = 40287,
        Mengger = 40267,
        Wates = 40256,
        Cijaura = 40287,
        Jatisari = 40286,
        Margasari = 40286,
        Sekejati = 40286,
        Kebonwaru = 40272,
        Maleer = 40274,
        Samoja = 40273
    }

    class KodePos
    {
        public int? GetKodePos(string kelurahan)
        {
            if (Enum.TryParse(kelurahan, out KodePosEnum result))
            {
                return (int)result;
            }

            return null;
        }
    }
}
