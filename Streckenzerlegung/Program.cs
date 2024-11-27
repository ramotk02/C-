 Console.WriteLine("Strecke [mm]?");
        int strecke = Convert.ToInt32(Console.ReadLine());

        int meter = strecke / 1000;              
        int zentimeter = (strecke % 1000) / 10;  
        int millimeter = strecke % 10;           

        Console.WriteLine($"{strecke}mm = {meter}m {zentimeter}cm {millimeter}mm");