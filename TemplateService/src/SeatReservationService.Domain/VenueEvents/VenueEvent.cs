namespace SeatReservationService.Domain;


public class VenueEvent
{
    public VenueEvent(Guid id, Guid venueId, VenueEventDetails details, string name, DateTimeOffset date)
    {
        Id = id;
        VenueId = venueId;
        Details = details;
        Name = name;
        EventDate = date;
    }

    public Guid Id { get; }

    public Guid VenueId { get; set; }

    public VenueEventDetails Details { get; private set; }

    public string Name { get; private set; }

    public DateTimeOffset EventDate { get; private set; }
}

