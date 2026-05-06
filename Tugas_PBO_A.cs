using System;
using System.Collections.Generic;
public class Kendaraan
{
    public string Nama { get; set; }
    public int Kecepatan { get; set; }
    public virtual void Bergerak()
    {
        Console.WriteLine("Bergerak");
    }
    public void InfoKendaraan()
    {
        Console.WriteLine("Nama: " + Nama);
        Console.WriteLine("Kecepatan: " + Kecepatan);
    }
}
public class Darat : Kendaraan
{
    public int JumlahRoda { get; set; }
    public void HitungRoda()
    {
        Console.WriteLine($"Jumlah Roda: {JumlahRoda}");
    }
}
public class Air : Kendaraan
{
    public string JenisAir { get; set; }
    public void CekKondisiAir()
    {
        Console.WriteLine($"Kondisi Air: {JenisAir}");
    }
}
public class Mobil : Darat
{
    public void Klakson()
    {
        Console.WriteLine("Tin");
    }
    public void Gaspol()
    {
        Console.WriteLine("Ngeng");
    }
    public override void Bergerak()
    {
        Console.WriteLine("Mobil bergerak");
    }
}
public class Motor : Darat
{
    public void Klakson()
    {
        Console.WriteLine("Tin");
    }
    public void Gaspol()
    {
        Console.WriteLine("Ngeng");
    }
    public override void Bergerak()
    {
        Console.WriteLine("Motor bergerak");
    }
}
public class Kapal : Air
{
    public void Berlayar()
    {
        Console.WriteLine("Meluncur di atas air");
    }
    public void Dayung()
    {
        Console.WriteLine("Mengayuh");
    }
    public override void Bergerak()
    {
        Console.WriteLine("Kapal bergerak");
    }
}
public class Perahu : Air
{
    public void Berlayar()
    {
        Console.WriteLine("Meluncur di atas air");
    }
    public void Dayung()
    {
        Console.WriteLine("Mengayuh");
    }
    public override void Bergerak()
    {
        Console.WriteLine("Perahu bergerak");
    }
}
public class Garasi
{
    public List<Kendaraan> Daftar_Kendaraan { get; set; } = new List<Kendaraan>();
    public void TambahKendaraan(Kendaraan kendaraan)
    {
        Daftar_Kendaraan.Add(kendaraan);
    }
    public void DaftarKendaraan()
    {
        Console.WriteLine("Daftar Kendaraan:");
        foreach (var kendaraan in Daftar_Kendaraan)
        {
            Console.WriteLine(kendaraan);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        // a. Buat objek garasi
        Garasi garasi = new Garasi();

        // b. Buat beberapa objek kendaraan
        Mobil mobil1 = new Mobil();
        Motor motor1 = new Motor();
        Kapal kapal1 = new Kapal();
        Perahu perahu1 = new Perahu();

        // c. Tambahkan ke garasi
        garasi.TambahKendaraan(mobil1);
        garasi.TambahKendaraan(motor1);
        garasi.TambahKendaraan(kapal1);
        garasi.TambahKendaraan(perahu1);

        // d. Tampilkan semua data
        garasi.DaftarKendaraan();

        // e. Demonstrasikan polymorphism
        List<Kendaraan> semuaKendaraan = new List<Kendaraan> { mobil1, motor1, kapal1, perahu1 };
        foreach (Kendaraan k in semuaKendaraan)
            k.Bergerak();

        // f. Panggil method khusus
        motor1.Gaspol();
        kapal1.Berlayar();
        mobil1.HitungRoda();
        perahu1.CekKondisiAir();

        //SOAL 1: Bergerak() pada Mobil dan Kapal
        mobil1.Bergerak();
        kapal1.Bergerak();

        //SOAL 2: Klakson() pada Mobil
        mobil1.Klakson();

        //SOAL 3: Informasi lengkap Mobil
        mobil1.InfoKendaraan();
        mobil1.HitungRoda();

        //SOAL 4: Dayung() pada Perahu
        perahu1.Dayung();

        //SOAL 5: Variabel Kendaraan diisi Motor
        Kendaraan kendaraan = motor1;
        kendaraan.Bergerak();
    }
}