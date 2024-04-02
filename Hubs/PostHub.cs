using Microsoft.AspNetCore.SignalR;
using efept.Entities;

namespace efept.Hubs
{
    public class PostHub : Hub
    {
        public async Task EnviarPuntuacion(Puntuacion puntuacion)
        {
            await Clients.All.SendAsync("RecibirPuntuacion", puntuacion);
        }

        public async Task EnviarComentario(Comentario comentario)
        {
            await Clients.All.SendAsync("RecibirComentario", comentario);
        }
    }
}
