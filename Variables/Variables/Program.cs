﻿using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 5;  //1 byte
            sbyte c = 5; //1 byte 

            short s = 5; //2 byte
            ushort us = 5; //2 byte

            Int16 i16 = 2; //2 byte
            int i = 2; //4 byte
            Int32 i32 = 2; //4 byte
            Int64 i64 = 2; //8 byte

            uint ui = 2; //4 byte
            long l = 4; //8 byte
            ulong ul = 4; //8 byte

            //reel sayılar
            float f = 5; //4 byte
            double d = 5; //8 byte
            decimal de = 5; //16 byte

            char ch = '2'; //2 byte
            string str = "Alican Kesen";

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;

            object o1 = 1;
            object o2 = "a";

            string str1 = string.Empty;
            string name = "deniz berke";

            bool bool1 = 10 < 2;

            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);

            int intdeger = int20 + Convert.ToInt32(str20);
            Console.WriteLine(intdeger);
        }
    }
}
