using Application.StdScore;
using Client.Hubs.Enum;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace Client.Hubs
{
    public class ScoreHub : Hub
    {
        private readonly IStdScoreService _service;
        public ScoreHub(IStdScoreService service)
        {
            _service = service;
        }

        public async Task ServerAddScore(decimal score)
        {
            var hubResponse = HubResponse.Failure;
            try
            {
                await _service.Add(new StdScoreDTO
                {
                    Score = score
                });
                hubResponse = HubResponse.Success;
            }
            catch (Exception ex)
            {
                //log
            }

            await Clients.All.SendAsync("ClientAddScore", (int)hubResponse);
        }

    }
}
