using Domain.Entities;

namespace Domain.Repositories;
public interface IEmbassyRepository: IRepository<Embassy> 
{
    Task Suspend(Guid id, string reason, DateTime date);
    Task Reopend(Guid id);
}