// Класс, представляющий пассажира
public class Passenger
{
    // Идентификатор пассажира
    public string ID { get; private set; }
    // Имя пассажира
    public string Name { get; private set; }

    public Passenger(string id, string name)
    {
        ID = id;
        Name = name;
    }
}