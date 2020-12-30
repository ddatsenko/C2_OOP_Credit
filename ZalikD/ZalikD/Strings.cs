namespace ZalikD
{
    public abstract class Rows
    {
        protected string row;

        public string Row
        {
            get => row;
            set => row = value;
        }

        protected Rows(string row)
        {
            this.row = row;
        }

        public virtual int length()
        {
            return row.Length;
        }

        public virtual string replace(string symbol,string newSymbol)
        {
           return row.Replace(symbol,newSymbol);
        }

    }
}