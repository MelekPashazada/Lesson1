
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

using System.Linq.Expressions;

string name = "Person1";
string surname = "PersonSurname1";

string username= string.Concat(surname, name);

//Console.WriteLine(name +"\n"+ surname);
//Console.WriteLine(name + "\t" + surname);

//Console.WriteLine($"Xosgeldiniz {name}" );







//Lesson3 

//string fiqur = "ucbucaq";
//int a = 4;

//if (fiqur == "kvadrat")
//{

//    int p = a * 4;
//    Console.WriteLine(p);

//}
//else
//{
//    int p3 = a * 3;
//    Console.WriteLine(p3);
//}

////1 xetti
////    2 budaqlanan
////    3 dovru


//votinAge

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

//int eded = 1;
//switch (eded)
//{
//    case 1:
//        Console.WriteLine("bir");
//        break;
//    case 2:
//        Console.WriteLine("iki");
//        break;
//    case 3:
//        Console.WriteLine("uc");
//        break;
//}


//int i = 5;
//while (i<10)
//{
//    Console.WriteLine("11");
//    i++;
//}


//do
//{
//    Console.WriteLine($"{i}- condition");
//    i++;
//}
//while (i<10);









