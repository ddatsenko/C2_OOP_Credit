namespace ZalikD
{
    public class Symbols:Rows
    {
        public Symbols(string row):base(row) {}
        
        public override int length()
        {
            return base.length();
        }

        public virtual string replace()
        {
            string symbol = "#";
            string symbol2 = "!!";
            return base.replace(symbol, symbol2);
        }
    }
}