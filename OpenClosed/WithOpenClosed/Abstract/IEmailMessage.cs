using System.Threading.Tasks;
using OpenClosed.WithOpenClosed.Concrete;

namespace OpenClosed.WithOpenClosed.Abstract
{
    public interface IEmailMessage : IMessage
    {
        Task<MessageModel> CreateEmailMessage(MessageModel message); 
    }
}