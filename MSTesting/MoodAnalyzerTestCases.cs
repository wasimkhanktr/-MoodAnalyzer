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
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {

            object expected = new MoodAnalyser();
            object obj = MoodAnalyzerFactory.CreateMoodAnalyser("MoodAnalyzer.MoodAnalyser", "MoodAnalyser");
            var expectedtype = expected.GetType();
            var objtype = obj.GetType();
            var result = expectedtype == objtype;
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenImproperClassname_SoReturnNoSuchClass()
        {
            object expected = new MoodAnalyser();
            object obj = MoodAnalyzerFactory.CreateMoodAnalyser("MoodAnazer.MoodAnalyser", "MoodAnalyser");
            string actual = obj.ToString();
            Assert.AreEqual("MoodAnalyzer.MoodAnalyzerCustomException: No such Class", actual);
        }
        [TestMethod]
        public void GivenImproperMethod_SoReturnNoSuchMethod()
        {

            object expected = new MoodAnalyser();
            object obj = MoodAnalyzerFactory.CreateMoodAnalyser("MoodAnalyzer.MoodAnalser", "MoodAnalyser");
            string actual = obj.ToString();
            Assert.AreEqual("MoodAnalyzer.MoodAnalyzerCustomException: No Such Method", actual);
        }
        [TestMethod]
        public void GivenImproperConstructorname_SoReturnConstructorNotFound()
        {
            object expected = new MoodAnalyser();
            object obj = MoodAnalyzerFactory.CreateMoodAnalyserUsingParameterizedConstructer("MoodAnalyzer.MoodAnalyser", "MoodAnalser", "with Constructor");
            string actual = obj.ToString();
            Assert.AreEqual("MoodAnalyzer.MoodAnalyzerCustomException: Constructor Not Found", actual);
        }
    }
}