using NUnit.Framework;
using System.Linq;

[TestFixture]
public class AirportTests
{
    private Airport airport;

    [SetUp]
    public void Setup()
    {
        // Инициализация аэропорта перед каждым тестом
        airport = Airport.Instance;
        // Очистка списков рейсов и пассажиров перед каждым тестом
        airport.Flights.Clear();
        airport.Passengers.Clear();
    }

    [Test]
    public void AddFlight_ShouldAddFlightToTheAirport()
    {
        // Создаем новый рейс и добавляем его в аэропорт
        var flight = new Flight("SU100");
        airport.AddFlight(flight);

        // Проверяем, что рейс добавлен
        Assert.Contains(flight, airport.Flights);
        Assert.AreEqual(1, airport.Flights.Count);
    }

    [Test]
    public void AddPassenger_ShouldAddPassengerToTheAirport()
    {
        // Создаем нового пассажира и добавляем его в аэропорт
        var passenger = new Passenger("P001", "John Doe");
        airport.AddPassenger(passenger);

        // Проверяем, что пассажир добавлен
        Assert.Contains(passenger, airport.Passengers);
        Assert.AreEqual(1, airport.Passengers.Count);
    }

    [Test]
    public void RemovePassenger_ShouldRemovePassengerFromTheAirport()
    {
        // Добавляем и затем удаляем пассажира
        var passenger = new Passenger("P001", "John Doe");
        airport.AddPassenger(passenger);
        airport.RemovePassenger(passenger);

        // Проверяем, что пассажир удален
        Assert.IsFalse(airport.Passengers.Contains(passenger));
        Assert.AreEqual(0, airport.Passengers.Count);
    }

    [Test]
    public void FindFlight_ShouldReturnCorrectFlight()
    {
        // Добавляем рейс и ищем его
        var flight = new Flight("SU100");
        airport.AddFlight(flight);
        var foundFlight = airport.FindFlight("SU100");

        // Проверяем, что найденный рейс корректен
        Assert.AreEqual(flight, foundFlight);
    }

    [Test]
    public void FindFlight_WithNonexistentFlightNumber_ShouldReturnNull()
    {
        // Ищем рейс, которого нет в списке
        var foundFlight = airport.FindFlight("SU999");

        // Проверяем, что рейс не найден
        Assert.IsNull(foundFlight);
    }

    [Test]
    public void CancelFlight_ShouldRemoveFlightFromTheAirport()
    {
        // Добавляем рейс и затем отменяем его
        var flight = new Flight("SU100");
        airport.AddFlight(flight);
        airport.CancelFlight(flight);

        // Проверяем, что рейс удален
        Assert.IsFalse(airport.Flights.Contains(flight));
        Assert.AreEqual(0, airport.Flights.Count);
    }

    [Test]
    public void PrintAllFlightDetails_ShouldReturnCorrectDetails()
    {
        // Добавляем рейсы
        airport.AddFlight(new Flight("SU100"));
        airport.AddFlight(new Flight("SU101"));

        // Выводим детали всех рейсов
        var details = airport.PrintAllFlightDetails();

        // Проверяем, что детали содержат информацию о всех рейсах
        StringAssert.Contains("SU100", details);
        StringAssert.Contains("SU101", details);
    }
}
