To reproduce the reported issue, follow the steps below:

1. Install .NET Core SDK (> 2.1) from [Microsoft Web Site](https://www.microsoft.com/net/download)

1. Clone this repo and run the command
- dotnet restore
- dotnet test

The output of the test result should say something like this:
```
[xUnit.net 00:00:00.6301110]     xunit_issue.TimeProviderTests.Returns_Null_For_Second_InlineData_With_Theory(id: 88) [FAIL]
[xUnit.net 00:00:00.6349340]     xunit_issue.TimeProviderTests.Returns_Correct_Value_With_Fact [FAIL]
Failed   xunit_issue.TimeProviderTests.Returns_Null_For_Second_InlineData_With_Theory(id: 88)
Error Message:
 Assert.Equal() Failure
Expected: TestString
Actual:   (null)
Stack Trace:
   at xunit_issue.TimeProviderTests.Returns_Null_For_Second_InlineData_With_Theory(Int32 id) in /Users/james/Projects/Practices/xunit-issue/UnitTest1.cs:line 26
Failed   xunit_issue.TimeProviderTests.Returns_Correct_Value_With_Fact
Error Message:
 Assert.Equal() Failure
Expected: TestString
Actual:   (null)
Stack Trace:
   at xunit_issue.TimeProviderTests.Returns_Correct_Value_With_Fact() in /Users/james/Projects/Practices/xunit-issue/UnitTest1.cs:line 13

Total tests: 3. Passed: 1. Failed: 2. Skipped: 0.
Test Run Failed.
```

1. Read the comments in UnitTest1.cs to know where the issue is.