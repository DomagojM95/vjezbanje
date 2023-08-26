
namespace VjezbanjeEKstenzije
{
    public static class Ekstenzija
    {
        public static int brojPonavljanja(this string s, char z)
        {
            int broj = 0;
          
            foreach (char k in s) 
            {
                if (k == z)
                {
                    broj++;
                }
            }
            return broj;

        }
        public static void OdradiPosao(this ISucelje sucelje)
        {
            sucelje.Posao();
        }
    }
}
