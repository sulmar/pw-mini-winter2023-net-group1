using Infrastructure;

namespace IssueTracker.UnitTests
{
    public class FakeValidFileReader : IFileReader
    {
        public string ReadAllText(string fileName) => "{\"latitude\":\"21.01\",\"longitude\":\"51.01\"}";
    }
}