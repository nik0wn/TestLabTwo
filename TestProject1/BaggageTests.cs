using NUnit.Framework;

[TestFixture]
public class BaggageTests
{
    private Baggage baggage;
    private Passenger passenger;

    [SetUp]
    public void Setup()
    {
        // Создаем пассажира для связи с багажом
        passenger = new Passenger("P001", "John Doe");
        // Инициализация багажа перед каждым тестом
        baggage = new Baggage("B001", 20, passenger);
    }

    [Test]
    public void Baggage_InitializesCorrectly()
    {
        // Проверяем, что начальные параметры багажа установлены корректно
        Assert.AreEqual("B001", baggage.BaggageID);
        Assert.AreEqual(20, baggage.Weight);
        Assert.AreEqual(passenger, baggage.Owner);
        Assert.IsFalse(baggage.ContainsProhibitedItems);
    }

    [Test]
    public void AddProhibitedItem_SetsProhibitedItemsTrue()
    {
        // Добавляем запрещенный предмет и проверяем статус
        baggage.AddProhibitedItem();
        Assert.IsTrue(baggage.ContainsProhibitedItems);
    }

    [Test]
    public void CheckForProhibitedItems_ReturnsTrueIfProhibitedItemsPresent()
    {
        // Добавляем запрещенный предмет и проверяем функцию поиска запрещенных предметов
        baggage.AddProhibitedItem();
        bool result = baggage.CheckForProhibitedItems();
        Assert.IsTrue(result);
    }

    [Test]
    public void CheckForProhibitedItems_ReturnsFalseIfNoProhibitedItems()
    {
        // Проверяем, что функция возвращает false, если запрещенные предметы не добавлены
        bool result = baggage.CheckForProhibitedItems();
        Assert.IsFalse(result);
    }
    
}
