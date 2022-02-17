using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class Program
    {
        static void Main(string[] args)
        {   // display welcome message
            Console.WriteLine("Welcome to the mood analyser programs");

            //Creating MoodAnalyzer object usecase-1
            MoodAnalyse moodAnalyser = new MoodAnalyse("I am in Happy Mood");
            Console.WriteLine("Mood is: " + moodAnalyser.AnalyseMood());
            Console.ReadLine();
        }
         //Method to Vaidate MoodAnalyzer Property Using Annotations
        public static void ValidateMoodAnalyzer(MoodAnalyzer moodAnalyzer)
        {
            ValidationContext validationContext = new ValidationContext(moodAnalyzer, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(moodAnalyzer, validationContext, validationResults, true);
            if (!valid)
            {
                foreach (ValidationResult validationResult in validationResults)
                {
                    Console.WriteLine(validationResult.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine("All Validations are successful");
            }
        }
    }
}
