using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kugelschreiber
{
    class CKugelschreiber
    {
        private bool Mienenstellung;
        private int Tintenstand;

        public void set_Mienenstellung(bool M) { Mienenstellung = M; }
        public bool get_Mienenstellung() { return Mienenstellung; }
        public void set_Tintenstand(int T)
        {
            if (T >= 0 && T <= 100)
                Tintenstand = T;
        }
        public int get_Tintenstand() { return Tintenstand; }
        public void Kappe_drehen()
        {
            if (Mienenstellung == true)
                Mienenstellung = false;
            else
                Mienenstellung = true;
        }
        public bool schreiben(int lang)
        {
            if (Mienenstellung == false)
                return false;
            else
            {
                if(Tintenstand >= lang)
                {
                    Tintenstand = Tintenstand - lang;
                    return true;
                }
                else
                {
                    Tintenstand = 0;
                    return false;
                }
            }
        }
    }
}
