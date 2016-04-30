using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacketDeCarte
{
    class CCard
    {
        string m_Name;
        string m_PathImage;
        int m_Value;
        int m_Value2;


        public CCard()
        {
            m_Name = "";
            m_PathImage = "";
            m_Value = 0;
            m_Value2 = 0;
        }

        public CCard(string name)
        {
            m_Name = name;
            m_PathImage = "";
            m_Value = 0;
            m_Value2 = 0;
        }

        public CCard(string name,string Path)
        {
            m_Name = name;
            m_PathImage = Path;
            m_Value = 0;
            m_Value2 = 0;
        }

        public CCard(string name, string Path,int value)
        {
            m_Name = name;
            m_PathImage = Path;
            m_Value = value;
            m_Value2 = value;
        }

        public CCard(string name, string Path, int value, int value2)
        {
            m_Name = name;
            m_PathImage = Path;
            m_Value = value;
            m_Value2 = value2;
        }

        public CCard(string name, int value)
        {
            m_Name = name;
            m_PathImage = "";
            m_Value = value;
            m_Value2 = value;
        }

        public CCard(string name, int value, int value2)
        {
            m_Name = name;
            m_PathImage = "";
            m_Value = value;
            m_Value2 = value2;
        }

        public string AccesorName
        {
            get
            {
                return m_Name;
            }
            set
            {
                m_Name = value;
            }
        }

        public string AccesorPathImage
        {
            get
            {
                return m_PathImage;
            }
            set
            {
                m_PathImage = value;
            }
        }

        public int AccesorValue
        {
            get
            {
                return m_Value;
            }
            set
            {
                m_Value = value;
            }
        }

    }
}
