// See https://aka.ms/new-console-template for more information
using tax_NathiNugget;

Console.WriteLine("Hello, World!");
Tax t = new Tax(Role.Underviser, 20000);
Console.WriteLine(t.TaxToPay);
Tax hight = new Tax(Role.Underviser, 20001);
Console.WriteLine(hight.TaxToPay);