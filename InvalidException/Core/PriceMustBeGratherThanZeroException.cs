namespace Core
{
    public class PriceMustBeGratherThanZeroException : Exception
    {
        public PriceMustBeGratherThanZeroException(string? message) : base(message)
        {
        }
    }
}
