// initial all message getting is configured. rest of the entire required
// configuration is still need to program.

using DatabaseHandler.Context;
using DatabaseHandler.Models.Generated;
using Microsoft.EntityFrameworkCore;

namespace DatabaseHandler.Models_and_repositories.Generated.MessageRepository
{
    public class MessageRepository : IMessageRepository
    {
        public readonly ApplicationDbContext _context;
        public MessageRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Message>> getLastMessage(string UserId)
        {
            List<Message> msgs = await _context.messages.FromSqlRaw<Message>("InitialGetMessageOfConnectionId {0}", UserId).ToListAsync();
            return msgs;
          //  return _context.messages.FromSqlRaw<Message>("InitialGetMessageOfConnectionId {0}", UserId).ToList<Message>();
        }
        public async Task<List<Message>> getNextMessage(String UserId, String MessageId)
        {
            List<Message> msgs = await _context.messages.FromSqlRaw<Message>("InitialGetMessageOfConnectionId {0}", UserId).ToListAsync();
            //  return _context.messages.FromSqlRaw<Message>("InitialGetMessageOfConnectionId {0}", UserId).ToList<Message>();
            return msgs;
        }
    }
}
