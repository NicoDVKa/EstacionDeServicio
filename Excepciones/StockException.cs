

namespace ModuloSurtidor
{
    public class StockException : Exception
    {

        public StockException(string message) : base(message) { }

        public StockException(string message, Exception inner) : base(message, inner) { }

    }

}
