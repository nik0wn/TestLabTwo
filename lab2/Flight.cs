using System.Collections.Generic;

// Класс, представляющий рейс
public class Flight
{
    // Номер рейса
    public string FlightNumber { get; private set; }
    // Список пассажиров на рейсе
    public List<Passenger> Passengers { get; private set; }
    // Вместимость рейса
    public int Capacity { get; private set; }
    // Статус рейса (например, "Delayed")
    public string Status { get; private set; }

    public Flight(string flightNumber)
    {
        FlightNumber = flightNumber;
        Passengers = new List<Passenger>();
    }

    // Метод для добавления пассажира в рейс
    public void AddPassenger(Passenger passenger)
    {
        if (Passengers.Count < Capacity)
        {
            Passengers.Add(passenger);
        }
    }

    // Метод для установки вместимости рейса
    public void SetCapacity(int capacity)
    {
        Capacity = capacity;
    }

    // Метод для обновления статуса рейса
    public void UpdateStatus(string status)
    {
        Status = status;
    }
}