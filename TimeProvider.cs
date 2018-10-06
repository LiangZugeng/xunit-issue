namespace xunit_issue
{
    using System;
    using System.Threading;

    /// <summary>
    /// Provides methods to deal with time.
    /// </summary>
    public static class TimeProvider
    {
        private static AsyncLocal<string> defaultProvider = new AsyncLocal<string>() { Value = "TestString" };

        public static string Now
        {
            get { return defaultProvider.Value; }
        }
    }
}