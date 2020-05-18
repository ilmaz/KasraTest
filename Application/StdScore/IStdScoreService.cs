using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.StdScore
{
    public interface IStdScoreService
    {
        Task<List<StdScoreDTO>> GetAll();
        Task Add(StdScoreDTO dto);
    }
}
