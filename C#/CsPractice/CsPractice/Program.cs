using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPractice
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine(MorseCodeDecoder.Decode(".... . -.--   .--- ..- -.. ."));
            //MorseCodeDecoder.Decode(".... . -.--   .--- ..- -.. .");
        }
    }
}
