using NUnit.Framework;

[TestFixture]
public class FlightTests
{
    private Flight flight;
    private Passenger passenger;

    [SetUp]
    public void Setup()
    {
        // Инициализация рейса и пассажира перед каждым тестом
        flight = new Flight("SU100");
        passenger = new Passenger("P001", "John Doe");
        flight.SetCapacity(2);  // Установка вместимости рейса для тестирования
    }

    [Test]
    public void AddPassenger_ShouldAddPassengerWhenNotFull()
    {
        // Добавление пассажира в рейс, который не полон
        flight.AddPassenger(passenger);
        Assert.Contains(passenger, flight.Passengers);
        Assert.AreEqual(1, flight.Passengers.Count);
    }

    [Test]
    public void AddPassenger_ShouldNotAddPassengerWhenFull()
    {
        // Рейс заполняется полностью
        flight.AddPassenger(new Passenger("P002", "Jane Doe"));
        flight.AddPassenger(new Passenger("P003", "Jim Beam"));

        // Попытка добавить еще одного пассажира в полный рейс
        flight.AddPassenger(passenger);
        Assert.IsFalse(flight.Passengers.Contains(passenger));
    }

    [Test]
    public void UpdateStatus_ShouldChangeFlightStatus()
    {
        // Обновление статуса рейса
        flight.UpdateStatus("Delayed");
        Assert.AreEqual("Delayed", flight.Status);
    }

    [Test]
    public void SetCapacity_ShouldUpdateFlightCapacity()
    {
        // Установка новой вместимости рейса
        flight.SetCapacity(150);
        Assert.AreEqual(150, flight.Capacity);
    }
    
    [Test]
    public void FlightConstructor_ShouldInitializePropertiesCorrectly()
    {
        // Проверка корректной инициализации свойств рейса
        Assert.AreEqual("SU100", flight.FlightNumber);
        Assert.IsNotNull(flight.Passengers);
        Assert.AreEqual(0, flight.Passengers.Count);  // На новом рейсе нет пассажиров
        Assert.AreEqual(2, flight.Capacity);          // Вместимость была установлена в SetUp
    }
}
