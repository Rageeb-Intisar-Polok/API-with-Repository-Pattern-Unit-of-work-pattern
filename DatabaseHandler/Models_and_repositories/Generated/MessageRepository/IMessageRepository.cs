using DatabaseHandler.Models.Generated;

namespace DatabaseHandler.Models_and_repositories.Generated.MessageRepository
{
    public interface IMessageRepository
    {
        public Task<List<Message>> getLastMessage(String UserId);
        public Task<List<Message>> getNextMessage(String UserId, String MessageId);
    }
}
