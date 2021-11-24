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
            yiyecek();
            icecek();
            tatlilar();
            Console.WriteLine("Sipariş tutarınız: " + fiyat + " TL");
            Console.ReadLine();
        }
        static void menü()
        {
            Console.WriteLine("***MENÜ*** \n1)Yiyecekler \n2)İçecekler \n3)Tatlılar");
            Console.WriteLine("Bir seçim yapınız.");            
            int mSecim = Convert.ToInt32(Console.ReadLine());
            switch (mSecim)
            {
                case 1:
                    Console.WriteLine("Yemek listesi geliyor..");
                    break;
                case 2:
                    Console.WriteLine("İçecek listesi geliyor...");
                    break;
                case 3:
                    Console.WriteLine("Tatlı listesi geliyor...");
                    break;
            }
        }
        static void yiyecek()
        {
            Console.WriteLine("İstediğiniz yemeğin numarasını giriniz:");
            Console.WriteLine("1 - Et yemeği");
            Console.WriteLine("2 - Mantı");
            Console.WriteLine("3 - Tavuk");
            Console.Write("Seçim yapınız :");
            int ySecim = Convert.ToInt32(Console.ReadLine());
            if (ySecim == 1)
            {
                Console.WriteLine("Et yemeğiniz hazırlanıyor");
                fiyat += 30;
            }
            else if (ySecim == 2)
            {
                Console.WriteLine("Mantınız hazırlanıyor.");
                fiyat += 20;
            }
            else if (ySecim == 3)
            {
                Console.WriteLine("Tavuk yemeğiniz hazırlanıyor.");
                fiyat += 25;
            }
        }
        static void icecek()
        {

            Console.WriteLine("İstediğiniz içeceğin numarasını giriniz:");
            Console.WriteLine("1 - Ayran");
            Console.WriteLine("2 - Kola");
            Console.WriteLine("3 - Limonata");
            Console.Write("Seçim yapınız :");
            int iSecim = Convert.ToInt32(Console.ReadLine());
            if (iSecim == 1)
            {
                Console.WriteLine("Ayranınız hazır");
                fiyat += 5;
            }
            else if (iSecim == 2)
            {
                Console.WriteLine("Kolanız hazır.");
                fiyat += 7;
            }
            else if (iSecim == 3)
            {
                Console.WriteLine("Limonatanız hazır.");
                fiyat += 8;
            }
        }
        static void tatlilar()
        {
            Console.WriteLine("İstediğiniz tatlının numarasını giriniz:");
            Console.WriteLine("1 - Sütlaç");
            Console.WriteLine("2 - Kazandibi");
            Console.WriteLine("3 - Tavuk Göğsü");
            Console.Write("Seçim yapınız :");
            int tSecim = Convert.ToInt32(Console.ReadLine());
            if (tSecim == 1)
            {
                Console.WriteLine("Sütlacınız hazır");
                fiyat += 10;
            }
            else if (tSecim == 2)
            {
                Console.WriteLine("Kazandibiniz hazır.");
                fiyat += 12;
            }
            else if (tSecim == 3)
            {
                Console.WriteLine("Tavuk Göğsünüz hazır.");
                fiyat += 12;
            }




        }
    }
}
