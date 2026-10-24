namespace SeatReservationService.Domain;

public class VenueEventDetails
{
    public VenueEventDetails(int capacity, string description)
    {
        Capacity = capacity;
        Description = description;
    }

    public Guid VenueEventId { get; } = Guid.Empty;

    public int Capacity { get; private set; }

    public string Description { get; private set; }
}

