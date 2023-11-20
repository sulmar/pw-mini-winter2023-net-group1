using Infrastructure;

namespace IssueTracker.UnitTests
{
    public class FakeInvalidFileReader : IFileReader
    {
        public string ReadAllText(string fileName) => "a";
    }
}