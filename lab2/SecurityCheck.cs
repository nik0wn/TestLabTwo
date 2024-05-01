namespace lab2;

public class SecurityCheck
{
    // Метод для выполнения досмотра пассажира и его багажа
    public void PerformSecurityScreening(Passenger passenger, Baggage baggage)
    {
        Console.WriteLine($"Проводится досмотр пассажира {passenger.Name} и его багажа {baggage.BaggageID}.");

        // Пример проверки условий безопасности (можно дополнить более сложной логикой)
        if (baggage.Weight > 23) // Превышение веса багажа
        {
            Console.WriteLine($"Внимание: Багаж {baggage.BaggageID} превышает допустимый лимит веса!");
        }
        else
        {
            Console.WriteLine($"Багаж {baggage.BaggageID} соответствует требованиям безопасности.");
        }

        // Проверка на наличие запрещенных предметов (условная логика)
        if (CheckForProhibitedItems(baggage))
        {
            Console.WriteLine($"Обнаружены запрещенные предметы в багаже {baggage.BaggageID}. Требуется дополнительная проверка.");
        }
        else
        {
            Console.WriteLine($"Багаж {baggage.BaggageID} не содержит запрещенных предметов.");
        }

        // Регистрация результатов досмотра
        LogSecurityCheck(passenger, baggage);
    }

    // Метод для проверки наличия запрещенных предметов в багаже
    private bool CheckForProhibitedItems(Baggage baggage)
    {
        // Здесь должна быть реализация проверки багажа, в этом примере всегда возвращает false
        return false;
    }

    // Метод для записи результатов досмотра в журнал безопасности аэропорта
    private void LogSecurityCheck(Passenger passenger, Baggage baggage)
    {
        Console.WriteLine($"Результаты досмотра пассажира {passenger.Name} и багажа {baggage.BaggageID} зарегистрированы.");
    }
}