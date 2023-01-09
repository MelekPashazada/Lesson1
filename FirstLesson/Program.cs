
////////c# output
//////using System.Drawing;
//////using System.Security.Cryptography.X509Certificates;

////////Console.WriteLine("Hello, World!");

////////Console.WriteLine(3 + 3); //toplama

////////multiline comment
///////*
////// * 
////// * 
//////*/

////////Comments


//////float y = 3.14f;
//////double z = 3.14;
//////char ch = 'M';
//////string str= "1";
////////int bir = 1;
//////bool bl = true;
//////bool bl1 = false;




////////int 4 byte
////////float 4 byte
////////long 8 byte
////////double
////////char
////////string
////////bool

////////constants
//////const double pi = 3.14;

////////display variables

//////int x = -5;
//////int u = 33;
//////int m = 55;
//////long l = 4;

////////Console.WriteLine(x+u);

////////multiple variables

//////string name = "Melek";
//////string surname = "Pasazade";

////////Baki Azerbaycanin paxtaxtidir
//////string seher = "Baki";
//////string olke = "Azerbaycan";
////////Console.WriteLine(seher+" "+olke,"in paxtaxtidir");


////////Meleyin yasi 23-dur
//////string ad = "Melek";
//////int age =23;
////////Console.WriteLine(name);

////////type casting
//////double db = 1;
//////double db1 = 3.1;

////////int i= 1;

////////double db2 = i;

////////Console.WriteLine("i deyiseninin deyeri=" + i + "\n" +
////////    "db2 deyiseninin deyer=" + db2);
////////Implicit Casting
////////int myInt = 9;
////////double myDouble = myInt;       // Automatic casting: int to double

//////////Console.WriteLine(myInt);      // Outputs 9
//////////Console.WriteLine(myDouble);   // Outputs 9

//////////double d = 2.7;
//////////int i = (int) d;

//////////Console.WriteLine("d deyisenin deyeri=" + d + "\n" +
//////////    "i deyiseninin deyeri="+ i );

//////////Explicit Casting
//////////double myDouble = 9.78;
//////////int myInt = (int)myDouble;    // Manual casting: double to int

//////////Console.WriteLine(myDouble);   // Outputs 9.78
//////////Console.WriteLine(myInt);      // Outputs 9


//////////Type Conversion Methods

////////int i = 1;
////////double d = 1.1;
////////string str1 = "1";


////////int.Parse(str);

////////Console.WriteLine( Convert.ToString(i));
////////Console.WriteLine( Convert.ToInt32(d));

////////string truefalse = "false";
////////string falsetrue = "true";
//////////bool bl12 = false;

////////Console.WriteLine(Convert.ToBoolean(truefalse));




////////LESSON 2

////////User Input

////Console.WriteLine("Adinizi daxil edin: ");

////string name= Console.ReadLine();

////Console.WriteLine("Xosgeldiniz " + name);

//////Arithmetic operators

//int a = 1;
////int b = 5;

////int cem = a + b;
////int ferq = b - a;
////int hasil = a * b;
////int qismet = b / a;
////int qaliq = b % a;

////a = a + 1;

////a++;
////a--;
////++a;
////--a;
//////menimsetme operatorları

////int x = 5;

////Console.WriteLine(x);

////x += 3;
////x = x + 3;

////x -= 5;
////x *= 5;
////x /= 5;
////x %= 5;

//////müqayisə operatorları
//int eded1 = 5;
//int eded2 = 5;

//Console.WriteLine(eded1 > eded2);
//Console.WriteLine(eded2 < eded1);
//Console.WriteLine(eded1 >= eded2);
//Console.WriteLine(eded2 <= eded1);
//Console.WriteLine(eded1 != eded2);
//Console.WriteLine(eded1 == eded2);

////mentiqi operatorlar
////&&

////||

////!true

//int maximum= Math.Max(5,10);
//int minumum = Math.Max(5, 10);
//double kokalti = Math.Sqrt(16);

//Console.WriteLine(kokalti);
//Console.WriteLine(Math.Abs(-5));
//Console.WriteLine(Math.Round(3.14));

//strings

//string s = "Salam";
//string S = "";
//Console.WriteLine(s[3]);
//Console.WriteLine(s.ToLower());
//Console.WriteLine(s.ToUpper());

using System;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Xml.Linq;

string name = "Person1";
string surname = "PersonSurname1";

string username= string.Concat(surname, name);

//Console.WriteLine(name +"\n"+ surname);
//Console.WriteLine(name + "\t" + surname);

//Console.WriteLine($"Xosgeldiniz {name}" );







//Lesson3 



//int a = 4;
//int p = a * 4;
//Console.WriteLine(p);

