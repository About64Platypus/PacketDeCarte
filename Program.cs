using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacketDeCarte
{
    class Program
    {
        static void Main(string[] args)
        {
            CDeck Packet = new CDeck();
            List<CCard> Deck = Packet.AccesorDeck; 

            for( int i = 0;i < Deck.Count; i++)
            {
                Console.WriteLine(Deck[i].AccesorName);
              
            }
            Console.ReadKey();

            
        }
    }
}
