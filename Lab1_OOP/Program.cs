using Microsoft.VisualBasic;
using System;
using System.Dynamic;
using System.Text;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Введите номер раздела: ");
        int choose = int.Parse(Console.ReadLine());
        switch (choose)
        {
            case 1:
                types();
                break;
            case 2:
                strings();
                break;
            case 3:
                arrays();
                break;
            case 4:
                tuples();
                break;
            case 5:
                localfunc();
                break;
            case 6:
                checkedunchecekd();
                break;
        }




    }
    static void types()
    {

        Console.WriteLine("----------a----------");

        bool boolVar = true;
        byte byteVar = 0;
        sbyte sbyteVar = 0;
        char charVar = '0';
        decimal decimalVar = 0.0m;
        double doubleVar = 0.0d;
        float floatVar = 0.0f;
        int intVar = 0;
        uint uintVar = 0;
        long longVar = 0;
        short shortVar = 0;
        ushort ushortVar = 0;


        // (bool, byte, sbyte, char, decimal, double, float, int, uint, long, short, ushort) tuple= (boolVar:true, byteVar:0, sbyteVar:0,charVar:'0',decimalVar:0.0m, doubleVar:0.0d,floatVar:0.0f, intVar:0, uintVar:0, longVar:0, shortVar:0, ushortVar:0);

        //    string[] arr = { "bool", "byte", "sbyte", "char",  "decimal",  "double",  "float",  "int",  "uint", "long", "short", "ushort" };
        //int count = 0;
        //foreach (string i in arr)
        //    {
        //        Console.WriteLine("Введите значение перменной типа "+ i);
        //    
        //    count++;
        //    }


        Console.WriteLine("Введите значение перменной типа byte");
        byteVar = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Введите значение перменной типа sbyte");
        sbyteVar = Convert.ToSByte(Console.ReadLine());
        Console.WriteLine("Введите значение перменной типа char");
        charVar = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Введите значение перменной типа decimal");
        decimalVar = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Введите значение перменной типа double");
        doubleVar = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перменной типа float");
        floatVar = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Введите значение перменной типа int");
        intVar = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение перменной типа uint");
        uintVar = Convert.ToUInt32(Console.ReadLine());
        Console.WriteLine("Введите значение перменной типа long");
        longVar = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Введите значение перменной типа short");
        shortVar = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Введите значение перменной типа ushort");
        ushortVar = Convert.ToUInt16(Console.ReadLine());

        //}
        //    private static (bool, byte, sbyte, char, decimal, double, float, int, uint, long, short, ushort) GetValue()
        //    {
        //        var result =(bolvar:Console.ReadLine())
        //        return result;
        //    }
        //}

        Console.WriteLine("----------b----------");

        floatVar = intVar;
        floatVar = charVar;
        floatVar = longVar;
        intVar = byteVar;
        longVar = uintVar;

        Console.WriteLine("----------c----------");

        object obj = intVar;
        Console.WriteLine(obj);

        int i = (int)obj;

        Console.WriteLine("----------d----------");

        var x = 1;
        Type varType;
        varType = x.GetType();
        Console.WriteLine(varType.ToString());
        var y = "say hello to my little friend";
        varType = y.GetType();
        Console.WriteLine(varType.ToString());
        var z = true;
        varType = z.GetType();
        Console.WriteLine(varType.ToString());

        Console.WriteLine("----------e----------");

        Nullable<int> nullInt = null;
        int? nullInt2 = null; //сокращенная версия верхней записи

        nullInt = 100;

        Console.WriteLine("----------e----------");

        //var c = 42;
        //c = "str";




    }
    static void strings()
    {
        Console.WriteLine("----------a----------");

        Console.WriteLine(String.Compare("barnyard", "barn"));

        Console.WriteLine("----------b----------");

        string str1 = "Hello, World!";
        string str2 = "Hello, ";
        string str3 = "World!";

        string strConc = str2 + str3;
        Console.WriteLine();
        Console.WriteLine(strConc);
        Console.WriteLine(str2 + str3);

        string substring = str1.Substring(0, 4);


        string[] words = str1.Split(new char[] { ' ' });

        foreach (string s in words)
        {
            Console.WriteLine(s);
        }

        str2 = str2.Insert(6, str3);
        Console.WriteLine(str2);

        str2 = str2.Remove(5, 6);

        int x = 8;
        int y = 7;
        string result = $"{x} + {y} = {x + y}";
        Console.WriteLine(result); // 8 + 7 = 15

        Console.WriteLine("----------c----------");

        string emptystr = "";
        string nullstr = null;

        Console.WriteLine(String.IsNullOrEmpty(emptystr));
        Console.WriteLine(String.IsNullOrEmpty(nullstr));


        Console.WriteLine("----------d----------");

        StringBuilder sb = new StringBuilder("Once upon a time...");



    }
    static void arrays()
    {
        Console.WriteLine("----------a----------");

        int[,] dem2array = new int[3, 3];

        int height = dem2array.GetLength(0);
        int width = dem2array.GetLength(1);

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (i == j)
                {
                    dem2array[i, j] = 1;
                }
                else dem2array[i, j] = 0;
            }
        }


        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write(dem2array[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("----------b----------");

        string[] strarray = { "red", "green", "blue" };

        int length = strarray.GetLength(0);

        Console.Write(length + " ");
        Console.WriteLine();
        for (int i = 0; i < length; i++)

        {
            Console.Write(strarray[i] + " ");
        }

        Console.WriteLine();

        static string[] SetStr(string[] array)
        {
            Console.WriteLine("Введите номер элемента: ");
            int i = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Введите значение элемента: ");
            string word = Console.ReadLine();
            array[i] = word;
            return array;
        }
        strarray = SetStr(strarray);

        for (int i = 0; i < length; i++)
        {
            Console.Write(strarray[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("----------c----------");

        int[][] myArr = new int[4][];
        myArr[0] = new int[2];
        myArr[1] = new int[3];
        myArr[2] = new int[4];


        // Инициализируем ступенчатый массив
        for (int i = 0; i < 2; i++)
        {

            myArr[0][i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        for (int i = 0; i < 3; i++)
        {

            myArr[1][i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        for (int i = 0; i < 4; i++)
        {

            myArr[2][i] = int.Parse(Console.ReadLine());
        }



        for (int i = 0; i < 2; i++)
        {

            Console.Write(myArr[0][i] + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < 3; i++)
        {

            Console.Write(myArr[1][i] + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < 4; i++)
        {

            Console.Write(myArr[2][i] + " ");
        }

        Console.WriteLine("----------d----------");

        var a = new[] { 1, 10, 100, 1000 };
        var b = "Carrot";

    }
    static void tuples()
    {

        (int, string, char, string, ulong) tuple = (18, "Urazov", 'A', "D.", 73);
        Console.WriteLine(tuple.GetType().Name);
        Console.WriteLine(tuple);
        Console.WriteLine(tuple.Item1);
        Console.WriteLine(tuple.Item3);
        Console.WriteLine(tuple.Item4);
        (var a, var b) = ("123", 456);
        Console.WriteLine($"{a} {b}");

        (int a, byte b) left = (6, 10);
        (long a, int b) right = (5, 10);
        Console.WriteLine(left == right);  // output: True
        Console.WriteLine(left != right);
    }
    static void localfunc()
    {

        static (int, int, int, string) localfunc_1(string[] args)
        {
            string str = "Urazov";
            int[] mas = { 1, 2, 4, 5, 6, 7 };
            string First = str.Remove(1);
            int minValue = mas.Min();
            int maxValue = mas.Max();
            int sumValue = mas.Sum();
            var tuple = (minValue, maxValue, sumValue, First);
            return tuple;
        }
    }
    static void checkedunchecekd()
    {
        int ten = 10;
        unchecked
        {
            int i1 = 2147483647 + ten;
            Console.WriteLine(i1);
        }
    }



}
