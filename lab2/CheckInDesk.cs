// Класс, представляющий стойку регистрации
public class CheckInDesk
{
    // Идентификатор стойки регистрации
    public string DeskID { get; private set; }

    public CheckInDesk(string deskID)
    {
        DeskID = deskID;
    }

    // Метод для регистрации пассажира на рейс
    public void CheckInPassenger(Passenger passenger, Flight flight, Ticket ticket)
    {
        if (!ticket.IsCheckedIn)
        {
            ticket.CheckIn();
            flight.AddPassenger(passenger);
        }
    }
}