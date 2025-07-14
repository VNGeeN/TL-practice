public static class DataInputSerice
{
    public static OrderData CollectOrderData()
    {
        return new OrderData(
            Product: PromptUser( "Введите название товара: " ),
            Count: GetValidInt( "Введите количество товара: " ),
            Name: PromptUser( "Введите ваше имя: " ),
            Address: PromptUser( "Введите адресс доставки: " )
        );
    }

    private static string PromptUser( string message )
    {
        Console.Write( message );

        return Console.ReadLine()?.Trim() ?? "";
    }

    private static int GetValidInt( string message )
    {
        int result;
        while ( !int.TryParse( PromptUser( message ), out result ) || result <= 0 )
        {
            Console.WriteLine( "Некоректный ввод! Введите целое положительное число." );
        }

        return result;

    }
}