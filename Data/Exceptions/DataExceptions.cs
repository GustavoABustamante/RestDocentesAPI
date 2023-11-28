namespace RestDocentesAPI.Data.Exceptions
{
    public class DataExceptions : Exception
    {
        public DataExceptions(string? message) : base(message) { }
        public DataExceptions(string? message, DataExceptions innerException) : base(message, innerException) { }
    }
}
