namespace Casino
{
    class Program
    {
        const string GameName = @"
         ####   #    ###  # #   #  ###
        #      # #  #     # ##  # #   #
        #     #   #  ###  # # # # #   #
        #     #####     # # #  ## #   # 
         #### #   #  ###  # #   #  ###
        ";
        public static void Main()
        {
            Casino.Menu.PrintNameGame( GameName );

            Console.Write( "Please enter amount of money youd like to lose: " );

            string balanceStr = Console.ReadLine();

            bool isBalanceParsed = int.TryParse( balanceStr, out int balance );

            if (!isBalanceParsed)
            {
                Console.WriteLine( $"Invalid balancr value entered: {balanceStr}" );
                return;
            }

            if (balance <= 0)
            {
                Console.WriteLine( "You are too poor for this game" );
            }

            Console.WriteLine( "Menu" );
            Operations? operation = Operations.Initial;

            while (operation != Operations.Exit)
            {
                operation = ReadOperation();
            }


        }

        static Operations? ReadOperation()
        {
            string operationStr = Console.ReadLine();
            bool isParsed = Enum.TryParse( operationStr, out Operations operation );

            return isParsed ? operation : null;
        }

        static void HandleOperation( Operations operation )
        {
            switch (operation)
            {
                case Operations.Initial:
                    return;
                case Operations.Play:
                    break;
                case Operations.CheckBalance:
                    break;
                case Operations.Exit:
                    break;
                default:
                    throw new Exception( $"Unsupported operation passed: {operation}." );
            }
        }

    }
}