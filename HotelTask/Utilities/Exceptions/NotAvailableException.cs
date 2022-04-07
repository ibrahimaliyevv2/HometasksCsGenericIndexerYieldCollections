using System;
namespace Utilities.Exceptions
{
    public class NotAvailableException:Exception
    {
        public NotAvailableException()
        {

        }

        private string _message;
        public override string Message { get => _message}

        public NotAvailableException(string message): base(message) {
            _message = message;
        }
    }
}
