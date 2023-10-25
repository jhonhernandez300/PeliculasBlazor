function pruebaPuntoNetStatic() {
    DotNet.invokeMethodAync("BlazorPeliculas.Client", "ObtenerCurrentCount")
        .then(resultado => {
            console.log('conteo desde javascript ' + resultado);
        })
}