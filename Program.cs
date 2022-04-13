using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCISE1
{
    class Program
    {
            public void InsertData()
            {
                SqlConnection con = null;
                try
                {
                    con = new SqlConnection("data source=DESKTOP-F1MNKP6;database=Bakery;Integrated Security = TRUE");
                    con.Open();

                    SqlCommand cm = new SqlCommand("insert into Customer (ID_Cust,Nama_Cust,Alamat_Cust,No_tlp) values ('C00-01','Ahmad Yani','Maros');" +
                        "insert into Customer (ID_Cust,Nama_Cust,Alamat_Cust, No_tlp) values ('C00-02','Dzakira Mokoginta','Manado');" +
                        "insert into Customer (ID_Cust,Nama_Cust,Alamat_Cust, No_tlp) values ('C00-03','Isra Al-Maizah','Toraja');" +
                        "insert into Customer (ID_Cust,Nama_Cust,Alamat_Cust, No_tlp) values ('C00-04','Rahmi Nur Hakim','Palu');" +
                        "insert into Customer (ID_Cust,Nama_Cust,Alamat_Cust, No_tlp) values ('C00-05','Muh.Aswi','Parepare');" +

                        "insert into Kasir (ID_Kasir, Nama_Kasir,Alamat_Kasir,No_Tlp) Values ('K00-01','Asraf','Makassar','083879654231')" +
                        "insert into Kasir (ID_Kasir, Nama_Kasir, Alamat_Kasir, NO_Tlp) Values('K00-02', 'Israf', 'Makassar', '085564325865')" +
                        "insert into Kasir (ID_Kasir, Nama_Kasir, Alamat_Kasir, NO_Tlp) Values('K00-03', 'Arman Fauzi', 'Makassar', '085649284533')" +
                        "insert into Kasir (ID_Kasir, Nama_Kasir, Alamat_Kasir, NO_Tlp) Values('K00-04', 'Agung', 'Makassar', '085349419234')" +
                        "insert into Kasir (ID_Kasir, Nama_Kasir, Alamat_Kasir, NO_Tlp) Values('K00-05', 'Maulana', 'Makassar', '081234756875')" +

                        "insert into  Roti (Kode_Roti, Jenis_Roti, Harga, Tgl_Pembuatan) Values ('R0-01','Muffin',15000,'11-10-2022')" +
                        "insert into  Roti (Kode_Roti, Jenis_Roti, Harga, Tgl_Pembuatan) Values ('R0-02', 'Croissant', 20000, '11-10-2022')" +
                        "insert into  Roti (Kode_Roti, Jenis_Roti, Harga, Tgl_Pembuatan) Values ('R0-03', 'Pastry', 30000,  '11-10-2022')" +
                        "insert into  Roti (Kode_Roti, Jenis_Roti, Harga, Tgl_Pembuatan) Values ('R0-04', 'Breadsticks', 15000, '11-10-2022')" +
                        "insert into  Roti (Kode_Roti, Jenis_Roti, Harga, Tgl_Pembuatan) Values ('R0-05', 'Bagel', 10000,  '11-10-2022')" +

                        "insert into Transaksi (ID_Transaksi,ID_Kasir,ID_Cust,Kode_Roti,Tgl_bayar,Jumlah,Total_harga) Values" +
                        "('P0-01', 'K00-01', 'C00-01', 'R0-01', 13 - 10 - 2022, 1, '15000')" +
                        "insert into Pembayaran (ID_Pembayaran,ID_Kasir,ID_Cust,Kode_Roti,Tgl_bayar,Jumlah,Total_harga) Values" +
                        "('P0-02', 'K00-02', 'C00-02', 'R0-02', 13 - 10 - 2022, 1, '20000')" +
                        "insert into Pembayaran (ID_Pembayaran,ID_Kasir,ID_Cust,Kode_Roti,Tgl_bayar,Jumlah,Total_harga) Values" +
                        "('P0-03', 'K00-03', 'C00-03', 'R0-03', 13 - 10 - 2022, 2, '60000')" +
                        "insert into Pembayaran (ID_Pembayaran,ID_Kasir,ID_Cust,Kode_Roti,Tgl_bayar,Jumlah,Total_harga) Values" +
                        "('P0-04', 'K00-04', 'C00-04', 'R0-04', 13 - 10 - 2022, 2, '30000')" +
                        "insert into Pembayaran (ID_Pembayaran,ID_Kasir,ID_Cust,Kode_Roti,Tgl_bayar,Jumlah,Total_harga) Values" +
                        "('P0-05', 'K00-05', 'C00-05', 'R0-05', 13 - 10 - 2022, 3, '30000') ", con);
                    cm.ExecuteNonQuery();

                    Console.WriteLine("Berhasil");
                    Console.ReadKey();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Gagal" + e);
                    Console.ReadKey();
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
    