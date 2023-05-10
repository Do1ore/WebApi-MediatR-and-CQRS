namespace CleanWebAPI.Exceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException(object data)
           : base($"Input \"{data}\" is not valid.") { }
    }
}
