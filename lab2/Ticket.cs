// Класс, представляющий билет
public class Ticket
{
    // Идентификатор билета
    public string TicketID { get; private set; }
    // Пассажир, которому принадлежит билет
    public Passenger Passenger { get; private set; }
    // Рейс, на который выдан билет
    public Flight Flight { get; private set; }
    // Статус регистрации на рейс
    public bool IsCheckedIn { get; private set; }

    public Ticket(string ticketID, Passenger passenger, Flight flight)
    {
        TicketID = ticketID;
        Passenger = passenger;
        Flight = flight;
        IsCheckedIn = false;
    }

    // Метод для регистрации на рейс
    public void CheckIn()
    {
        IsCheckedIn = true;
    }
}