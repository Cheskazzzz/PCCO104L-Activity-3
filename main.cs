using System;
class Program {
    static void Main(string[] args) {
        while (true) {
            Console.Write("Enter a positive number: ");
            string input = Console.ReadLine();

            if (input == "0") {
                Console.WriteLine("Closing program...");
                break;
            }

            if (int.TryParse(input, out int numput) && numput > 0) {
                for (int i = 1; i <= numput; ++i) {
                    for (int j = 1; j <= numput - i; ++j) {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= 2 * i - 1; ++k) {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else {
                Console.WriteLine("Invalid value: " + input);
            }
        }
    }
  }
