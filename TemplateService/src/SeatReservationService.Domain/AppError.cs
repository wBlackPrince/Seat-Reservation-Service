namespace SeatReservationService.Domain;

public sealed class AppError
{
    public string Message { get; set; }
    
    public int Code { get; set; }

    public string Details { get; set; }

    public AppError(string message, int code, string details)
    {
        Message = message;
        Code = code;
        Details = details;
    }

    public static AppError Conflict(string message, string details)
    {
        return new AppError(message, 503, details);
    }

    public static AppError Validation(string message, string details)
    {
        return new AppError(message, 400, details);
    }
}

