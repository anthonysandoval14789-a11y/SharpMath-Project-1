using System.Diagnostics.Tracing;

try
{

    int option;

    List<decimal> typedNumbers = new List<decimal>();

    bool calculatorRunning = true;

    while (calculatorRunning)
    {
        Console.WriteLine("====SharpMath====");
        Console.WriteLine("1.ADDITION");
        Console.WriteLine("2.SUBTRACTION");
        Console.WriteLine("3.MULTIPLICATION");
        Console.WriteLine("4.DIVISION");
        Console.WriteLine("5.ACADEMIC EVALUATION");
        Console.WriteLine("6.EXIT");

        Console.WriteLine("SELECT AN OPTION");



        while (!int.TryParse(Console.ReadLine()!, out option) || option < 1 || option > 6)
        {
            Console.WriteLine("INVALID OPTION, SELECT AN OPTION FROM 1 TO 6:");
        }

        switch (option)
        {
            case 1:
                int quantity;
                Console.WriteLine("ENTER THE NUMBER OF VALUES FOR ADDITION");

                while (!int.TryParse(Console.ReadLine()!, out quantity) || quantity < 2)
                {
                    Console.WriteLine("INVALID DATA, THE MINIMUM NUMBER OF VALUES FOR ADDITION IS 2:");
                }

                typedNumbers.Clear();

                for (int i = 1; i <= quantity; i++)
                {
              
                    Console.WriteLine($"ENTER NUMBER {i}:");

                    decimal number;  

                    while (!decimal.TryParse(Console.ReadLine()!, out number))
                    {
                        Console.WriteLine("INVALID DATA, ENTER A VALID NUMBER:");

                    }
                    typedNumbers.Add(number); 

                }

                decimal addition = 0;

                foreach (decimal number in typedNumbers) 
                {

                    addition += number;
                }

                Console.WriteLine($"TOTAL: {addition}");

                break;


            case 2:

                int quantityTosubtract;

                Console.WriteLine("ENTER THE NUMBER OF VALUES FOR SUBTRACTION");

                while (!int.TryParse(Console.ReadLine(), out quantityTosubtract) || quantityTosubtract < 2)
                { 

                    Console.WriteLine("INVALID DATA, THE MINIMUM NUMBER OF VALUES FOR SUBTRACTION IS 2: ");

                }

                typedNumbers.Clear();


                for (int i = 1; i <= quantityTosubtract; i++)
                {


                    Console.WriteLine($"ENTER NUMBER {i}:");

                    decimal number;

                    while (!decimal.TryParse(Console.ReadLine()!, out number))
                    {

                        Console.WriteLine("INVALID DATA, ENTER A VALID NUMBER:");
                    }

                    typedNumbers.Add(number);
                }

                decimal subtraction = typedNumbers[0];

                for (int i = 1; i < typedNumbers.Count; i++) 
                {

                    subtraction -= typedNumbers[i];
                }

                Console.WriteLine($"TOTAL:   {subtraction} ");

                break;



            case 3:

                int quantityToMultiply;

                Console.WriteLine("ENTER THE NUMBER OF VALUES FOR MULTIPLICATION");

                while (!int.TryParse(Console.ReadLine()!, out quantityToMultiply) || quantityToMultiply < 2)
                {
                    Console.WriteLine("INVALID DATA, THE MINIMUM NUMBER OF VALUES FOR MULTIPLICATION IS 2:");
                }

                typedNumbers.Clear();

                for (int i = 1; i <= quantityToMultiply; i++)
                {
                    Console.WriteLine($"ENTER NUMBER {i}:");

                    decimal number;

                    while (!decimal.TryParse(Console.ReadLine()!, out number))
                    {
                        Console.WriteLine("INVALID DATA, ENTER A VALID NUMBER:");
                    }

                    typedNumbers.Add(number);
                }

                decimal multiplication = 1;

                foreach (decimal number in typedNumbers)
                {
                    multiplication *= number;
                }

                Console.WriteLine($"TOTAL: {multiplication}");

                break;


            case 4:

                int quantityTodivide;

                Console.WriteLine("ENTER THE NUMBER OF VALUES FOR DIVISION");

                while (!int.TryParse(Console.ReadLine()!, out quantityTodivide) || quantityTodivide < 2)
                {
                    Console.WriteLine("INVALID DATA, THE MINIMUM NUMBER OF VALUES FOR DIVISION IS 2:");
                }
                typedNumbers.Clear();

                for (int i = 1; i <= quantityTodivide; i++) 
                { 

                    Console.WriteLine($"ENTER NUMBER {i}:");

                    decimal number;

                    while (!decimal.TryParse(Console.ReadLine(), out number) || (i > 1 && number == 0))
                    {
                        Console.WriteLine("INVALID DATA, ENTER A NUMBER DIFFERENT FROM 0:");
                    }

                    typedNumbers.Add(number);
               
                
                }

                decimal division = typedNumbers[0];

                for (int i = 1; i < typedNumbers.Count; i++) 
                { 
                    division /= typedNumbers[i];

                }

                Console.WriteLine($"TOTAL: {division}");

                break;



            case 5:

                decimal homework;
                decimal exam;
                decimal participation;
                decimal project;

                Console.WriteLine("ENTER THE HOMEWORK GRADE:");

                while (!decimal.TryParse(Console.ReadLine(), out homework) || homework < 0 || homework > 100)
                {
                    Console.WriteLine("INVALID DATA, ENTER A GRADE BETWEEN 0 AND 100:");
                }

                Console.WriteLine("ENTER THE EXAM GRADE:");

                while (!decimal.TryParse(Console.ReadLine(), out exam) || exam < 0 || exam > 100)
                {
                    Console.WriteLine("INVALID DATA, ENTER A GRADE BETWEEN 0 AND 100:");
                }

                Console.WriteLine("ENTER THE PARTICIPAPATION GRADE:");

                while (!decimal.TryParse(Console.ReadLine(), out participation) || participation < 0 || participation > 100)
                {
                    Console.WriteLine("INVALID DATA, ENTER A GRADE BETWEEN 0 AND 100:");
                }


                Console.WriteLine("ENTER THE PROJECT GRADE:");

                while (!decimal.TryParse(Console.ReadLine(), out project) || project < 0 || project > 100)
                {
                    Console.WriteLine("INVALID DATA, ENTER A GRADE BETWEEN 0 AND 100:");
                }

                decimal FinalGrade = (homework * 0.20m) + (exam * 0.40m) + (participation * 0.10m) + (project * 0.30m);

                Console.WriteLine($"FINAL GRADE: {FinalGrade:F2}");

                if (FinalGrade >= 70)
                {

                    Console.WriteLine("STATUS: PASSED");
                }

                else 
                { 

                    Console.WriteLine("STATUS: FAILED");
                }

                break;



            case 6:
                //// Stops the calculator loop and exits the program
                
                Console.WriteLine("EXITING THE PROGRAM...");
                calculatorRunning = false;

                break;

        }


    } 
}

catch 
{ 

}
