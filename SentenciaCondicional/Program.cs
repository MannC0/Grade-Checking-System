using System;

class Program
{
    static void Main(string[] args)
    {
        // We greet the user
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Hola, por favor digite su nombre.");

        // We set the name variable
        String name = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Gracias, ahora digite su nota.");

        // We now set the grade variable
        String input = Console.ReadLine();
        int grade = int.Parse(input); // We convert the String input into an int variable named grade.
        
        // We limit the input to be between 0 and 100
            // While
            while (grade < 0 || grade > 100)
            {
                Console.WriteLine("Por favor, inserte una nota valida");

                grade = int.Parse(Console.ReadLine());
            }
            // We now make the limitations for each grade type, this way we can print the correct grade.
            if (grade < 60)
            {
                Console.WriteLine(name + " su nota es F, es insuficiente");
            }
            if (grade >= 60 && grade <= 62 )
            {
                Console.WriteLine(name + " su nota es D-, es insuficiente");
            }
            if (grade >= 63 && grade <= 66)
            {
                Console.WriteLine(name + " su nota es D, es insuficiente");
            }
            if (grade >= 67 && grade <= 69)
            {
                Console.WriteLine(name + " su nota es D+, es insuficiente");
            }
            if (grade >= 70 && grade <= 72)
            {
                Console.WriteLine(name + " su nota es C-, es suficientemente bajo");
            }
            if (grade >= 73 && grade <= 76)
            {
                Console.WriteLine(name + " su nota es C, es suficiente");
            }
            if (grade >= 77 && grade <= 79)
            {
                Console.WriteLine(name + " su nota es C+, está bien");
            }
            if (grade >= 80 && grade <= 82)
            {
                Console.WriteLine(name + " su nota es B-, es notable baja");
            }
            if (grade >= 83 && grade <= 86)
            {
                Console.WriteLine(name + " su nota es B, es notable");
            }
            if (grade >= 87 && grade <= 89)
            {
                Console.WriteLine(name + " su nota es B+, es notable alto");
            }
            if (grade >= 90 && grade <= 92)
            {
                Console.WriteLine(name + " su nota es A, es sobresaliente");
            }
            if (grade >= 93 && grade <= 100)
            {
                Console.WriteLine(name + " su nota es A+, es sobresaliente alto");
            }
        // We limit the input to be between 0 and 100
    }

}