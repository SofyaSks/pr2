
/*void Metod(ref int a) {
    a++;
    Console.WriteLine(a);
}*/

using refdel;

/*void Method2(int a2) {
    Console.WriteLine("все работает");
}
Method refmethod = Method2;
refmethod(12);*/

void PrintRed(string text) {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine (text);
    Console.ForegroundColor = ConsoleColor.White;
}
PrintRed("color");

void PrintBlue(string text) {
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(text);
    Console.ForegroundColor = ConsoleColor.White;
}
PrintBlue("color");

void PrintGreen(string text) {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(text);
    Console.ForegroundColor = ConsoleColor.White;
}
PrintGreen("color");

void OsnMethod (int p, DelegatePrint DelP) {
    p = p * p;
    DelP(p.ToString());
}
OsnMethod(12, PrintGreen);
OsnMethod(122, PrintRed);
OsnMethod(1222, PrintBlue);

/*void Metodarr(ref int[] arrex) {
    arrex[2]++;
}*/

/*int b = 7;
Metod(ref b);
Console.WriteLine(b);*/

/*int[] arr = { 1, 2, 3};
Metodarr(ref arr);
Console.WriteLine(); */

