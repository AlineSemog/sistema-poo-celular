namespace DesafioPOO.Models
{
    public class Smartphone
    {
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string Imei { get; set; }
        protected int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }
        //public virtual
        public virtual void InstalarAplicativo(string nomeApp)
        {
           
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no {Modelo}");
        }
    }
}