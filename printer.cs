using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printer_main
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows printer;
            Console.WriteLine("Pilih Printer");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. Lasetjet");
            Console.WriteLine("");
            Console.WriteLine("Nomor Printer [1..3] : ");
            int nomor = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");
     
            if (nomor == 1)
                printer = new Epson();
            else if (nomor == 2)
                printer = new Canon();
            else
                printer = new Lasetjat();

            printer.show();
            printer.print();

            Console.ReadKey();
        }
    }
}

public class PrinterWindows
{

    public virtual void show ()
    {
        Console.WriteLine("Print Display Dimension");
    }
    public virtual void print ()
    {
        Console.WriteLine("Printer Printing ....");
    }
}

public class Epson : PrinterWindows
{
    public override void show()
    {
        Console.WriteLine("Epson Display Dimension : 10*11");
    }
    public override void print()
    {
        Console.WriteLine("Epson Printer Printing ....");
    }
}

public class Canon : PrinterWindows
{
    public override void show()
    {
        Console.WriteLine("Canon Display Dimension : 9.5*12");
    }
    public override void print()
    {
        Console.WriteLine("Canon Printer Printing ....");
    }
}

public class Lasetjat : PrinterWindows
{
    public override void show()
    {
        Console.WriteLine("Lasetjat Display Dimension : 12*12");
    }
    public override void print()
    {
        Console.WriteLine("Lasetjat Printer Printing ....");
    }
}
