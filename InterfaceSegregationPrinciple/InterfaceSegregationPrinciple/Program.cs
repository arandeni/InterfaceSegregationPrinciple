// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using InterfaceSegregationPrinciple;

HPLaserJetPrinter hPLaserJetPrinter = new HPLaserJetPrinter();
hPLaserJetPrinter.Print("Printing");
hPLaserJetPrinter.Scan("Scanning");
hPLaserJetPrinter.Fax("Faxing");
hPLaserJetPrinter.PrintDuplex("PrintDuplex");

LiquidInkjetPrinter liquidInkjetPrinter = new LiquidInkjetPrinter();
liquidInkjetPrinter.Print("Printing");
liquidInkjetPrinter.Scan("Scanning");
