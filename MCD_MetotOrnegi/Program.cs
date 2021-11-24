using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_MetotOrnegi
{
    class Program
    {
        static int fiyat = 0;
        static void Main(string[] args)
        {
            #region
            //            Bu uygulama örneğimizden toplam 4 adet metot kullanmaktayız.
            //Bu kullandığımız metotların adları ise sırası ile; yiyecek, içecek, tatlılar ve hesap işlemlerini yerine getiren metotlardır.
            //Uygulamamızı kullanan kullanıcılar uygulamayı açtıklarında karşılarına menü seçenekleri çıkıyor.
            //Bu seçeneklerin seçimine ve toplam hesap bilgilerine göre metotlarımız devreye girip hesaplıyor. 
            //Sonucu da ekrana yazdırıyor. 


            //                        Console.WriteLine("İstediğiniz yemeğin numarasını giriniz:");
            //            Console.WriteLine("1 - Et yemeği");
            //            Console.WriteLine("2 - Mantı");
            //            Console.WriteLine("3 - Tavuk");


            //Console.WriteLine("İstediğiniz içeceğin numarasını giriniz:");
            //Console.WriteLine("1 - Ayran");
            //Console.WriteLine("2 - Kola");
            //Console.WriteLine("3 - Limonata");

            //Console.WriteLine("İstediğiniz tatlının numarasını giriniz:");
            //Console.WriteLine("1 - Sütlaç");
            //Console.WriteLine("2 - Kazandibi");
            //Console.WriteLine("3 - Tavuk Göğsü");
            #endregion
           
            menü();
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim==1)
            {
                yiyecek();
                int ySecim = Convert.ToInt32(Console.ReadLine());
                if (ySecim==1)
                {
                    Console.WriteLine("Et yemeğiniz hazırlanıyor");
                    fiyat += 30;
                    icecek();
                    int iSecim1 = Convert.ToInt32(Console.ReadLine());
                    if (iSecim1==1)
                    {
                        Console.WriteLine("Ayranınız hazır");
                        fiyat += 5;
                        tatlilar();
                        int tSecim = Convert.ToInt32(Console.ReadLine());
                        if (tSecim==1)
                        {
                            Console.WriteLine("Sütlacınız hazırlanıyor.");
                            fiyat += 10;
                            Console.WriteLine("Sipariş tutarınız: " + fiyat + " TL");

                        }
                        else if (tSecim==2)
                        {
                            Console.WriteLine("Kazandibiniz hazırlanıyor.");
                            fiyat += 12;
                            Console.WriteLine("Sipariş tutarınız: " + fiyat + " TL");
                        }
                        else if (tSecim==3)
                        {
                            Console.WriteLine("Tavuk Göğsünüz hazırlanıyor");
                            fiyat += 12;
                            Console.WriteLine("Sipariş tutarınız: " + fiyat + " TL");
                        }
                    }
                    else if (iSecim1==2)
                    {
                        Console.WriteLine("Kolanız hazır.");
                        fiyat += 7;
                        tatlilar();
                        int tSecim = Convert.ToInt32(Console.ReadLine());
                        if (tSecim == 1)
                        {
                            Console.WriteLine("Sütlacınız hazırlanıyor.");
                            fiyat += 10;
                            Console.WriteLine("Sipariş tutarınız: " + fiyat + " TL");
                        }
                        else if (tSecim == 2)
                        {
                            Console.WriteLine("Kazandibiniz hazırlanıyor.");
                            fiyat += 12;
                            Console.WriteLine("Sipariş tutarınız: " + fiyat + " TL");
                        }
                        else if (tSecim == 3)
                        {
                            Console.WriteLine("Tavuk Göğsünüz hazırlanıyor");
                            fiyat += 12;
                            Console.WriteLine("Sipariş tutarınız: " + fiyat + " TL");
                        }
                    }
                    else if (iSecim1==3)
                    {
                        Console.WriteLine("Limonatanız hazır.");
                        fiyat += 8;
                        tatlilar();
                        int tSecim = Convert.ToInt32(Console.ReadLine());
                        if (tSecim == 1)
                        {
                            Console.WriteLine("Sütlacınız hazırlanıyor.");
                            fiyat += 10;
                            Console.WriteLine("Sipariş tutarınız: " + fiyat + " TL");
                        }
                        else if (tSecim == 2)
                        {
                            Console.WriteLine("Kazandibiniz hazırlanıyor.");
                            fiyat += 12;
                            Console.WriteLine("Sipariş tutarınız: " + fiyat + " TL");
                        }
                        else if (tSecim == 3)
                        {
                            Console.WriteLine("Tavuk Göğsünüz hazırlanıyor");
                            fiyat += 12;
                            Console.WriteLine("Sipariş tutarınız: " + fiyat + " TL");
                        }
                    }
                }
                else if (ySecim==2)
                {
                    Console.WriteLine("Mantınız hazırlanıyor.");
                    fiyat += 20;
                    icecek();
                    int iSecim1 = Convert.ToInt32(Console.ReadLine());
                    if (iSecim1 == 1)
                    {
                        Console.WriteLine("Ayranınız hazır");
                        fiyat += 5;
                        tatlilar();
                        int tSecim = Convert.ToInt32(Console.ReadLine());
                        if (tSecim == 1)
                        {
                            Console.WriteLine("Sütlacınız hazırlanıyor.");
                            fiyat += 10;
                            Console.WriteLine("Sipariş tutarınız: " + fiyat + " TL");
                        }
                        else if (tSecim == 2)
                        {
                            Console.WriteLine("Kazandibiniz hazırlanıyor.");
                            fiyat += 12;
                            Console.WriteLine("Sipariş tutarınız: " + fiyat + " TL");
                        }
                        else if (tSecim == 3)
                        {
                            Console.WriteLine("Tavuk Göğsünüz hazırlanıyor");
                            fiyat += 12;
                            Console.WriteLine("Sipariş tutarınız: " + fiyat + " TL");
                        }
                    }
                    else if (iSecim1 == 2)
                    {
                        Console.WriteLine("Kolanız hazır.");
                        fiyat += 7;
                        tatlilar();
                        int tSecim = Convert.ToInt32(Console.ReadLine());
                        if (tSecim == 1)
                        {
                            Console.WriteLine("Sütlacınız hazırlanıyor.");
                            fiyat += 10;
                            Console.WriteLine("Sipariş tutarınız: " + fiyat + " TL");
                        }
                        else if (tSecim == 2)
                        {
                            Console.WriteLine("Kazandibiniz hazırlanıyor.");
                            fiyat += 12;
                            Console.WriteLine("Sipariş tutarınız: " + fiyat + " TL");
                        }
                        else if (tSecim == 3)
                        {
                            Console.WriteLine("Tavuk Göğsünüz hazırlanıyor");
                            fiyat += 12;
                            Console.WriteLine("Sipariş tutarınız: " + fiyat + " TL");
                        }
                    }
                    else if (iSecim1 == 3)
                    {
                        Console.WriteLine("Limonatanız hazır.");
                        fiyat += 7;
                        tatlilar();
                        int tSecim = Convert.ToInt32(Console.ReadLine());
                        if (tSecim == 1)
                        {
                            Console.WriteLine("Sütlacınız hazırlanıyor.");
                            fiyat += 10;
                            Console.WriteLine("Sipariş tutarınız: " + fiyat + " TL");
                        }
                        else if (tSecim == 2)
                        {
                            Console.WriteLine("Kazandibiniz hazırlanıyor.");
                            fiyat += 12;
                            Console.WriteLine("Sipariş tutarınız: " + fiyat + " TL");
                        }
                        else if (tSecim == 3)
                        {
                            Console.WriteLine("Tavuk Göğsünüz hazırlanıyor");
                            fiyat += 12;
                            Console.WriteLine("Sipariş tutarınız: " + fiyat + " TL");
                        }
                    }
                }
                else if (ySecim==3)
                {
                    Console.WriteLine("Tavuk yemeğiniz hazırlanıyor.");
                    fiyat += 25;
                    icecek();
                    int iSecim1 = Convert.ToInt32(Console.ReadLine());
                    if (iSecim1 == 1)
                    {
                        Console.WriteLine("Ayranınız hazır");
                        fiyat += 5;
                        tatlilar();
                        int tSecim = Convert.ToInt32(Console.ReadLine());
                        if (tSecim == 1)
                        {
                            Console.WriteLine("Sütlacınız hazırlanıyor.");
                            fiyat += 10;
                            Console.WriteLine("Sipariş tutarınız: " + fiyat + " TL");
                        }
                        else if (tSecim == 2)
                        {
                            Console.WriteLine("Kazandibiniz hazırlanıyor.");
                            fiyat += 12;
                            Console.WriteLine("Sipariş tutarınız: " + fiyat + " TL");
                        }
                        else if (tSecim == 3)
                        {
                            Console.WriteLine("Tavuk Göğsünüz hazırlanıyor");
                            fiyat += 12;
                            Console.WriteLine("Sipariş tutarınız: " + fiyat + " TL");
                        }
                    }
                    else if (iSecim1 == 2)
                    {
                        Console.WriteLine("Kolanız hazır.");
                        fiyat += 7;
                        tatlilar();
                        int tSecim = Convert.ToInt32(Console.ReadLine());
                        if (tSecim == 1)
                        {
                            Console.WriteLine("Sütlacınız hazırlanıyor.");
                            fiyat += 10;
                            Console.WriteLine("Sipariş tutarınız: " + fiyat + " TL");
                        }
                        else if (tSecim == 2)
                        {
                            Console.WriteLine("Kazandibiniz hazırlanıyor.");
                            fiyat += 12; 
                            Console.WriteLine("Sipariş tutarınız: " + fiyat + " TL");
                        }
                        else if (tSecim == 3)
                        {
                            Console.WriteLine("Tavuk Göğsünüz hazırlanıyor");
                            fiyat += 12;
                            Console.WriteLine("Sipariş tutarınız: " + fiyat + " TL");
                        }
                    }
                    else if (iSecim1 == 3)
                    {
                        Console.WriteLine("Limonatanız hazır.");
                        fiyat += 8;
                        tatlilar();
                        int tSecim = Convert.ToInt32(Console.ReadLine());
                        if (tSecim == 1)
                        {
                            Console.WriteLine("Sütlacınız hazırlanıyor.");
                            fiyat += 10;
                            Console.WriteLine("Sipariş tutarınız: " + fiyat + " TL");
                        }
                        else if (tSecim == 2)
                        {
                            Console.WriteLine("Kazandibiniz hazırlanıyor.");
                            fiyat += 12;
                            Console.WriteLine("Sipariş tutarınız: " +fiyat + " TL");
                        }
                        else if (tSecim == 3)
                        {
                            Console.WriteLine("Tavuk Göğsünüz hazırlanıyor");
                            fiyat += 12;
                            Console.WriteLine("Sipariş tutarınız: " + fiyat + " TL");
                        }
                    }
                }
            }
            Console.ReadLine();

        }
        static void menü()
        {
            Console.WriteLine("***MENÜ*** \n1)Yiyecekler \n2)İçecekler \n3)Tatlılar");
            Console.WriteLine("Bir seçim yapınız.");
        }
        static void yiyecek()
        {
            Console.WriteLine("İstediğiniz yemeğin numarasını giriniz:");
            Console.WriteLine("1 - Et yemeği");
            Console.WriteLine("2 - Mantı");
            Console.WriteLine("3 - Tavuk");
        }
        static void icecek()
        {

            Console.WriteLine("İstediğiniz içeceğin numarasını giriniz:");
            Console.WriteLine("1 - Ayran");
            Console.WriteLine("2 - Kola");
            Console.WriteLine("3 - Limonata");
        }
        static void tatlilar()
        {
            Console.WriteLine("İstediğiniz tatlının numarasını giriniz:");
            Console.WriteLine("1 - Sütlaç");
            Console.WriteLine("2 - Kazandibi");
            Console.WriteLine("3 - Tavuk Göğsü");
        }
        
           
        
    }
}
