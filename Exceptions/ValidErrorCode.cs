using System.Net;

namespace CleanWebAPI.Exceptions
{
    public sealed class ValidErrorCode
    {
        public static HttpStatusCode GetErrorCode(Exception exception)
        {
            switch (exception)
            {
                case BadRequestException _:
                    return HttpStatusCode.BadRequest;
                case NotFoundException _:
                    return HttpStatusCode.NotFound;
                case UnauthorizedAccessException _:
                    return HttpStatusCode.Unauthorized;
                default: return HttpStatusCode.InternalServerError;
            }

        }
    }
}
