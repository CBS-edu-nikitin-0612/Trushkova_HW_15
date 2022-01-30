// See https://aka.ms/new-console-template for more information


using Trushkova_HW_15;

Console.WriteLine("Hello, Teacher!");
Console.WriteLine("\ndoc file:");
AbstractHandler doc = new DOCHandler();
doc.Create();
doc.Open();
doc.Change();
doc.Save();
Console.WriteLine("\nxml file:");
AbstractHandler xml = new XMLHandler();
xml.Create();
xml.Open();
xml.Change();
xml.Save();
Console.WriteLine("\ntxt file:");
AbstractHandler txt = new TXTHandler();
txt.Create();
txt.Open();
txt.Change();
txt.Save();
