using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    internal class MoodAnalyserException
    {
        //Custom Exceptions usecase-3
        public class MoodAnalyzerException : Exception
        {
            public ExceptionTypes type;

            //Enum to differentiate mood analysis errors
            public enum ExceptionTypes
            {
                NULL_MOOD_EXCEPTION,
                EMPTY_MOOD_EXCEPTION,
                NO_SUCH_CLASS,
                NO_SUCH_METHOD
            }

            //Constructor to initialize ExceptionTypes
            public MoodAnalyserException(ExceptionTypes type, string message) : base(message)
            {
                this.type = type;
            }
        }
        //Method to analyse mood form a given message
        public string AnalyseMood()
        {
            //Custom Exception Handling
            try                   
            {
                if (this.message.Equals(null))
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionTypes.NULL_MOOD_EXCEPTION, "Message should not be null");
                }
                else if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionTypes.EMPTY_MOOD_EXCEPTION, "Message should not be empty");
                }
                else if (this.message.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (MoodAnalyzerException)
            {
                return "HAPPY";
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "HAPPY";
            }
        }
    }
}
