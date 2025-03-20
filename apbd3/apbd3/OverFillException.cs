namespace apbd3;

public class OverFillException : Exception
{
    public OverFillException() : base() { }

    public OverFillException(string message) : base(message) { }

    public OverFillException(string message, Exception innerException) : base(message, innerException) { }
}