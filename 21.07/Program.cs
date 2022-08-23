using System;

namespace std;

public class Program
{
    static void Main()
    {
        //Program1();
        Program2();
        Console.ReadKey(true);
    }

    static void Program1()
    {
        var testMagazine = new Magazin("Forbs", "2021", "Richest people", "+325398372", "Forbs@gmail.com", 100);
        testMagazine.Out();
        var testMagazine2 = new Magazin();
        testMagazine2.EnterInfo();
        testMagazine2.Out();
    }

    public static void Program2()
    {
        var testShop = new Shop("Puma", "1971",
            "Sport produkt", "+868392953", "puma@gmail.com", 100000);
        testShop.PrintInfo();
    }



}