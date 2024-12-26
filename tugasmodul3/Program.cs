using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Cetak Angka 1-30 dengan Keterangan Ganjil/Genap\n");
        
        // // angka 1- 30
        // for (int i = 1; i <= 30; i++)
        // {
        //     // Menggunakan operator modulus (%) untuk mengecek ganjil/genap
        //     if (i % 2 == 0)
        //     {
        //         Console.WriteLine($"Angka {i} adalah bilangan GENAP");
        //     }
        //     else
        //     {
        //         Console.WriteLine($"Angka {i} adalah bilangan GANJIL");
        //     }
        // }
        
        // Console.WriteLine("\nProgram selesai.");
        // Console.ReadKey();

        //-------------------------------------------------------------------------------------------------------------------------------
        //FOR LOOP

        // int i;

        // for (i = 1; i <= 30; i++)
        // {
        //     if (i % 2 == 0)
        //     {
        //         Console.WriteLine(i + " = Bilangan GENAP");
        //     }
        //     else
        //     {
        //         Console.WriteLine(i + " = Bilangan GANJIL");
        //     }
        // }

        //----------------------------------------------------------------------------------------------------------------------------------
        //WHILE LOOP

        // int i;

        // i = 1;
        // while (i <= 30)
        // {
        //     if (i % 2 == 0)
        //     {
        //         Console.WriteLine(i + " = Bilangan Genap");
        //     }
        //     else
        //     {
        //         Console.WriteLine(i + " = Bilangan Ganjil");
        //     }
        //     i = i + 1;
        // }

        //-----------------------------------------------------------------------------------------------------------------------------------------
        //DO WHILE LOOP

   
        // int i;

        // i = 1;
        // do
        // {
        //     if (i % 2 == 0)
        //     {
        //         Console.WriteLine(i + " Merupakan Bilangan GENAP");
        //     }
        //     else
        //     {
        //         Console.WriteLine(i + " Merupakan Bilangan GANJIL");
        //     }
        //     i = i + 1;
        // } while (i <= 30);

//--------------------------------------------------------------------------------------------------------------------\\\

// int pilihan = 0;
        
//         do {
//             Console.WriteLine("\n--Pilihan Menu Kalkulator Sederhana--");
//             // menu dengan for
//             for (int i = 1; i <= 5; i++)
//             {
//                 Console.WriteLine($"{i}. {(i == 1 ? "Tambah" : i == 2 ? "Kurang" : i == 3 ? "Kali" : i == 4 ? "Bagi" : "Keluar")}");
//             }

//             Console.Write("Masukkan pilihan Anda (1-5): ");
//             pilihan = Convert.ToInt32(Console.ReadLine());

//             // while untuk validasi pilihan
//             while (pilihan < 1 || pilihan > 5)
//             {
//                 Console.WriteLine("Pilihan tidak valid!");
//                 Console.Write("Masukkan pilihan Anda (1-5): ");
//                 pilihan = Convert.ToInt32(Console.ReadLine());
//             }

//             // Proses perhitungan
//             if (pilihan != 5)
//             {
//                 Console.Write("Masukkan angka pertama: ");
//                 double a = Convert.ToDouble(Console.ReadLine());
//                 Console.Write("Masukkan angka kedua: ");
//                 double b = Convert.ToDouble(Console.ReadLine());

//                 switch (pilihan)
//                 {
//                     case 1:
//                         Console.WriteLine($"Hasil: {a} + {b} = {a + b}");
//                         break;
//                     case 2:
//                         Console.WriteLine($"Hasil: {a} - {b} = {a - b}");
//                         break;
//                     case 3:
//                         Console.WriteLine($"Hasil: {a} * {b} = {a * b}");
//                         break;
//                     case 4:
//                         if (b != 0)
//                             Console.WriteLine($"Hasil: {a} / {b} = {a / b}");
//                         else
//                             Console.WriteLine("Tidak bisa membagi dengan nol!");
//                         break;
//                 }
//             }

//         } while (pilihan != 5); // Loop utama dengan do-while

//         Console.WriteLine("Program selesai!");

//--------------------------------------------------------------------------------------------------------------------------------

        // int total = 0;
        // int count = 0;

        // Console.Write("Masukkan nomor (atau -1 untuk berhenti): ");
        // int number = int.Parse(Console.ReadLine());

        // while (number != -1)
        // {
        //     total += number;
        //     count++;

        //     Console.Write("Masukkan nomor (atau -1 untuk berhenti): ");
        //     number = int.Parse(Console.ReadLine());
        // }

        // if (count > 0)
        // {
        //     double average = (double)total / count;
        //     Console.WriteLine($"Rata-rata : {average}");
        // }
        // else
        // {
        //     Console.WriteLine("No numbers entered!");
        // }

//----------------------------------------------------------------------------------------------------------------------------------------------








    }
}