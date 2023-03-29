namespace Mascota.Core;
public class Tamagotchi
{
        public int Nivel { get; private set; }
        public IEstado Estado { get; private set; }

        public Tamagotchi(int nivel, IEstado estado)
        {
            Nivel = nivel;
            Estado = estado;
        }

        public void Jugar() => Estado.Jugar(this); 
        public void Comer() => Estado.Comer(this);
        public void CambiarEstado(IEstado estado){}
        public void IncrementarNivel(int n) => Nivel = Nivel + 1;
            
}
