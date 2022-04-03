using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
namespace MSTesting
{
    [TestClass]
    public class MoodAnalyzerTestCases
    {
        [TestMethod]
        public void GivenEmptyMood_SoReturnEmptyMessagePassed()
        {
            MoodAnalyser moodAnalyzer = new MoodAnalyser();
            string mood = string.Empty;
            string expected = "Empty message passed";
            string actual = moodAnalyzer.AnalyzeMood(mood);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void GivenNullMood_SoReturnNullMessagePassed()
        {
            MoodAnalyser moodAnalyzer = new MoodAnalyser();
            string mood = null;
            string expected = "Null message passed";
            string actual = moodAnalyzer.AnalyzeMood(mood);
            Assert.AreEqual(expected, actual);

        }
    }
}