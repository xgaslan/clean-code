using System.Collections.Generic;
using System.Threading.Tasks;
using OpenClosed.WithOpenClosed.Concrete;

namespace OpenClosed.WithOpenClosed.Abstract
{
    public interface ISystemMessage : IMessage
    {
        Task<List<MessageModel>> GetSystemMessagesAsync();
    }
}