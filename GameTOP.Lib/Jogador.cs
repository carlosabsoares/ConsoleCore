using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador : iJogador
    {
            public readonly string _Nome ;

            public Jogador(string nome)
            {
                _Nome = nome;
            }

            //Chutar
            public string Chuta()
            {
                return $"{_Nome} está chutando" ;
            }

            //Corre
            public string Corre()
            {
                return $"{_Nome} está correndo";
            }

            //Passe
            public string Passa()
            {
               return $"{_Nome} está passando";
            }
    }
}