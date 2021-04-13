using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsi
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan data1 = new Karyawan("20.11.3316", "Rayhan Aulia Ramadhani", 5000000);
            Karyawan data2 = new Karyawan("20.11.3316", "Rayhan Aulia Ramadhani", 5000000 + 1000000);
            Karyawan data3 = new Karyawan("20.11.3311", "Firdaus Akhmad", 3500000);
            Karyawan data4 = new Karyawan("20.11.3311", "Firdaus Akhmad", 3500000 + 1000000);

            Console.WriteLine("Gaji Karyawan 1");
            Console.WriteLine("================");
            Console.WriteLine("Nim   :{0}", data1.Nim);
            Console.WriteLine("Nama  :{0}", data1.Nama);
            Console.WriteLine("Gaji  :{0}", data1.Gaji);
            Console.WriteLine("Gaji Karyawan 2");
            Console.WriteLine("================");
            Console.WriteLine("Nim   :{0}", data3.Nim);
            Console.WriteLine("Nama  :{0}", data3.Nama);
            Console.WriteLine("Gaji  :{0}", data3.Gaji);
            Console.WriteLine();
            Console.WriteLine("Gaji Karyawan 1 Setelah Mendapat Bonus");
            Console.WriteLine("====================================");
            Console.WriteLine("Nim   :{0}", data2.Nim);
            Console.WriteLine("Nama  :{0}", data2.Nama);
            Console.WriteLine("Gaji  :{0}", data2.Gaji);
            Console.WriteLine("Gaji Karyawan 2 Setelah Mendapat Bonus");
            Console.WriteLine("====================================");
            Console.WriteLine("Nim   :{0}", data4.Nim);
            Console.WriteLine("Nama  :{0}", data4.Nama);
            Console.WriteLine("Gaji  :{0}", data4.Gaji);

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
