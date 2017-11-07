using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture9lab1
{
    class Email : Document
    {
        // Instance Variable
        protected string sender;
        protected string recipient;
        protected string title;

        // Mutators
        // Sets Sender
        public void SetSender(string sender)
        {
            this.sender = sender;
        }

        // Sets Recipient
        public void SetRecipient(string recipient)
        {
            this.recipient = recipient;
        }

        // Sets Title
        public void SetTitle(string title)
        {
            this.title = title;
        }

        // Sets Email Text
        public new void SetText(string emailText)
        {
            base.SetText(emailText);
        }

        // Accessors
        // Gets the Sender
        public string GetSender()
        {
            return sender;
        }

        // Gets the Recipient
        public string GetRecipient()
        {
            return recipient;
        }

        // Gets the Title
        public string GetTitle()
        {
            return title;
        }

        // Utility Methods
        public override string ToString()
        {
            return String.Format("Sender: {0}\nRecipient: {1}\n\nTitle: {2}\nBody: {3}",
                                  GetSender(), GetRecipient(), GetTitle(), base.ToString());
        }
    }
}
