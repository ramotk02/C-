using System;

class MacroCalculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Macro Calculator!");

        Console.Write("Enter your weight (kg): ");
        double weight = double.Parse(Console.ReadLine());

        Console.Write("Enter your height (cm): ");
        double height = double.Parse(Console.ReadLine());

        // Calculate BMR using the Harris-Benedict formula (average for men and women)
        double bmr = 10 * weight + 6.25 * height - 5 * 25; 

        // Estimate TDEE (assuming moderate activity level)
        double tdee = bmr * 1.55; 

        // Calculate calorie targets
        double calorieLoss = tdee - 500; 
        double calorieGain = tdee + 500; 

        // Macronutrient calculations
        double protein = weight * 1.6; 
        double fat = weight * 0.8;    

        // Macronutrient calories
        double proteinCalories = protein * 4;
        double fatCalories = fat * 9;

        // Remaining calories go to carbs
        double carbsLoss = (calorieLoss - (proteinCalories + fatCalories)) / 4;
        double carbsGain = (calorieGain - (proteinCalories + fatCalories)) / 4;

        // Output results
        Console.WriteLine("\nResults:");
        Console.WriteLine($"For Weight Loss:");
        Console.WriteLine($"  Calories: {calorieLoss:F0} kcal");
        Console.WriteLine($"  Protein: {protein:F1} g");
        Console.WriteLine($"  Fat: {fat:F1} g");
        Console.WriteLine($"  Carbs: {carbsLoss:F1} g");

        Console.WriteLine($"\nFor Muscle Gain:");
        Console.WriteLine($"  Calories: {calorieGain:F0} kcal");
        Console.WriteLine($"  Protein: {protein:F1} g");
        Console.WriteLine($"  Fat: {fat:F1} g");
        Console.WriteLine($"  Carbs: {carbsGain:F1} g");
    }
}
