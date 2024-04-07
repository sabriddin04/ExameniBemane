using Domain.Models;

namespace Infrastructure.Interfaces;

public interface IParentService
{
    Task<List<Parents>> GetParents();
    Task AddParent(Parents parent);
    Task UpdateParent(Parents parent);
    Task DeleteParent(int parentId);
}
