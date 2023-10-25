using BlazorPeliculas.Shared.Entidades;
using System.Runtime.CompilerServices;
using Microsoft.JSInterop;

namespace BlazorPeliculas.Client.Helpers
{
    public static class IJSRuntimeExtensionMethods
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("console.log", "Prueba de console log");
            return await js.InvokeAsync<bool>("confirm", message);
        }
    }
}
