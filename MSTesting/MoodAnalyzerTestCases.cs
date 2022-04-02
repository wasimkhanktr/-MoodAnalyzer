using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
namespace MSTesting
{
    [TestClass]
    public class MoodAnalyzerTestCases
    {
        [TestMethod]
        public void GivenString_ContainsSad_SoReturnSad()
        {
            MoodAnalyser moodAnalyzer = new MoodAnalyser();
            string mood = "I am in sad mood";
            string expected = "sad";
            string actual = moodAnalyzer.AnalyzeMood(mood);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void GivenString_ContainsNietherHappyNorSad_SoReturnHappy()
        {
            MoodAnalyser moodAnalyzer = new MoodAnalyser();
            string mood = "I am in any mood";
            string expected = "happy";
            string actual = moodAnalyzer.AnalyzeMood(mood);
            Assert.AreEqual(expected, actual);

        }
    }
}