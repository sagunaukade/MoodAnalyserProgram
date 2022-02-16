using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyser;

namespace MoodAnalyseTest
{
    [TestClass]
    public class MoodAnalyserTest
    {
        //Method to test Sad Mood
        [TestMethod]
        [TestCategory("Sad Message")]
        public void TestSadMoodInMessage()
        {
            //Arrange
            string message = "I am in sad Mood";
            string expected = "SAD";
            MoodAnalyse moodAnalyzer = new MoodAnalyse(message);

            //Act
            string actual = moodAnalyzer.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Method to test Happy Mood
        [TestMethod]
        [TestCategory("Happy Message")]
        public void TestHappyMoodInMessage()
        {
            //Arrange
            string message = "I am in Any Mood";
            string expected = "HAPPY";
            MoodAnalyse moodAnalyzer = new MoodAnalyse(message);

            //Act
            string actual = moodAnalyzer.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Method to test Happy Mood in null message
        [TestMethod]
        [TestCategory("Null Exception")]
        public void GivenNullMessageReturnHappyMood()
        {
            //Arrange
            string message = null;
            string expected = "HAPPY";
            MoodAnalyse moodAnalyzer = new MoodAnalyse(message);

            //Act
            string actual = moodAnalyzer.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
