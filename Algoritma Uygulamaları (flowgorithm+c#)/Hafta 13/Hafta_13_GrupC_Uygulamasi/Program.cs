using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_13_GrupC_Uygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Bir etkinlik için davetli listesi kontrolü yapan ve aşağıdaki işlemleri sırasıyla gerçekleştiren bir C# programı yazınız:

Çalışma Mantığı:

İçinde "Ali", "Mehmet", "Zeynep", "Ayşe", "Emre" isimlerinin olduğu bir ArrayList oluşturunuz.

Kontrolü yapan görevli (kullanıcı) gelen kişinin ismini girmelidir.

IndexOf kullanarak girilen ismin davetli listesinde olup olmadığını kontrol ediniz.

Eğer kişi listede varsa:

1. Davetli listesini alfabetik olarak sıralayınız.

2. BinarySearch kullanarak kişinin sıralı listedeki indeksini bulunuz ve ekrana yazdırınız.

3. "Giriş yapabilirsiniz, hoş geldiniz." mesajını yazdırınız.

Eğer kişi listede yoksa:

1. "İsminiz listede yok, şu an listeye eklendiniz." mesajını yazdırınız.

2. Girilen ismi listenin sonuna ekleyiniz.

3. Güncellenmiş davetli listesini ekrana yazdırınız.

Her adımdan sonra listeyi ekrana yazdırmanız gerekmektedir.*/
            ArrayList davetliler = new ArrayList();
            davetliler.Add("Ali");
            davetliler.Add("Mehmet");
            davetliler.Add("Zeynep");
            davetliler.Add("Ayşe");
            davetliler.Add("Emre");

            Console.WriteLine("Gelen kişinin ismi:");
            String gelenIsim = Convert.ToString(Console.ReadLine()); // kullanıcıdan girdi almasını istiyoruz.
            int varMi = davetliler.IndexOf(gelenIsim); // Böyle bir davetli var mı sorgular.
            if (varMi > -1)
            {
                Console.WriteLine(gelenIsim + " haacom, davetimize hoş geldiniz, giriş yapabilirsiniz.");

                davetliler.Sort(); // küçükten büyüğe sıralar
                Console.WriteLine("Alfabetik sıralama:");
                listele(davetliler);

                int giren_davetlinin_indeksi = davetliler.BinarySearch(gelenIsim); // BinarySearch ile girilen isimi listede arar
                                                                                   // (hızlı bir şekilde, BinarySearch metodunun farkı hızlı olmasıdır.)
                Console.WriteLine("Gelen davetlinin listedeki indeksi: " + giren_davetlinin_indeksi);

            }
            else
            {
                Console.WriteLine(gelenIsim + " haacom, isminiz listede yok. Şu an listeye eklendiniz.");
                davetliler.Add(gelenIsim);

                Console.WriteLine("Güncel davetli listesi:");
                listele(davetliler);
            }


        }
        public static void listele(ArrayList liste)
        {
            for (int i = 0; i < liste.Count; i++)
            {
                Console.WriteLine(i + 1 + ".davetli: " + liste[i]);
            }
        }
    }
}
