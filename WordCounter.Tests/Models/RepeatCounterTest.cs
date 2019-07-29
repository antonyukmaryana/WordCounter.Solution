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
            
            Assert.AreEqual(1, RepeatCounter.Counting("cat", "cat"));
        }

        [TestMethod]
        public void Count_CountYourWordInStringOnlyWhenCompleteMatch_Number()
        {
           
            Assert.AreEqual(0, RepeatCounter.Counting("cat", "We visited a lot of cathedral in Belgium"));
        }
        
//        [TestMethod]
//        public void Count_CountYourWordInStringMultiple_Number()
//        {
//            
//            Assert.AreEqual(5, RepeatCounter.Counting("cat", "I love my cat cat cat cat cat"));
//        }
    }
}