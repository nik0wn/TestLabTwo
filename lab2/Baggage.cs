// Класс, представляющий багаж
public class Baggage
{
    // Идентификатор багажа
    public string BaggageID { get; private set; }
    // Вес багажа
    public double Weight { get; private set; }
    // Наличие запрещенных предметов в багаже
    public bool ContainsProhibitedItems { get; private set; }
    // Владелец багажа
    public Passenger Owner { get; private set; }

    public Baggage(string baggageID, double weight, Passenger owner)
    {
        BaggageID = baggageID;
        Weight = weight;
        Owner = owner;
    }

    // Метод для добавления запрещенных предметов
    public void AddProhibitedItem()
    {
        ContainsProhibitedItems = true;
    }

    // Метод для проверки багажа на наличие запрещенных предметов
    public bool CheckForProhibitedItems()
    {
        return ContainsProhibitedItems;
    }
}