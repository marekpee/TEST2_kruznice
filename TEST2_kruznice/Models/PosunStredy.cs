namespace TEST2_kruznice.Models
{
    public class PosunStredy
    {
        public PosunStredy()
        {
        }

        public PosunStredy(int polomer, double pozX, double pozY)
        {
            Polomer = polomer;
            PozX = pozX;
            PozY = pozY;
        }

        public int Polomer { get; set; }
        public double PozX { get; set; } = 250;
        public double PozY { get; set; } = 150;
        public int Pocet { get; set; }
        public int Vzdalenost { get; set; }
        public int IndexMazani { get; set; }
    }
}
