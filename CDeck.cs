using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacketDeCarte
{
    class CDeck
    {
        CCard[] m_Cards;
        List<CCard> m_Deck;

        public CDeck()
        {
            m_Cards = new CCard[52];

            m_Cards[0] = new CCard("0H", 1,11);
            m_Cards[1] = new CCard("1H", 2);
            m_Cards[2] = new CCard("2H", 3);
            m_Cards[3] = new CCard("3H", 4);
            m_Cards[4] = new CCard("4H", 5);
            m_Cards[5] = new CCard("5H", 6);
            m_Cards[6] = new CCard("6H", 7);
            m_Cards[7] = new CCard("7H", 8);
            m_Cards[8] = new CCard("8H", 9);
            m_Cards[9] = new CCard("9H", 10);
            m_Cards[10] = new CCard("JH", 10);
            m_Cards[11] = new CCard("QH", 10);
            m_Cards[12] = new CCard("KH", 10);

            m_Cards[13] = new CCard("0S", 1, 11);
            m_Cards[14] = new CCard("1S", 2);
            m_Cards[15] = new CCard("2S", 3);
            m_Cards[16] = new CCard("3S", 4);
            m_Cards[17] = new CCard("4S", 5);
            m_Cards[18] = new CCard("5S", 6);
            m_Cards[19] = new CCard("6S", 7);
            m_Cards[20] = new CCard("7S", 8);
            m_Cards[21] = new CCard("8S", 9);
            m_Cards[22] = new CCard("9S", 10);
            m_Cards[23] = new CCard("JS", 10);
            m_Cards[24] = new CCard("QS", 10);
            m_Cards[25] = new CCard("KS", 10);

            m_Cards[26] = new CCard("0D", 1, 11);
            m_Cards[27] = new CCard("1D", 2);
            m_Cards[28] = new CCard("2D", 3);
            m_Cards[29] = new CCard("3D", 4);
            m_Cards[30] = new CCard("4D", 5);
            m_Cards[31] = new CCard("5D", 6);
            m_Cards[32] = new CCard("6D", 7);
            m_Cards[33] = new CCard("7D", 8);
            m_Cards[34] = new CCard("8D", 9);
            m_Cards[35] = new CCard("9D", 10);
            m_Cards[36] = new CCard("JD", 10);
            m_Cards[37] = new CCard("QD", 10);
            m_Cards[38] = new CCard("KD", 10);

            m_Cards[39] = new CCard("0C", 1, 11);
            m_Cards[40] = new CCard("1C", 2);
            m_Cards[41] = new CCard("2C", 3);
            m_Cards[42] = new CCard("3C", 4);
            m_Cards[43] = new CCard("4C", 5);
            m_Cards[44] = new CCard("5C", 6);
            m_Cards[45] = new CCard("6C", 7);
            m_Cards[46] = new CCard("7C", 8);
            m_Cards[47] = new CCard("8C", 9);
            m_Cards[48] = new CCard("9C", 10);
            m_Cards[49] = new CCard("JC", 10);
            m_Cards[50] = new CCard("QC", 10);
            m_Cards[51] = new CCard("KC", 10);

            m_Deck = new List<CCard>();
            Shuffle();
        }

        public List<CCard> Shuffle()
        {
            Random RNGesus = new Random(DateTime.Now.Millisecond);
            int random;

            m_Deck.Add(m_Cards[0]);

            for (int i = 1; i < m_Cards.Length ;i++)
            {
                random = RNGesus.Next(0, m_Deck.Count);
                
                m_Deck.Insert(random, m_Cards[i]);
            }
            random = RNGesus.Next(0, m_Deck.Count);

            CCard DerniereCarte = new CCard();
            DerniereCarte = m_Deck[m_Deck.Count-1];
            m_Deck.Remove(DerniereCarte);

            m_Deck.Insert(random, DerniereCarte);

            return m_Deck;


        }

       public List<CCard> AccesorDeck
        {
            get
            {
                return m_Deck;
            }
        }


    }
}
