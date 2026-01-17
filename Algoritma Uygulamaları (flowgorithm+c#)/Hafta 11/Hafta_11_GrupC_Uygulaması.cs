using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hafta10_GrupA_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int[] tamsayiDizi = new int[10];
            int enKucuk, enBuyuk;

            Console.WriteLine("");
            for (int i = 0; i < tamsayiDizi.Length; i++)
            {

                Console.Write(i + 1 + ". sayıyı gir hocam:");
                int sayi = Convert.ToInt16(Console.ReadLine()); // Kullanıcıdan sayı alıyoruz. Conver.ToInt16() metodu girilen sayının bir tamsayı olması gerektiğini ayarlar.
                
                tamsayiDizi[i] = sayi; // Kullanıcıdan girilen sayıyı diziye  ekliyoruz.
            }

            //Girilen sayıların aralığı belli olmadığından, sayıları girilen ilk iki sayıya atıyoruz.
            enKucuk = tamsayiDizi[0]; 
            enBuyuk = tamsayiDizi[1];
            int enKucuk_indis = 0, enBuyuk_indis = 1; // Aynı şekilde indisleri de ona göre başlangıçta ayarlıyoruz ki eğer en küçük ve en büyük sayıları ilk iki sayıysa;
                                                       // doğru değeri vermiş demektir.

            for (int i = 0; i < tamsayiDizi.Length; i++)
            {
                Console.WriteLine($"{i+1}.sayı = {tamsayiDizi[i]}, indis:{i}");

                // Büyük, küçük sorgularını koşullarla işliyoruz:
                if (tamsayiDizi[i] > enBuyuk)
                {
                    enBuyuk = tamsayiDizi[i];
                    enBuyuk_indis = i;
                }

                else if (tamsayiDizi[i] < enKucuk)
                {
                    enKucuk = tamsayiDizi[i];
                    enKucuk_indis = i;
                }

            }
            Console.WriteLine("--------------------");
            Console.WriteLine($"En küçük sayı ve indisi: {enKucuk}, {enKucuk_indis}\nEn büyük sayı ve indisi: {enBuyuk}, {enBuyuk_indis}");
        }
    }
}
