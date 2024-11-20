namespace otomat_uygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GECERSİZİSLEM:
            int kola = 40;
            int fanta = 40;
            int cikolata = 30;
            Console.WriteLine("Hoş geldiniz");
            Console.WriteLine("Lütfen Ürün Seçimi Yapınız");
            Console.WriteLine("Çıkmak için 4 Tuşuna Basınız");
            Console.WriteLine("Kola = 40 TL " + " " + "Ürün Kodu = 1");
            Console.WriteLine("Fanta = 40 TL " + " " + "Ürün Kodu = 2");
            Console.WriteLine("Çikolata = 30 TL " + " " + "Ürün Kodu = 3");
            int islem = Convert.ToInt32(Console.ReadLine());
            int toplam_para = 0;

            while (true)
            {
                if (islem == 1)
                {
                    Console.WriteLine("Ödemeniz" + " " + kola + "TL Lütfen Para Girişi Yapınız");

                PARAEKLEME:
                    Console.WriteLine("Para Miktarı Giriniz =");
                    int para = Convert.ToInt32(Console.ReadLine());
                    toplam_para += para;

                    if (toplam_para == kola)
                    {
                        Console.WriteLine("Ödeme Başarılı Lütfen Ürününüzü Hazneden Alınız");
                        Console.WriteLine("Afiyet Olsun");
                        break;
                    }
                    else if (toplam_para < kola)
                    {
                        Console.WriteLine("Yatırılan Tutar = " + toplam_para);
                        Console.WriteLine("Ürün Fiyatı = " + kola);
                        Console.WriteLine("Yatırılan Bakiye Yetersizdir");
                        Console.WriteLine("Para Eklemek İçin = 1");
                        Console.WriteLine("İşlem İptali İçin = 2");
                        int paraEkleme = Convert.ToInt32(Console.ReadLine());

                        if (paraEkleme == 1)
                        {
                            goto PARAEKLEME;

                        }
                        else if (paraEkleme == 2)
                        {
                            Console.WriteLine("işleminiz İptal Edildi İyi Günler Dileriz...");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Lütfen Geçeli Bir İşlem Seçiniz");
                            goto GECERSİZİSLEM;
                        }



                    }
                    else
                    {
                        Console.WriteLine("Ödeme Başarılı Lütfen Ürününüzü ve Para Üstünüzü Hazneden Alınız");
                        Console.WriteLine("Afiyet Olsun");
                        break;
                    }
                }
                else if (islem == 2)
                {
                    Console.WriteLine("Ödemeniz" + " " + fanta + "TL Lütfen Para Girişi Yapınız");

                PARAEKLEME:
                    int para = Convert.ToInt32(Console.ReadLine());
                    toplam_para += para;

                    if (toplam_para == fanta)
                    {
                        Console.WriteLine("Ödeme Başarılı Lütfen Ürününüzü Hazneden Alınız");
                        Console.WriteLine("Afiyet Olsun");
                        break;
                    }
                    else if (toplam_para < fanta)
                    {
                        Console.WriteLine("Yatırılan Tutar = " + toplam_para);
                        Console.WriteLine("Ürün Fiyatı = " + fanta);
                        Console.WriteLine("Yatırılan Bakiye Yetersizdir");
                        Console.WriteLine("Para Eklemek İçin = 1");
                        Console.WriteLine("İşlem İptali İçin = 2");
                        int paraEkleme = Convert.ToInt32(Console.ReadLine());

                        if (paraEkleme == 1)
                        {
                            goto PARAEKLEME;

                        }
                        else if (paraEkleme == 2)
                        {
                            Console.WriteLine("işleminiz İptal Edildi İyi Günler Dileriz...");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Lütfen Geçeli Bir İşlem Seçiniz");
                            goto GECERSİZİSLEM;
                        }



                    }
                    else
                    {
                        Console.WriteLine("Ödeme Başarılı Lütfen Ürününüzü ve Para Üstünüzü Hazneden Alınız");
                        Console.WriteLine("Afiyet Olsun");
                        break;
                    }
                }
                else if (islem == 3)
                {
                    Console.WriteLine("Ödemeniz" + " " + cikolata + "TL Lütfen Para Girişi Yapınız");

                PARAEKLEME:
                    int para = Convert.ToInt32(Console.ReadLine());
                    toplam_para += para;

                    if (toplam_para == cikolata)
                    {
                        Console.WriteLine("Ödeme Başarılı Lütfen Ürününüzü Hazneden Alınız");
                        Console.WriteLine("Afiyet Olsun");
                        break;
                    }
                    else if (toplam_para < cikolata)
                    {
                        Console.WriteLine("Yatırılan Tutar = " + toplam_para);
                        Console.WriteLine("Ürün Fiyatı = " + cikolata);
                        Console.WriteLine("Yatırılan Bakiye Yetersizdir");
                        Console.WriteLine("Para Eklemek İçin = 1");
                        Console.WriteLine("İşlem İptali İçin = 2");
                        int paraEkleme = Convert.ToInt32(Console.ReadLine());

                        if (paraEkleme == 1)
                        {
                            goto PARAEKLEME;

                        }
                        else if (paraEkleme == 2)
                        {
                            Console.WriteLine("işleminiz İptal Edildi İyi Günler Dileriz...");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Lütfen Geçeli Bir İşlem Seçiniz");
                            goto GECERSİZİSLEM;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ödeme Başarılı Lütfen Ürününüzü ve Para Üstünüzü Hazneden Alınız");
                        Console.WriteLine("Afiyet Olsun");
                        break;
                    }
                }
                else if (islem == 4)
                {
                    Console.WriteLine("İşleminiz İptal Edilmiştir");
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Geçersiz İşlem Girdiniz. Ana Menüye Yönlendiriliyorsunuz...");
                    goto GECERSİZİSLEM;
                }
            }
        }
    }
}
