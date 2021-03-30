using System;
using System.Collections.Generic;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            string more = "";
            do
            {
                string outUnit = "";
                Console.Write("Please input a measurement type: ");
                string units = Console.ReadLine();
                Console.Write("Please input an amount: ");
                double amt = double.Parse(Console.ReadLine());
                if (units.ToLower().StartsWith("inch"))
                {
                    amt *= 3.5;
                    if(amt!=1)
                    {
                        outUnit = "fidget spinners";
                    }
                    else
                    {
                        outUnit = "fidget spinner";
                    }
                }
                else if (units.ToLower().StartsWith("fidget spinner"))
                {
                    amt /= 3.5;
                    if (amt != 1)
                    {
                        outUnit = "inches";
                    }
                    else
                    {
                        outUnit = "inch";
                    }
                }
                else if (units.ToLower().StartsWith("meme"))
                {
                    amt /= 5.0;
                    if (amt != 1)
                    {
                        outUnit = "feet";
                    }
                    else
                    {
                        outUnit = "foot";
                    }
                }
                else
                {
                    amt *= 5.0;
                    if (amt != 1)
                    {
                        outUnit = "memes";
                    }
                    else
                    {
                        outUnit = "meme";
                    }
                }
                Console.WriteLine(amt.ToString() + " " + outUnit);
                Console.Write("Do you wish to do another calculation? ");
                more = Console.ReadLine();
            } while (String.Equals(more, "yes", StringComparison.OrdinalIgnoreCase));
        }
    }
}
