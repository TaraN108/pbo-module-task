using System;

public class Program
{
    public static void Main(String[] args)
    {
        Garasi garasi1 = new Garasi();
        Kendaraan mobil1 = new Mobil();
        Kendaraan motor1 = new Motor();
        Kendaraan kapal1 = new Kapal();
        Kendaraan perahu1 = new Perahu();
        garasi1.tambahKendaraan(mobil1);
        garasi1.tambahKendaraan(motor1);
        garasi1.tambahKendaraan(kapal1);
        garasi1.tambahKendaraan(perahu1);
        garasi1.DaftarKendaraan();

    }
}
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
    public void tambahKendaraan(Kendaraan kendaraan)
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