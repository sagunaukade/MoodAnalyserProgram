﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyse
    {
        //Annotation - Attribute
      [Required(ErrorMessage ="{0} Should not be null or empty")]        
      public string message;

        public MoodAnalyse()
        { 
            Console.WriteLine("Default Constructor");
        }
        //Constructor for initializing the message
        public MoodAnalyzer(string message)
        {
            this.message = message;
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