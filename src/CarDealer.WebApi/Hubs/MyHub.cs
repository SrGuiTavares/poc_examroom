using Microsoft.AspNetCore.SignalR;

namespace CarDealer.WebApi.Hubs
{
    public class MyHub : Hub
    {
        public  async IAsyncEnumerable<DateTime> Streaming(CancellationToken cancellationToken)
        {
            while (true)
            {
                yield return DateTime.UtcNow;
                await Task.Delay(1000, cancellationToken);
            }
        }
    }
}
