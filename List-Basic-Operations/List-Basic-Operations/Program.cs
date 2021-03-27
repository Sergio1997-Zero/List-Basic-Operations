using System;

namespace List_Basic_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            CellPhonesList cellPhonesList = new CellPhonesList();

            CellPhones C1 = new CellPhones();
            C1.Processor = "Spandragon 765";
            C1.Ram = 16; // GBs
            C1.Storage = 1000 ; // Mb 
            C1.Battery = 5000; // mAh
            C1.Cost = 1200; // Dollar
            C1.Color = "Green";
            C1.Units = 20;
            cellPhonesList.Add(C1);

            CellPhones C2 = new CellPhones();
            C2.Processor = "Spandragon 888";
            C2.Ram = 8; // GBs
            C2.Storage = 500; // Mb 
            C2.Battery = 4300; // mAh
            C2.Cost = 2300; // Dollar
            C2.Color = "Red";
            C2.Units = 10;
            cellPhonesList.Add(C2);

            CellPhones C3 = new CellPhones();
            C3.Processor = "Helio G90P";
            C3.Ram = 4; // GBs
            C3.Storage = 2000; // Mb 
            C3.Battery = 4500; // mAh
            C3.Cost = 500; // Dollar
            C3.Color = "Blue";
            C3.Units = 15;
            cellPhonesList.Add(C3);

            CellPhones C4 = new CellPhones();
            C4.Processor = "Spandragon 720G";
            C4.Ram = 12; // GBs
            C4.Storage = 1111; // Mb 
            C4.Battery = 3000; // mAh
            C4.Cost = 7000; // Dollar
            C4.Color = "Yellow";
            C4.Units = 5;
            cellPhonesList.Add(C4);

            CellPhones C5 = new CellPhones();
            C5.Processor = "Spandragon 860";
            C5.Ram = 8; // GBs
            C5.Storage = 1500; // Mb 
            C5.Battery = 4800; // mAh
            C5.Cost = 700; // Dollar
            C5.Color = "Green";
            C5.Units = 13;
            cellPhonesList.Add(C5);

            CellPhones C6 = new CellPhones();
            C6.Processor = "A14";
            C6.Ram = 8; // GBs
            C6.Storage = 2000; // Mb 
            C6.Battery = 4500; // mAh
            C6.Cost = 7000; // Dollar
            C6.Color = "Black";
            C6.Units = 30;
            cellPhonesList.Insert(C6, 2);

            cellPhonesList.Print();

            Console.ReadKey();

            
        }
    }
}
