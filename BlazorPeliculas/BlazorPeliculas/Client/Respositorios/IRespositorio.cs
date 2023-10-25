using BlazorPeliculas.Shared.Entidades;

namespace BlazorPeliculas.Client.Respositorios
{
    public interface IRepositorio
    {
        List<Pelicula> ObtenerPeliculas();
    }
}
