using System;


namespace Lab8_Bartosz_Potyrała
{
    struct Ulamek
    {
        int licznik;
        int mianownik;

        public Ulamek(int inLicznik, int inMianownik)
        {
            licznik = inLicznik;
            mianownik = inMianownik;

            if (inMianownik == 0)
            {
                throw new Exception("Mianownik nie moze wynosić 0");
            }

            Uprosc();
        }
        void Uprosc()
        {
            int nwd = NWD(Math.Abs(licznik), Math.Abs(mianownik));
            licznik /= nwd;
            mianownik /= nwd;
        }
            // nwd - najwiekszy wspolny dzielnik
        int NWD(int a, int b)
        {
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        public override string ToString()
        {
            return (licznik.ToString() + "/" + mianownik.ToString());
        }

        public static Ulamek operator * (Ulamek a, Ulamek b)
        {
            Ulamek toReturn = new Ulamek(a.licznik * b.licznik , a.mianownik * b.mianownik);
            return (toReturn);
        }

        public static Ulamek operator /(Ulamek a, Ulamek b)
        {
            Ulamek toReturn = new Ulamek(a.licznik * b.mianownik, a.mianownik * b.licznik);
            return (toReturn);
        }

        
        public static Ulamek operator + (Ulamek a, Ulamek b)
        {
            Ulamek toReturn = new Ulamek(a.licznik * b.mianownik + b.licznik * a.mianownik , a.mianownik * b.mianownik);
            return (toReturn);
        }
        
        public static Ulamek operator - (Ulamek a, Ulamek b)
        {
            Ulamek toReturn = new Ulamek(a.licznik * b.mianownik - b.licznik * a.mianownik, a.mianownik * b.mianownik);
            return (toReturn);
        }

        public static bool operator == (Ulamek a, Ulamek b)
        {
            return (a.licznik==b.licznik && a.mianownik==b.mianownik);
        }

        public static bool operator !=(Ulamek a, Ulamek b)
        {
            return (a.licznik != b.licznik || a.mianownik != b.mianownik);
        }
    }
}
