using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_12_GrupA_Uygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
Bir sayı listesi üzerinde analiz yaptığınızı varsayarak aşağıdaki işlemleri sırasıyla gerçekleştiren bir C# programı yazınız:

Çalışma Mantığı:

1. sayilar isminde bir ArrayList oluşturun ve listeye 45, 12, 88, 3, 25 sayılarını ekleyiniz.

2. Listeyi küçükten büyüğe sıralayınız.

3. Sıralanmış listenin 3.elemanı olarak 50 sayısını Insert metodu ile ekleyiniz.

4. Listeden 12 değerini Remove metodu ile siliniz.

5. Listenin içinde 88 sayısının bulunup bulunmadığını Contains ile kontrol ederek ekrana “Var” veya “Yok” yazdırınız.

6. Son olarak listenin son halini Reverse metodu ile ters çevirip tüm elemanları ekrana yazdırınız.*/

            ArrayList sayilar = new ArrayList();
            sayilar.Add(45); // diziye veri ekler.
            sayilar.Add(12);
            sayilar.Add(88);
            sayilar.Add(3);
            sayilar.Add(25);
            Console.WriteLine("Liste:");
            for (int i = 0; i < sayilar.Count; i++)
                Console.WriteLine(i + 1 + ". sayı = " + sayilar[i]);

            sayilar.Sort(); // Diziyi  küçükten büyüğe sıralar.
            Console.WriteLine("Küçükten büyüğe:");
            for (int i = 0; i < sayilar.Count; i++)
                Console.WriteLine(i + 1 + ". sayı = " + sayilar[i]);


            sayilar.Insert(2, 50); // Diziyi 3.sırasına (2. indeks) 50 değerini ekler.
            Console.WriteLine("50 değerinin eklenmiş haliyle:");
            for (int i = 0; i < sayilar.Count; i++)
                Console.WriteLine(i + 1 + ". sayı = " + sayilar[i]);


            sayilar.Remove(12); // 12 değerini diziden siler.
            Console.WriteLine("12 değerinin silinmiş haliyle:");
            for (int i = 0; i < sayilar.Count; i++)
                Console.WriteLine(i + 1 + ". sayı = " + sayilar[i]);


            bool kontrol = sayilar.Contains(88); // dizide 88 değerinin olup olmadığını sorgular varsa true yoksa false döndürür.

            // hiçbir operatör yazmazsanız girilen verinin içinde (kontrol == true) olarak algılar ve ona göre sorgu işlemi yapar.
            // if bloğunun altına tek satırlık kod yazacaksanız süslü parantez ile blok olarak içine almaya gerek kalmaz.
            if (kontrol)
                Console.WriteLine("+88 değeri dizide var.");
            else
                Console.WriteLine("- 88 değeri dizide yok.");





        }

        public static void diziDondur(ArrayList liste) //  bu metot sayesinde dizinin içindeki her veriyi yazdırmak yerine sadece bu metodu kullanarak değerleri yazdırabilicez.
        { // isterseniz metot oluşturup yazın isterseniz pratik amaçlı for döngüsünü yazabilirsiniz.
          // Kullanmak için for döngülerinin yerine bu metodu diziDondur(sayilar) şeklinde yazın,
          // Onun dışında amele olursunuz. :D
            for (int i = 0; i < liste.Count; i++)
            {
                Console.WriteLine($"{i + 1}.değer = {liste[i]}");
            }
        }
    }
    
}
