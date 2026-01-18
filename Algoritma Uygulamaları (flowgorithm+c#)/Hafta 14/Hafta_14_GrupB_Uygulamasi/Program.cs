using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_14_GrupB_Uygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int girilenSayi; // kullanıcıdan alınacak sayıları tutar.
            int sayiAdedi; // dizideki sayı adedini belirler.
            int bozulmasini_saglayan_indeks = 0; // dizi simetrik değilse hangi indekste bozulduğunu gösterir.
            int ciftSayisi = 0; // dizi simetrikse kaç adet çifti olan sayı olduğunu gösterir.
            bool simetrikMi = false; // simerik olup olmadığını anlamamızı sağlar.

            Console.Write("Kaç adet sayı gireceksin yaz bakam dost:");
            sayiAdedi = Convert.ToInt16(Console.ReadLine());

            int[] simetrikDizi = new int[sayiAdedi];

            for (int i = 0; i < sayiAdedi; i++)
            {
                Console.Write(i + 1 + ". sayıyı gir: ");
                girilenSayi = Convert.ToInt32(Console.ReadLine());
                simetrikDizi[i] = girilenSayi;

            }

            // MANTIĞI ANLAMADIYSAN YORUM SATIRLARINI OKUMALISIN (OKUDUĞUNDA DA ANLAMADIYSAN GPT DAYI SANA YARDIMCI OLUR :D)


            int sonIndex = sayiAdedi - 1;  // diziler 0. indeksten başladığından sayiAdedi -1 yaptık ki hata vermesin.
                                           // sonIndex değerini almamızın sebebi de baştan ve sondan değerler kıyaslamamız olacak.

            // Örnek olarak ==>  dizi adında bir dizimiz olsun ve değerleri [1,2,3,2,1] olsun. 
            // Bir dizi eğer simetrikse yarısını aldığımızda  birbirine eşit olması gerekir.
            // Biz de dizinin başındaki ve sonundaki değerleri karşılaştırıyoruz, eğer bu değerler birbirine eşitse SİMETRİK, değilse SİMETRİK OLMADIĞINI anlayabiliyoruz.
            // dizi[0] == dizi[4] >> 1=1
            // dizi[1] == dizi[3] >> 2==2
            // dizi[2]==[dizi[2] >> 3==3   OLUR.
            // BU DEĞERLERİ for döngüsüyle her bir değişkeni karşılaştırarak SİMETRİK dizi olup olmadığını belirliyicez.

            // for döngüsünün sınırını (sayiAdedi/2) ikiye bölmemizin sebebi: Dizi simetrikse zaten sağdan ve soldan baktığımızda okunuşu aynı olur bu yüzden soldaki değeri okuduğumuzda
            // sağdaki değeri de okumuş sayılıyoruz >>  1 2 1 2 1 tersten >> 1 2 1 2 1 
            // Bu yüzden döngüyü fazladan çalıştırmaya gerek yok, sınırı ikiye bölersek sonuca daha hızlı ulaşırız.
            for (int i = 0; i < (sayiAdedi / 2); i++)  // 1 2 1 2 1
            {
                if (simetrikDizi[i] == simetrikDizi[sonIndex - i]) // Burada baştan ve sondan değerleri karşılaştırıyoruz ( simetrikDizi[0} == simetrikDizi[4])
                {
                    simetrikMi = true; // simetrikse true
                    ciftSayisi++; // simetrikse cifti olan sayı adedi
                }
                else
                {
                    simetrikMi = false; // simetrik değilse false
                    bozulmasini_saglayan_indeks = i; // simetrik değilse hangi indekste bu simetri bozulmuş onu buluyoruz.


                }


            }

            if (simetrikMi)
            {
                Console.WriteLine("Bu dizi SİMETRİK bir dizidir.\n" +
                    "Simetrik çift sayısı: " + ciftSayisi);

            }
            else
                Console.WriteLine("Bu dizi SİMETRİK DEĞİLDİR.\n" +
                    "Simetriyi bozan ilk indeks: " + bozulmasini_saglayan_indeks);


        }
    }
}
