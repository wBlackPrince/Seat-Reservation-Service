using CSharpFunctionalExtensions;

namespace SeatReservationService.Domain;

public class Venue
{
    private readonly List<Seat> _seats;

    public Venue(Guid id, string name, IEnumerable<Seat> seats)
    {
        Id = id;
        Name = name;
        _seats = seats.ToList();
    }

    public Guid Id { get; }

    public string Name { get; private set; }

    public int SeatsLimit { get; private set; }

    public int SeatsCount => _seats.Count;

    public IReadOnlyList<Seat> Seats => _seats;

    public UnitResult<AppError> AddSeat(Seat seat)
    {
        if (SeatsCount >= SeatsLimit)
            return AppError.Conflict("venue.seats.limit", "");

        _seats.Add(seat);

        return UnitResult.Success<AppError>();
    }

    public void ExpandSeatsLimit(int newSeatsLimit) => SeatsLimit = newSeatsLimit;
}
