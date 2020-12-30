namespace ZalikD
{
    public class Numerals:Rows
    {
        public Numerals(string row) : base(row)
        {
        }

        public override int length()
        {
            return base.length();
        }

        public virtual string replace()
        {
            string symbol = "3";
            string newSymbol = "11";
            return base.replace(symbol, newSymbol);
        }
    }
}