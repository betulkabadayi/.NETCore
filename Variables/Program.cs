// See https://aka.ms/new-console-template for more information
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args){

            byte b = 5; //1 byte

            sbyte sc = 5; //1 byte

            short s = 5; //2 byte
            ushort us = 5; //2 byte

            Int16 i16 = 2; //2 byte
            int inormal = 2; //4 byte
            Int32 i32 = 2; //4 byte
            Int64 i64 = 2; //8 byte

            uint ui = 2; //4 byte
            long l = 4; //8 byte
            ulong ul = 4; //8 byte

            //reel sayılar
            float f = 5; //4 byte
            double d = 5; //8 byte
            decimal de = 5; //16 byte

            char c = '1'; //2 byte
            string str = "Bets"; //sınırsız

            bool boo = true;
            bool boo2 = false;

            DateTime dt = DateTime.Now;

            Console.WriteLine(dt);

            //veritipi bağımsız değer tutar

            object o1 = "strindeger";
            object o2 = 'c';
            object o3 = 2;
            object o4 = 2.1;

            //string ifadeler

            string str1 = string.Empty;
            str1 = "bets";
            string ad = "Betül";
            string soyad = "Altuntas";
            string tamisim = ad+ " "+ soyad;


            //integer tanımlama şekilleri

            int a = 3;
            int ba = 2;
            int multiple = a * ba;


            //boolean

            bool b1 = 10<2;

            //değişken dönüşümleri

            string str20 = "20";
            int in20 = 20;

            string yenideger = str20 + in20.ToString();

            Console.WriteLine(yenideger); //2020

            int in21 = in20 + Convert.ToInt32(str20);

            Console.WriteLine(in21); //40

            int int22 = in20 + int.Parse(str20);

            Console.WriteLine(int22); //40

            string datetimeconv = DateTime.Now.ToString("dd.MM.yyyy");

            Console.WriteLine(datetimeconv); 

            string datetimeconv2 = DateTime.Now.ToString("dd/MM/yyyy");

            Console.WriteLine(datetimeconv2); 

            string hour = DateTime.Now.ToString("HH:mm");

            Console.WriteLine(hour); 

        }
        
    }
  
    
}
