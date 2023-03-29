namespace Mascota.Core
{
    public class Contento : IEstado
    {
        public void Comer(Tamagotchi tamagotchi) => tamagotchi.IncrementarNivel(1);
        public void Jugar(Tamagotchi tamagotchi) => tamagotchi.IncrementarNivel(2);
    }
}