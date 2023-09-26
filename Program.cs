

class BoardingPass 
    {
static void Main(string[] args) 
    {
string name = "Dono Kasino";
string id = "32901270950002";
string seat = "2/7A";
string departure = "STASIUN AMBAR / 8 MAR 2023 10.00 WIB";
string arrival = "STASIUN AMBAR / 8 MAR 2023 10.30 WIB";

Console.WriteLine("BOARDING PASS WISATA KERETA");
Console.WriteLine("\n");
Console.WriteLine("Nama/name : " + name);
Console.WriteLine("Nomor Identitas : " + id);
Console.WriteLine("Nomor Kursi : " + seat);
Console.WriteLine("\nBerangkat ");
Console.WriteLine(departure);
Console.WriteLine("\nPerkiraan Tiba");
Console.WriteLine(arrival);
Console.WriteLine("\nWajib menunjukkan bukti identitas asli pada saat " + "\u001B[3m" +"boarding" + "\u001B[0m"+ " dan pemeriksaan di kereta api.");
            }
    }
