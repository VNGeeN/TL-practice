public static class OrderProcessService
{
    public static void StartOrderProcess()
    {
        OrderData data = DataInputSerice.CollectOrderData();

        bool isConfirmed = ConfirmationService.ConfirmOrder( data );

        if ( isConfirmed )
        {
            OrderDeliveryService.SuccesfullOrder( data );
        }
        RestartService.HandleOrderRestart();
    }
}