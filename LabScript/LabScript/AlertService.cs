
using System.Runtime.Serialization;
using Microsoft.JSInterop;

namespace LabScript
{
    public class AlertService : IAsyncDisposable, IAlertService
    {
        private readonly Lazy<Task<IJSObjectReference>> jsObjectReference;

        public AlertService(IJSRuntime jsRuntime)
        {
            this.jsObjectReference = new Lazy<Task<IJSObjectReference>>(() =>
                jsRuntime.InvokeAsync<IJSObjectReference>("import", "./Home.js").AsTask());
        }

        public async ValueTask DisposeAsync()
        {
            if (jsObjectReference.IsValueCreated)
            {
                IJSObjectReference moduleJs = await jsObjectReference.Value;
                await moduleJs.DisposeAsync();
            }
        }

public async Task CallJsAlertFunction()
        {
            var jsModule = await jsObjectReference.Value;
            await jsModule.InvokeVoidAsync("jsFuncion");
        }
    }
}
