using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Models
{
    public interface IStdScoreRepository
    {
        Task<List<StdScore>> GetAll();
        Task Add(StdScore entity);
    }
}
