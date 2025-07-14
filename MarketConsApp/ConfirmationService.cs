public static class ConfirmationService
{
    public static bool ConfirmOrder( OrderData data )
    {
        string confirmMessage =
            $"Здравствуйте, {data.Name}, вы заказали {data.Count} {data.Product} " +
            $"на адрес {data.Address}, всё верно ? (да/нет)";
        Console.WriteLine( confirmMessage );

        return Console.ReadLine()?.Trim().Equals( "да", StringComparison.OrdinalIgnoreCase ) ?? false;
    }
}