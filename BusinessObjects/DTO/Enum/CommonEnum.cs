using System.Net;

namespace Domain.Constants
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseStatus
    {
        Success = HttpStatusCode.OK,
        BadRequest = HttpStatusCode.BadRequest,
        Unauthorized = HttpStatusCode.Unauthorized,
        Forbidden = HttpStatusCode.Forbidden,
        NotFound = HttpStatusCode.NotFound,
        InternalServerError = HttpStatusCode.InternalServerError,
    }

    /// <summary>
    /// Enum loại file
    /// </summary>
    public enum EnumFileType
    {
        Temp = 0,
        Jewellery = 1,
    }

    public enum AppRole
    {
        Admin = 1,
        Manager = 2,
        Staff = 3,
    }
}
