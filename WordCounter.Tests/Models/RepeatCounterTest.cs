using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;


namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTest
    {
        [TestMethod]
        public void Count_CountYourWordInTheString_Number()
        {
            //Act
         RepeatCounter testRepeatCounter = new RepeatCounter();
          //Assert
          Assert.AreEqual(1, testRepeatCounter.Counting("cat", "cat"));
        }
    }
}
