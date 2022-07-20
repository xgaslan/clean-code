using System.Collections.Generic;
using System.Threading.Tasks;
using OpenClosed.WithOpenClosed.Concrete;

namespace OpenClosed.WithOpenClosed.Abstract
{
    public interface IMessage
    {
        Task<MessageModel> SendMessage(MessageModel message);

        Task<List<MessageModel>> GetMessages();
    }
}