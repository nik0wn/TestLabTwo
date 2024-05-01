using System.Collections.Generic;
using System.Linq;
using System.Text;

// Основной класс аэропорта, реализованный как Singleton
public class Airport
{
    private static Airport _instance;
    private static readonly object _lock = new object();

    // Список всех рейсов
    public List<Flight> Flights { get; private set; }
    // Список всех пассажиров
    public List<Passenger> Passengers { get; private set; }

    // Конструктор закрыт для внешнего использования
    private Airport()
    {
        Flights = new List<Flight>();
        Passengers = new List<Passenger>();
    }

    // Статический метод для доступа к экземпляру аэропорта
    public static Airport Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Airport();
                }
                return _instance;
            }
        }
    }

    // Метод для добавления рейса в список
    public void AddFlight(Flight flight)
    {
        Flights.Add(flight);
    }

    // Метод для добавления пассажира в список
    public void AddPassenger(Passenger passenger)
    {
        Passengers.Add(passenger);
    }

    // Метод для удаления пассажира из списка
    public void RemovePassenger(Passenger passenger)
    {
        Passengers.Remove(passenger);
    }

    // Метод для поиска рейса по номеру
    public Flight FindFlight(string flightNumber)
    {
        return Flights.FirstOrDefault(f => f.FlightNumber == flightNumber);
    }

    // Метод для поиска пассажира по ID
    public Passenger FindPassenger(string id)
    {
        return Passengers.FirstOrDefault(p => p.ID == id);
    }

    // Метод для отмены рейса
    public void CancelFlight(Flight flight)
    {
        Flights.Remove(flight);
    }

    // Метод для вывода информации о всех рейсах
    public string PrintAllFlightDetails()
    {
        StringBuilder details = new StringBuilder();
        foreach (var flight in Flights)
        {
            details.AppendLine($"Flight: {flight.FlightNumber}");
        }
        return details.ToString();
    }
}
