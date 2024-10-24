namespace Core
{
    public class PriceMustBeGratherThanZeroException : Exception
    {
        public PriceMustBeGratherThanZeroException(string? message) : base("0dan kicik ola bilmez!")
        {
        }
    }
}
