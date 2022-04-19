namespace ResponsiPemrograman4308
{
    public class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan("190302123", "dana", 4000000);
            Karyawan karyawan2 = new Karyawan("190302124", "eka", 2000000);

            Console.WriteLine("No Nik/Nama      Gaji Bulanan");
            Console.WriteLine("-----------------------------");
            Console.Write("1 "); karyawan1.tampilkanData();
            Console.Write("2 "); karyawan2.tampilkanData();
            Console.WriteLine();

            karyawan1.naikGaji();
            karyawan2.naikGaji();

            Console.WriteLine();
            Console.WriteLine("No Nik/Nama      Gaji Bulanan");
            Console.WriteLine("-----------------------------");
            Console.Write("1 "); karyawan1.tampilkanData();
            Console.Write("2 "); karyawan2.tampilkanData();
        }
    }
}