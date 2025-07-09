public static class RestartService
{
    public static void HandleOrderRestart()
    {
        Console.WriteLine("Хотите продолжить? (да/нет)");

        if (Console.ReadLine()?.Trim().Equals("да", StringComparison.OrdinalIgnoreCase) ?? false)
        {
            OrderProcessService.StartOrderProcess();
        }
        else
        {                                            
            Console.WriteLine("До свидания! Спасибо за использование сервиса!");                                    
        }
    }
}