using System.Collections.Generic;
using System.Threading.Tasks;
using OpenClosed.WithOpenClosed.Abstract;

namespace OpenClosed.WithOpenClosed.Concrete
{
    public class EmailMessage: IEmailMessage
    {
        public async Task<MessageModel> SendMessage(MessageModel message)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<MessageModel>> GetMessages()
        {
            throw new System.NotImplementedException();
        }

        public async Task<MessageModel> CreateEmailMessage(MessageModel message)
        {
            throw new System.NotImplementedException();
        }
    }
}