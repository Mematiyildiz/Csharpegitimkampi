﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");
            //Console.WriteLine("***** Yemek Kategorileri");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region  String Değişkenler
            //string
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Murat";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string custemerPhone;
            //string custemerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //custemerPhone = "+90 500 400 30 20";
            //custemerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";
            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("Müşteri: " + customerName +" " + customerSurname);
            //Console.WriteLine("İletişim:" + custemerPhone);
            //Console.WriteLine("Email Adresi:"+ custemerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("--------------------------------");


            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //custemerPhone = "+90 400 300 80 70";
            //custemerEmail = "testQgnail.com";
            //district = "Sapanca";
            //city = "Sakarya";
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + custemerPhone);
            //Console.WriteLine("Email Adresi:" + custemerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("--------------------------------");
            #endregion

            #region Int Değişkenler

            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("---- Hamburger: " + hamburgerPrice + "TL");;
            Console.WriteLine("---- Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("---- Kola: " + cokePrice + "TL");
            Console.WriteLine("---- Limonata: " + lemonadePrice + "TL");
            Console.WriteLine("---- Kızartma: " + friesPrice + "TL");
            Console.WriteLine("---- Su: " + waterPrice + "TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();


            int hamburgerCount;
            int cokeCount;  
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;


            int totalHamburgerPrice ;
            int totalCokePrice ;
            int totalWaterPrice ;
            int totalFriesPrice ;
            int totalPizzaPrice ;
            int totalLemonadePrice ;

            hamburgerCount= 3;
            cokeCount= 3;
            waterCount= 3;
            friesCount= 1;
            pizzaCount= 0;
            lemonadeCount= 0;
            totalHamburgerPrice = hamburgerCount*hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;

           Console.WriteLine("-------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice +"TL");
            Console.WriteLine("Pizza Tutarı : " + totalPizzaPrice + "TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + "TL");
            Console.WriteLine("kola Tutarı: " + totalCokePrice + "TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + "TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + "TL");

            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalPizzaPrice + totalFriesPrice + totalLemonadePrice + totalWaterPrice + totalCokePrice;
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + "TL");










            #endregion

            Console.Read();


        }
    }
}


 
