using CSharpFunctionalExtensions;

namespace SeatReservationService.Domain;

public class Seat
{
    public Seat(Guid id, int rowNumber, int seatNumber)
    {
        Id = id;
        RowNumber = rowNumber;
        SeatNumber = seatNumber;
    }

    public Guid Id { get; }

    public int RowNumber { get; private set; }

    public int SeatNumber { get; private set; }

    public static Result<Seat, AppError> Create(int rowNumber, int seatNumber)
    {
        if (rowNumber <= 0 || seatNumber <= 0)
        {
            return AppError.Validation(
                "seat.rowNumber",
                "Row number and seat number must be greater than zero");
        }

        return new Seat(Guid.NewGuid(), rowNumber, seatNumber);
    }
}

