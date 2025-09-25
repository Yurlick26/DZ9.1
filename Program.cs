
    
        string[] parts = Console.ReadLine().Split();
        if (parts[0][0] == parts[1][0])
            Console.WriteLine("Last name begins with the same letter as first name");
        else
            Console.WriteLine("The last name does not start with the same letter as the first name");
    