namespace lab2;

public class Program
{
    static void Main(string[] args)
    {
        // Получение единственного экземпляра аэропорта
        Airport airport = Airport.Instance;

        // Создание и добавление рейсов
        Flight flight1 = new Flight("SU100");
        Flight flight2 = new Flight("SU101");
        airport.AddFlight(flight1);
        airport.AddFlight(flight2);

        // Создание и добавление пассажиров
        Passenger passenger1 = new Passenger("P001", "John Doe");
        Passenger passenger2 = new Passenger("P002", "Jane Doe");
        airport.AddPassenger(passenger1);
        airport.AddPassenger(passenger2);

        // Создание билетов для пассажиров
        Ticket ticket1 = new Ticket("T001", passenger1, flight1);
        Ticket ticket2 = new Ticket("T002", passenger2, flight2);

        // Создание и настройка стойки регистрации
        CheckInDesk desk = new CheckInDesk("Desk1");

        // Регистрация пассажиров на рейс через стойку регистрации
        desk.CheckInPassenger(passenger1, flight1, ticket1);
        desk.CheckInPassenger(passenger2, flight2, ticket2);
        
    }
}