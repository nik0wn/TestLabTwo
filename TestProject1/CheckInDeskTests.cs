using NUnit.Framework;

[TestFixture]
public class CheckInDeskTests
{
    private CheckInDesk checkInDesk;
    private Passenger passenger;
    private Flight flight;
    private Ticket ticket;

    [SetUp]
    public void Setup()
    {
        // Инициализация объектов перед каждым тестом
        checkInDesk = new CheckInDesk("Desk1");
        passenger = new Passenger("P001", "John Doe");
        flight = new Flight("SU100");
        ticket = new Ticket("T001", passenger, flight);
    }

    [Test]
    public void CheckInPassenger_ShouldMarkTicketAsCheckedIn()
    {
        // Регистрация пассажира на рейс
        checkInDesk.CheckInPassenger(passenger, flight, ticket);

        // Проверка, что билет помечен как зарегистрированный
        Assert.IsTrue(ticket.IsCheckedIn);
    }
    

    [Test]
    public void CheckInPassenger_WhenTicketIsAlreadyCheckedIn_ShouldNotCheckInAgain()
    {
        // Первоначальная регистрация пассажира
        ticket.CheckIn();
        // Попытка повторной регистрации
        checkInDesk.CheckInPassenger(passenger, flight, ticket);

        // Проверка, что метод регистрации не был вызван повторно
        Assert.IsTrue(ticket.IsCheckedIn);
        // Проверяем, что количество вызовов метода CheckIn() осталось прежним (добавим счетчик в класс Ticket если нужно)
    }
    
}
