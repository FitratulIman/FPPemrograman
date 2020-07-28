using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualanTiket
{
    public class Program
    {
        // deklarasi objek collection untuk menampung objek penjualanTiket
        static List<Tiket> daftarPenjualan = new List<Tiket>();

        static void Main(string[] args)
        {

            while (true)
            {
                TampilMenu();

                Console.Write("Nomor Menu [1 2 3 4 5]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu) 
                {
                    case 1:
                        TiketVIP();
                        break;

                    case 2:
                        TiketEkonomi();
                        break;

                    case 3:
                        HapusPembelian();
                        break;

                    case 4:
                        TampilPenjualan();
                        break;

                    case 5: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.Write("==============================================================");
            Console.Write("\n|\tHARAGA TIKET MENONTON FINAL PIALA EROPA 2020         |");
            Console.Write("\n|\t\tDi Stadion ALLIANZ ARENA, ITALIA             |");
            Console.Write("\n==============================================================");


            Console.WriteLine("\n|Pilih Menu:                                                 |");
            Console.WriteLine("|1. Tiket VIP                                                |");
            Console.WriteLine("|2. Tiket Ekonomi                                            |");
            Console.WriteLine("|3. Hapus Pembelian                                          |");
            Console.WriteLine("|4. Tampil Penjualan                                         |");
            Console.WriteLine("|5. Keluar                                                   |");
            Console.WriteLine("==============================================================");


        }

        static void TiketVIP()
        {

            Tiket penjualan = new Tiket();

            Console.Clear();

            Console.WriteLine("================================================");
            Console.WriteLine("|\t\tJADWAL PERTANDINGAN            |");
            Console.WriteLine("================================================");

            Console.WriteLine("================================================");
            Console.WriteLine("|\tTanggal Main : 23 Juli 2020            |");
            Console.WriteLine("|1. JUVENTUS VS BARCELONA  : Rp. 200.000       |");
            Console.WriteLine("================================================");
            Console.WriteLine("================================================");
            Console.WriteLine("|\tTanggal Main : 24 Juli 2020            |");
            Console.WriteLine("|2. REAL MADRID VS CHELSEA : Rp. 200.000       |");
            Console.WriteLine("================================================");

            Console.WriteLine("================================================");
            Console.WriteLine("|\tMasukkan Identitas Penonton            |");
            Console.WriteLine("================================================");

            Console.Write("Jumlah: ");
            penjualan.Jumlah = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tanggal Main: ");
            penjualan.Tanggal = Console.ReadLine();

            Console.Write("Nama Penonton: ");
            penjualan.Customer = Console.ReadLine();

            Console.Write("Jenis [L/P]: ");
            string jenis = Console.ReadLine();

            penjualan.Jenis = (jenis == "L" || jenis == "P") ? "Laki-Laki" : "Perempuan";

            Console.Write("Total Pembayaran:");
            penjualan.TotalNota = Convert.ToInt32(Console.ReadLine());

            daftarPenjualan.Add(penjualan);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TiketEkonomi()
        {

            Tiket penjualan = new Tiket();

            Console.Clear();

            Console.WriteLine("================================================");
            Console.WriteLine("|\t\tJADWAL PERTANDINGAN            |");
            Console.WriteLine("================================================");

            Console.WriteLine("================================================");
            Console.WriteLine("|\tTanggal Main : 23 Juli 2020            |");
            Console.WriteLine("|1. JUVENTUS VS BARCELONA  : Rp. 100.000       |");
            Console.WriteLine("================================================");
            Console.WriteLine("================================================");
            Console.WriteLine("|\tTanggal Main : 24 Juli 2020            |");
            Console.WriteLine("|2. REAL MADRID VS CHELSEA : Rp. 100.000       |");
            Console.WriteLine("================================================");

            Console.WriteLine("================================================");
            Console.WriteLine("|\tMasukkan Identitas Penonton            |");
            Console.WriteLine("================================================");

            Console.Write("Jumlah: ");
            penjualan.Jumlah = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tanggal main");
            penjualan.Tanggal = Console.ReadLine();

            Console.Write("Nama Penonton: ");
            penjualan.Customer = Console.ReadLine();

            Console.Write("Jenis [L/P]: ");
            string jenis = Console.ReadLine();

            penjualan.Jenis = (jenis == "L" | jenis == "p") ? "Laki-Laki" : "Perempuan";

            Console.Write("Total Pembayaran:");
            penjualan.TotalNota = Convert.ToInt32(Console.ReadLine());

            daftarPenjualan.Add(penjualan);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPembelian()
        {
            Console.Clear();

            bool status = false;

            Console.WriteLine("================================================");
            Console.WriteLine("|\t\tHapus Data Pembelian           |");
            Console.WriteLine("================================================");

            Console.Write("Jumlah: ");
            int jumlah = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < daftarPenjualan.Count; i++)
            {
                if (jumlah == daftarPenjualan[i].Jumlah)
                {
                    daftarPenjualan.Remove(daftarPenjualan[i]);
                    status = true;
                    break;
                }
                else
                {
                    status = false;
                }
            }

            if (status)
            {
                Console.WriteLine("Data Penjualan dengan Jumlah \"{0}\" telah dihapus", jumlah);
            }
            else
            {
                Console.WriteLine("Data Penjualan dengan Jumlah \"{0}\" tidak ditemukan", jumlah);
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            Console.WriteLine("================================================");
            Console.WriteLine("|\t     Tampil Penjualan Tiket:           |");
            Console.WriteLine("================================================");

            if (daftarPenjualan.Count > 0)
            {
                for (int i = 0; i < daftarPenjualan.Count; i++)
                {
                    Console.WriteLine(" {0}. | {1}, {2}, {3}, {4}, {5}", i + 1, daftarPenjualan[i].Jumlah, daftarPenjualan[i].Tanggal, daftarPenjualan[i].Customer, daftarPenjualan[i].Jenis, daftarPenjualan[i].TotalNota);
                }
            }
            else
            {
                Console.WriteLine("- Tidak Ada Daftar Penjualan Tiket");
            }


            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
