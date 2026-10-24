namespace SeatReservationService.Domain;

public class ReservationSeat
{
    public ReservationSeat(Guid id, Reservation reservation, Guid seatId)
    {
        Id = id;
        Reservation = reservation;
        SeatId = seatId;
        ReservedAt = DateTimeOffset.UtcNow;
    }

    public Guid Id { get; }

    public Reservation Reservation { get; private set; }

    public Guid SeatId { get; private set; }

    public DateTimeOffset ReservedAt { get; }
}

