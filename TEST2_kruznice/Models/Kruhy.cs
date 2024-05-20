namespace TEST2_kruznice.Models
{
    public class Kruhy
    {
        public List<PosunStredy> KruzniceList {  get; set; } = new List<PosunStredy>();
        public PosunStredy PosunStredy { get; set; } = new PosunStredy();
        public void PridejKruznice()
        {
            for (int i = 0; i < PosunStredy.Pocet; i++)
            {
                var pomX = PosunStredy.PozX;
                var pomY = PosunStredy.PozY + i * PosunStredy.Vzdalenost;
                KruzniceList.Add(new PosunStredy(PosunStredy.Polomer,pomX,pomY));
            }
        }
        public void SmazatVse()
        {
            KruzniceList.Clear();
        }
        public void SmazatIndex()
        {
            KruzniceList.RemoveAt(PosunStredy.IndexMazani-1);
        }
    }
}
