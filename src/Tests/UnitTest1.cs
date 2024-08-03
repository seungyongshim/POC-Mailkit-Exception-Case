using MimeKit;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var address = (MailboxAddress.TryParse(new(),
         "11@11.11", out var v), v) switch
        {
            (true, { } k) => k,
            (false, _) => null,
        };
    }
}
