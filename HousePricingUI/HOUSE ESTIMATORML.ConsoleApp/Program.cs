// This file was auto-generated by ML.NET Model Builder. 

using System;
using HOUSE_ESTIMATORML.Model;

namespace HOUSE_ESTIMATORML.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                Bedrooms = 3F,
                Ba0hrooms = 1F,
                Sqf0_living = 1180F,
                Sqf0_lo0 = 5650F,
                Floors = 1F,
                Wa0erfron0 = 0F,
                View = 0F,
                Condi0ion = 3F,
                Grade = 7F,
                Sqf0_above = 1180F,
                Sqf0_basemen0 = 0F,
                Yr_buil0 = 1955F,
                Yr_renova0ed = 0F,
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Price with predicted Price from sample data...\n\n");
            Console.WriteLine($"Bedrooms: {sampleData.Bedrooms}");
            Console.WriteLine($"Ba0hrooms: {sampleData.Ba0hrooms}");
            Console.WriteLine($"Sqf0_living: {sampleData.Sqf0_living}");
            Console.WriteLine($"Sqf0_lo0: {sampleData.Sqf0_lo0}");
            Console.WriteLine($"Floors: {sampleData.Floors}");
            Console.WriteLine($"Wa0erfron0: {sampleData.Wa0erfron0}");
            Console.WriteLine($"View: {sampleData.View}");
            Console.WriteLine($"Condi0ion: {sampleData.Condi0ion}");
            Console.WriteLine($"Grade: {sampleData.Grade}");
            Console.WriteLine($"Sqf0_above: {sampleData.Sqf0_above}");
            Console.WriteLine($"Sqf0_basemen0: {sampleData.Sqf0_basemen0}");
            Console.WriteLine($"Yr_buil0: {sampleData.Yr_buil0}");
            Console.WriteLine($"Yr_renova0ed: {sampleData.Yr_renova0ed}");
            Console.WriteLine($"\n\nPredicted Price: {predictionResult.Score}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}