using System.Collections.ObjectModel;

namespace MasterDetailTestSample
{
    public class AppViewModel
    {
        public ObservableCollection<Email> Emails = new ObservableCollection<Email>();

        public AppViewModel()
        {
            var emails = MyEmailManager.GetEmails();
            emails.ForEach(email => Emails.Add(email));
        }
    }
}
