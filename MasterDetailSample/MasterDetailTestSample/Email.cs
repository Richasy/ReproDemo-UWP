using System.Collections.Generic;

namespace MasterDetailTestSample
{
    public class Email
    {
        public string From { get; set; }
        public string Body { get; set; }
    }

    public class MyEmailManager
    {
        public static List<Email> GetEmails()
        {
            var MyEmails = new List<Email>
            {
                new Email
                {
                    From = "Steve Johnson",
                    Body = "Are you available for lunch tomorrow? A client would like to discuss a project with you."
                },
                new Email
                {
                    From = "Pete Davidson",
                    Body = "Don't forget the kids have their soccer game this Friday. We have to supply end of game snacks."
                },
                new Email
                {
                    From = "OneDrive",
                    Body = "Your new album.\r\nYou uploaded some photos to yuor OneDrive and automatically created an album for you."
                },
                new Email
                {
                    From = "Twitter",
                    Body = "Here are some people we think you might like to follow:\r\n.@randomPerson\r\nAPersonYouMightKnow"
                }
            };

            return MyEmails;
        }
    }
}
