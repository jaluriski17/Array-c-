using System;

class Program
{
    static void Main()
    {
        // Mendeklarasikan dan menginisialisasi array
        int[] nilai = { 80, 65, 90, 55, 75 };

        // Menampilkan nilai dalam array
        Console.WriteLine("Nilai dalam array:");

        // Menggunakan loop for untuk menampilkan setiap nilai dalam array
        for (int i = 0; i < nilai.Length; i++)
        {
            Console.Write($"{nilai[i]} ");
        }

        Console.WriteLine(); // Baris baru

        // Eksperimen dengan nilai dalam array
        Console.WriteLine("\nEksperimen dengan nilai dalam array:");

        // Menggunakan loop for untuk mengakses dan mengeksekusi setiap nilai dalam array
        for (int i = 0; i < nilai.Length; i++)
        {
            // Eksperimen: Jika nilai di atas 70, tampilkan pesan lulus; jika tidak, tampilkan pesan belum lulus
            if (nilai[i] > 70)
            {
                Console.WriteLine($"Nilai {nilai[i]}: Lulus");
            }
            else
            {
                Console.WriteLine($"Nilai {nilai[i]}: Belum Lulus");
            }
        }
    }
}
