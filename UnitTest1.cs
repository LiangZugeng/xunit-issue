using System;
using Xunit;

namespace xunit_issue
{
    public class TimeProviderTests
    {
        [Fact]
        public void Returns_Correct_Value_With_Fact()
        {
            // TimeProvider.Now returns "TestString" as expected and the test case passed without issue
            var now = TimeProvider.Now;
            Assert.Equal("TestString", now);
        }
        
        [Theory]
        [InlineData(88)]
        [InlineData(66)]
        public void Returns_Null_For_Second_InlineData_With_Theory(int id)
        {
            // there should be two runs for this test case
            // In the first run TimeProvider.Now returns "TestString" as expected and the test case passed without issue
            // In the second run TimeProvider.Now returns null instead of TestString causes the test case to fail
            // This is the question: why TimeProvider.Now didn't return the correct value in the second run
            var now = TimeProvider.Now;
            Assert.Equal("TestString", now);
        }
    }
}
