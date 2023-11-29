using System.IO.Compression;

internal class Program
{
    private static void Main(string[] args)
    {
        // Metin dosyasını oluşturmak için
        string metinIcerik = "Merhaba, bu bir örnek metin dosyasıdır.";
        string metinDosyaYolu = @"D:\Ornek\TextFile.txt";

        OluşturMetinDosyası(metinDosyaYolu, metinIcerik);

        // Klasörü RAR formatında sıkıştırmak ve indirme bağlantısı oluşturmak için
        string klasorYolu = @"D:\Ornek\";
        string rarDosyaYolu = @"D:\Ornek\File.rar";

        SıkıştırVeIndir(klasorYolu, rarDosyaYolu);
    }


    static void OluşturMetinDosyası(string dosyaYolu, string icerik)
    {
        try
        {
            File.WriteAllText(dosyaYolu, icerik);
            Console.WriteLine("Metin dosyası başarıyla oluşturuldu.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata: " + ex.Message);
        }
    }

    static void SıkıştırVeIndir(string kaynakKlasor, string hedefRarDosya)
    {
        try
        {
            ZipFile.CreateFromDirectory(kaynakKlasor, hedefRarDosya);
            Console.WriteLine("Klasör başarıyla RAR formatında sıkıştırıldı.");

            //// İndirme bağlantısı oluşturmak için
            //string indirmeLinki = "http://example.com/YourFile.rar";

            //// RAR dosyasını indirmek için
            //Indir(indirmeLinki, @"C:\Path\To\Your\Downloaded\File.rar");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata: " + ex.Message);
        }
    }

    static void Indir(string url, string hedefDosyaYolu)
    {
        try
        {
            using (var webClient = new System.Net.WebClient())
            {
                webClient.DownloadFile(url, hedefDosyaYolu);
                Console.WriteLine("Dosya başarıyla indirildi.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata: " + ex.Message);
        }
    }
}