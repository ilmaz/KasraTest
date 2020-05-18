using Domain.Models;
using Mapster;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.StdScore
{
    public class StdScoreService : IStdScoreService
    {
        private readonly IStdScoreRepository _repository;
        public StdScoreService(IStdScoreRepository repository)
        {
            _repository = repository;
        }

        public async Task Add(StdScoreDTO dto)
        {
            var entity = dto.Adapt<Domain.Models.StdScore>();
            await _repository.Add(entity);
        }

        public async Task<List<StdScoreDTO>> GetAll()
        {
            var result = await _repository.GetAll();
            return result.Adapt<List<StdScoreDTO>>();
        }
    }
}
