using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFoda
    {
        
        private readonly iJogador _jogadorA;
        private readonly iJogador _jogadorB;

        public JogoFoda(iJogador jogadorA, iJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }
        

        public void IniciarJogo()
        {
            //System.Console.WriteLine($"{_jogador._Nome} deu um passe");
            System.Console.WriteLine(_jogadorA.Corre());
            System.Console.WriteLine(_jogadorA.Chuta());
            System.Console.WriteLine(_jogadorA.Passa());

            System.Console.Write("\nPRÓXIMO JOGADOR \n");

            System.Console.WriteLine(_jogadorB.Corre());
            System.Console.WriteLine(_jogadorB.Chuta());
            System.Console.WriteLine(_jogadorB.Passa());
        }
        
    }
}