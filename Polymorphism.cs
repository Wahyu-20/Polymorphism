using System;

namespace WindowsPrinter
{
    class Printer
    {
        static void Main(string[] args)
        {
            PrinterWindows printer;

            Console.WriteLine("Pilih Printer : ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Cannon");
            Console.WriteLine("3. LaserJet");

            Console.WriteLine("Nomer Printer [1..3] : ");
            int nomor = Convert.ToInt32(Console.ReadLine());

            if (nomor == 1)
            {
                printer = new Epson();
            }
            else if (nomor == 2)
            {
                printer = new Cannon();
            }
            else
            {
                printer = new LaserJet();
            }

            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
    }
    public class PrinterWindows
    {
        public string Name { get; set; }
        public virtual void Print()
        {
            Console.WriteLine("printer printing...");
        }
        public virtual void Show()
        {
            Console.WriteLine("display dimension");
        }
    }
    public class Epson : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("\nEpson display dimension : 10*11");
        }
        public override void Print()
        {
            Console.WriteLine("Epson printer printing....");
        }
    }
    public class Cannon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("\nCannon display dimension : 9.5*12");
        }
        public override void Print()
        {
            Console.WriteLine("Cannon printer printing....");
        }
    }
    public class LaserJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("\nLaserJet display dimension : 12*12");
        }
        public override void Print()
        {
            Console.WriteLine("LaserJet printer printing....");
        }
    }
}