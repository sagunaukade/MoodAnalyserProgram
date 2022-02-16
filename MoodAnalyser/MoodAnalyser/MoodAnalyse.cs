using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyse
    {
        public string message;

        //Constructor for initializing the message
        public MoodAnalyse(string message)
        {
            this.message = message;
        }

        //Method to analyse mood form a given message
        public string AnalyseMood()
        {
            if (this.message.ToLower().Contains("sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}

   
