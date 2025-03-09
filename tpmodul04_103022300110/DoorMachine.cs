using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul04_103022300110
{
    enum DoorState
    {
        Terkunci,
        Terbuka
    }
    class DoorMachine
    {
        private DoorState state;

        public DoorMachine()
        {
            state = DoorState.Terkunci; 
            Console.WriteLine("Pintu terkunci");
        }

        public void BukaPintu()
        {
            if (state == DoorState.Terkunci)
            {
                state = DoorState.Terbuka;
                Console.WriteLine("Pintu tidak terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terbuka");
            }
        }

        public void KunciPintu()
        {
            if (state == DoorState.Terbuka)
            {
                state = DoorState.Terkunci;
                Console.WriteLine("Pintu terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terkunci");
            }
        }
    }
}
