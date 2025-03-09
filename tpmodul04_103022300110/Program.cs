using System;
using tpmodul04_103022300110;

public class Program
{

    public static void Main()
    {
        Console.WriteLine("Kode Pos Batununggal: " + KodePos.GetKodePos(KodePos.KodePosEnum.Batununggal));
        Console.WriteLine("Kode Pos Kujangsari: " + KodePos.GetKodePos(KodePos.KodePosEnum.Kujangsari));
        Console.WriteLine("Kode Pos Wates: " + KodePos.GetKodePos(KodePos.KodePosEnum.Wates));

        DoorMachine door = new DoorMachine();

        door.BukaPintu(); 
        door.BukaPintu(); 
        door.KunciPintu(); 
        door.KunciPintu();
    }
}