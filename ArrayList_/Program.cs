using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayList_
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList bir koleksiyon tipidir.Birden fazla veri tipini içinde barındırabilir.Tam bunun karşılığı ArrayList
            ArrayList liste =new ArrayList();
            
            liste.Add("Ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            //içerisindeki verilere nasıl erişebiliriz.
            //index ile erişim
            Console.WriteLine(liste[1]);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //ArrayListte kullanabileceğimiz metotlar

            //AddRange 
            //Birden fazla elemanı toplu halde nasıl ekleyebiliriz.
            Console.WriteLine("***** Add Range *****");
  
            String[] renkler={"Kırımızı","Sarı","yesil"};
            List<int> sayilar = new List<int>(){1,8,3,7,9,92,5};
            liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Sort veri tipleri aynıysa sıralar yoksa patlar.
            Console.WriteLine("*****Sort*****");
           // liste.Sort();

           //BinarySearch
           //önce sırala sonra BinarySearch ile indexine eriş
            Console.WriteLine("***** Binary Search*****");
           // Console.WriteLine(liste.BinarySearch(9));

            //Reverse 
            //ortasından aynalar ensondaki en başa en baştaki en sona
            Console.WriteLine("**** Reverse ****");
            liste.Reverse();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //clear
            liste.Clear();

             foreach (var item in liste)
            {
                Console.WriteLine(item);
            }


            



        }
    }
}
