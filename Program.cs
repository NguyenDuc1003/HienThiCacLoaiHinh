
int choice = -1;
while (choice != 0)
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Print the rectangle");
    Console.WriteLine("2. Print the square triangle (4 types)");
    Console.WriteLine("3. Print isosceles triangle");
    Console.WriteLine("0. Exit");
    Console.Write("Enter your choice: ");
    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.Write("Enter width: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            int height = int.Parse(Console.ReadLine());
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            break;
        case 2:
            Console.WriteLine("Type 1: bottom-left");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Type 2: top-left");
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Type 3: bottom-right");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Type 4: top-right");
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= 5 - i; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            break;
        case 3:
            Console.Write("Enter height: ");
            int h = int.Parse(Console.ReadLine());
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= h - i; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            break;
        case 0:
            Console.WriteLine("Exiting...");
            break;
        default:
            Console.WriteLine("Invalid choice!");
            break;
    }
    Console.WriteLine();
}