//for(int i=5; i<8; i=i+2)
//{
//    Console.Write("Fiquru daxil edin: ");
//    string fiqur = Console.ReadLine();
//    if (fiqur == "kvadrat")
//    {
//        Console.WriteLine($"Kvadratin perimetri p={p}");
//    }
//    else if (fiqur == "ucbucaq")
//    {
//        Console.WriteLine($"Ucbucagin perimetri p={a * 3}");
//    }
//    else if (fiqur == "daire")
//    {
//        Console.WriteLine($"Dairenin perimetri p={2 * 3.14 * a}");
//    }
//    else
//    {
//        Console.WriteLine("Daxil etdiyiniz fiqur bazada yoxdur");
//    }

//}

//for (int i=0;i<=5;++i)
//{
//    Console.WriteLine(i);
//}
//int heteningunleri = int.Parse( Console.ReadLine());

//switch (heteningunleri)
//{
//    case 1:
//        Console.WriteLine("Bazar ertesidir");
//        break;
//    case 2:
//        Console.WriteLine("Cersenbe axsamidir");
//        break;
//    case 3:
//        Console.WriteLine("Cersenbedir");
//        break;
//}




//voteinAge

//int votingAge = 18;
//int age = 5;
//if (age >= votingAge)
//{
//    Console.WriteLine("You can vote");
//}
//{
//    Console.WriteLine("You cannot vote");
//}

//good day

//ternary operator
//variable = (condition) ? expressionTrue :  expressionFalse;

//int a = int.Parse( Console.ReadLine());
//string deyisen = (a >= 3) ? "a 3-den boyukdur " : "a 3-den boyuk deyil";
//Console.WriteLine(deyisen);



//switch (expression)
//{
//    case x:
//        // code block
//        break;
//    case y:
//        // code block
//        break;
//    default:
//        // code block
//        break;
//}

//int i = 0;
//while (i<5)
//{
//    Console.WriteLine(i);
//    ++i;
//}


//int i = 5;
//while (i > 10)
//{
//    Console.WriteLine("--");
//    i++;
//}

//int i = 4;
//do
//{
//    Console.WriteLine(i);
//    i--;
//}
//while (i>10);


//do
//{
//    Console.WriteLine($"{i}- condition");
//    i++;
//}
//while (i<10);

//Lesson3 repeat

//string day = Console.ReadLine();
//switch (day)
//{
//    case "Bazar ertesi":
//        Console.WriteLine("1");
//        break;
//    case "Thursday":
//        Console.Write("2");
//        break;

//}

//int year = 1;
//if ()
//{
//}

//1 ~ 1924,1936,1948,1960,1972,1984,1996,2008---------------12-ə bolunəndə qaliq 4+9
//2 Öküz 1925,1937,1949,1961,1973,1985,1997,2009
//3 Peleng 1926,1938,1950,1962,1974,1986,1998,2010
//4 Dovşan 1927,1939,1951,1963,1975,1987,1999,2011
//5 Ejdaha 1928,1940,1952,1964,1976,1988,2000,2012
//6 İlan 1929,1941,1953,1965,1977,1989,2001,2013
//7 At 1930,1942,1954,1966,1978,1990,2002,2014
//8 Qoyun 1931,1943,1955,1967,1979,1991,2003,2015
//9 Meymun 1932,1944,1956,1968,1980,1992,2004,2016 -----------12-ə tam bolunenler qaliq 0+9
//10 Toyuq(Xoruz)1933,----------------------------------------12-ə bolunəndə qaliq 1 qalir+9
//11 İt 1934,1946,1958,1970,1982,1994,2006,2018---------------12-ə bolunəndə qaliq 2- qalir+9
//12 Qaban 1935,1947,1959,1971,1983,1995,2007,2019)-----------12-ə bolunəndə qaliq 3+9

//Console.WriteLine("Zehmet olmasa dogum ilinizi qeyd edin: ");
//int year = int.Parse( Console.ReadLine());
//int a = year % 12+9;

//if (a > 12)
//{
//    a = a - 12;
//}

//switch (a)
//{
//    case 1:
//        Console.WriteLine("sican");
//        break;
//    case 2:
//        Console.WriteLine("okuz");
//        break;
//    case 3:
//        Console.WriteLine("peleng");
//        break;
//    case 4:
//        Console.WriteLine("dovsan");
//        break;
//    case 5:
//        Console.WriteLine("ejdaha");
//        break;
//    case 6:
//        Console.WriteLine("ilan");
//        break;
//    case 7:
//        Console.WriteLine("at");
//        break;
//    case 8:
//        Console.WriteLine("qoyun");
//        break;
//    case 9:
//        Console.WriteLine("meymun");
//        break;
//    case 10:
//        Console.WriteLine("toyuq");
//        break;
//    case 11:
//        Console.WriteLine("it");
//        break;
//    case 12:
//        Console.WriteLine("qaban");
//        break;

//}


//int say = 0;
//for (int i = 1999; i < 2023; i++){
//   int  b = i % 4;
//    if (b == 0)
//    {
//        say++;
//    }
//}

//Console.WriteLine(say);






//Lesson4

//encapsulation
//Public
//Private
//Protected
//Internal
//Protected internal

//Methods

//< Access Specifier > < Return Type > < Method Name > (Parameter List) {
//    Method Body
//}

//nullable

//arrays

//strings


