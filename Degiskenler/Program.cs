using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Merhaba");

            byte b = 5; //1byte
            sbyte c = 5; //1byte
            short a = 5; //2 byte 
            ushort d = 5; //2byte

            Int16 i16 = 2; //2byte
            int i = 2; //4byte
            Int32 i32 = 2; //4byte
            Int64 i64 = 2; //8byte
            uint u = 2; //4byte
            long l = 2; //8byte
            ulong ul = 2; //8byte

            //Reel Sayılar
            float f = 5; //4byte
            double dou = 5; //8byte
            decimal de = 5; //16byte


            char ch = '2'; //2byte
            string str = "Volkan"; //sınırsız

            bool bo1 = true;
            bool bo2 = false;

            //DateTime dateTime = DateTime.Now; //O anki tarih saat

            object o1 = "x";
            object o2 = 'y';
            object o3 = 2;
            object o4 = 4.3;

            string str1 = string.Empty;
            string ad = "Volkan";
            string soyad = "Torun";
            string adSoyad = ad + " " + soyad;


            //datetime

            string dateTime1 = DateTime.Now.ToString("dd.MM.yyyy");
            string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy");
            string hour = DateTime.Now.ToString("HH:mm");

            Console.WriteLine(hour);


        }
    }
}
