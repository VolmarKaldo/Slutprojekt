using System;

namespace sömnprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            string svar = "1";
            string fortsätt = "";

            while (svar != "4")
            {
                fortsätt = "";
                svar = SkrivMeny();
                switch (svar)
                {
                    case "1":
                        System.Console.WriteLine("Du valde alternativ 1");
                        int timmar;
                        string dag = veckodag().ToUpper();
                        while (dag != "MÅNDAG" & dag != "TISDAG" & dag != "ONSDAG" & dag != "TORSDAG" & dag != "FREDAG" & dag != "LÖRDAG" & dag != "SÖNDAG")
                        {
                            System.Console.WriteLine("Vänligen skriv in en veckodag");
                            dag = veckodag().ToUpper();
                        }
                        System.Console.WriteLine(dag);
                        string[] tidDelar = tid();
                        System.Console.WriteLine(timmar);

                        break;
                    case "2":
                        System.Console.WriteLine("Du valde alternativ 2");
                        break;
                    case "3":
                        System.Console.WriteLine("Du valde alternativ 3");
                        break;
                    case "4":
                        System.Console.WriteLine("Du valde alternativ 4");
                        break;
                    default:
                        System.Console.WriteLine("Vänligen skriv in siffran för det alternativ du vill välja.");
                        break;
                }
                while (fortsätt != "N" && fortsätt != "n" && fortsätt != "j" && fortsätt != "J")
                {
                    if (svar != "4")
                    {
                        System.Console.WriteLine("Vill du testa igen?(J/n)");
                        fortsätt = Console.ReadLine();
                        switch (fortsätt)
                        {
                            case "J":
                                break;
                            case "j":
                                break;
                            case "n":
                                svar = "4";
                                break;
                            case "N":
                                svar = "4";
                                break;
                            default:
                                System.Console.WriteLine("Du skrev inte in ett giltligt svar, försök igen");
                                break;
                        }
                    }
                    else
                    {
                        break;
                    }

                }
            }
        }
        static string SkrivMeny()
        {
            //Deklarera variabler
            string svar = "";
            //Gör menyn
            System.Console.WriteLine("Detta är ett program för att räkna ut din sömneffektivitet samt för att hålla koll på hur mycket du sover");
            System.Console.WriteLine("Välj alternativ:");
            System.Console.WriteLine("1. Mata in sömn för en dag");
            System.Console.WriteLine("2. Kolla hur länge du har sovit en dag");
            System.Console.WriteLine("3. Räkna ut din sömneffektivitet");
            System.Console.WriteLine("4. Avsluta");
            svar = Console.ReadLine();
            return svar;

        }
        static string veckodag()
        {
            string dag;
            System.Console.WriteLine("Vilken dag somnade du?");
            dag = Console.ReadLine();
            return dag;

        }
        static string tid()
        {
            int timmar;
            System.Console.WriteLine("Vilken tid gick du och la dig?(hh:mm)");
            string tid = Console.ReadLine();
            string[] tidDelar = tid.Split(":");

            return tidDelar[];
            //while (!int.TryParse(tidDelar[0], out timmar) && timmar <= 00 || timmar > 23)
            //{
            //   System.Console.WriteLine("Fel");
            //}
            //   return timmar;
        }
    }
}