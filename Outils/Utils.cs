using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToXml.Outils
{
    class Utils
    {
        public static void Banner()
        {
           
            string banner = @"
     ██╗███████╗ ██████╗ ███╗   ██╗    ██╗██╗  ██╗███╗   ███╗██╗     
     ██║██╔════╝██╔═══██╗████╗  ██║   ██╔╝╚██╗██╔╝████╗ ████║██║     
     ██║███████╗██║   ██║██╔██╗ ██║  ██╔╝  ╚███╔╝ ██╔████╔██║██║     
██   ██║╚════██║██║   ██║██║╚██╗██║ ██╔╝   ██╔██╗ ██║╚██╔╝██║██║     
╚█████╔╝███████║╚██████╔╝██║ ╚████║██╔╝   ██╔╝ ██╗██║ ╚═╝ ██║███████╗
 ╚════╝ ╚══════╝ ╚═════╝ ╚═╝  ╚═══╝╚═╝    ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝                                     
_____________________________________________________________________
";



            TextCol(banner + "\n", ConsoleColor.White);
        }

        public static void TextCol(string text, ConsoleColor color)
        {
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}

