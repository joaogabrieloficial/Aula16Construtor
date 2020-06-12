namespace Aula16MetódoConstrutor
{
    public class Personagem
    {
        public string Nome { get; set; }
        public string Shikai { get; set; }
        public string Bankai { get; set; }
        public int Esquadrao { get; set; }
        public int Poder { get; set; }


        public Personagem(){

        }

        public Personagem(string _nome){
            this.Nome =_nome;
        }
        public Personagem(string _nome, string _shikai, string _bankai, int _esquadrao, int _poder ){
            this.Nome = _nome;
            this.Shikai = _shikai;
            this.Bankai = _bankai;
            this.Esquadrao = Esquadrao;
            this.Poder = _poder; 
        }
    }
}