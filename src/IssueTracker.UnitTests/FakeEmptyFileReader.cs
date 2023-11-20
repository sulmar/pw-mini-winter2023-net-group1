using Infrastructure;

namespace IssueTracker.UnitTests
{
    public class FakeEmptyFileReader : IFileReader
    {
        public string ReadAllText(string fileName) => string.Empty;
    }
}