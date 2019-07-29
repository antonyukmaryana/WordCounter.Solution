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
           
            Assert.AreEqual(0, RepeatCounter.Counting("cat", "We visited a lot of cathedrals in Belgium"));
        }
        
[TestMethod]
        public void Count_CountYourWordCapitalLowerCase_Number()
        {
           
            Assert.AreEqual(2, RepeatCounter.Counting("cat", "Cat  cat - we yelled"));
        }
[TestMethod]
        public void Count_CountOnlyAlphaCharacters_Number()
        {
           
            Assert.AreEqual(-1, RepeatCounter.Counting("123", "Cat  cat - we yelled"));
        }
    }
    
    
}