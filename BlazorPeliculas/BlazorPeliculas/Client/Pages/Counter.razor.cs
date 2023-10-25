using BlazorPeliculas.Shared.Entidades;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorPeliculas.Client.Pages
{
    public partial class Counter
    {
        [Inject]
        ServicioSingleton singleton { get; set; } = null!;

        [Inject]
        protected IJSRuntime JS { get; set; } = null!;

        private int currentCount = 0;
        private static int currentCountStatic = 0;       

        private async Task IncrementCount()
        {
            currentCount++;
            currentCountStatic = currentCount;
            singleton.Valor = currentCount;
            await JS.InvokeVoidAsync("pruebaPuntoNetStatic");
        }

        List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>()
            {
                new Pelicula{Titulo = "Spider-Man: Far From Home", FechaLanzamiento = new DateTime(2022, 11, 11)},
                new Pelicula{Titulo = "Avengers End Game", FechaLanzamiento = new DateTime(2016, 11, 23)}
            };
        }

        [JSInvokable]
        public static Task<int> ObtenerCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
    }
}
