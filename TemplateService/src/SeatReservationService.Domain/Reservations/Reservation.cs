namespace SeatReservationService.Domain;


public class Reservation
{
    private readonly List<ReservationSeat> _reservedSeats;

    public Reservation(Guid id, Guid venueEventId, Guid userId, IEnumerable<Guid> seatIds)
    {
        Id = id;
        VenueEventId = venueEventId;
        UserId = userId;
        Status = ReservationStatus.Pending;
        CreatedAt = DateTimeOffset.UtcNow;

        _reservedSeats = seatIds
            .Select(seatId => new ReservationSeat(Guid.NewGuid(), this, seatId))
            .ToList();
    }

    public Guid Id { get; }

    public Guid VenueEventId { get; private set; }

    public Guid UserId { get; private set; }

    public ReservationStatus Status { get; private set; }

    public DateTimeOffset CreatedAt { get; private set; }

    public IReadOnlyCollection<ReservationSeat> Seats => _reservedSeats;
}

