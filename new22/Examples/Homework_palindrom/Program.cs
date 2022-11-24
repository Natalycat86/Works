int index, remainder = 0, newnum = 0;
        Console.WriteLine("Введите число: ");
        int uinput = Convert.ToInt32((Console.ReadLine()));
        for (index = uinput; index > 0; index = (index / 10))
        {
            remainder = index % 10;
            
            newnum = (newnum*10) + remainder;
 
        }
 
        if (newnum == uinput)
        {
            Console.WriteLine($"Число {uinput} пaлиндром");
        }
        else
        {
            Console.WriteLine($"Число {uinput} не пaлиндром");
        } 