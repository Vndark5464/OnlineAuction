using OnlineAuction.Models;

namespace OnlineAuction.Data.Services
{
    public interface ICommentsService
    {
        Task Add(Comment comment);
    }
}
