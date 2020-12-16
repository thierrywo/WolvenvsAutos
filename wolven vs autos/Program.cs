using System;
using System.Diagnostics;
using Wolven_vs_autosML.Model;

namespace wolven_vs_autos
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Debug.WriteLine(" Object is not valid for this category.");
                // Add input data
                var input = new ModelInput();
                Console.WriteLine("Wat is het pad van de foto?");
                input.ImageSource = Console.ReadLine();

                // Load model and predict output of sample data
                ModelOutput result = ConsumeModel.Predict(input);
                Debug.WriteLine(result.Prediction);
                Console.WriteLine("De foto valt onder de catogorie:");
                Console.WriteLine(result.Prediction);
                Console.WriteLine("wil je nog een foto testen?");
            } while (Console.ReadLine().ToLower() == "ja");
        }

    }
}
