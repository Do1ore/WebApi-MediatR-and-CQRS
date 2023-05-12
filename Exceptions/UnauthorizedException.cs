namespace CleanWebAPI.Exceptions
{
    public class UnauthorizedException : Exception
    {
        public UnauthorizedException()
          : base($"You don't have access") { }
    }
}
