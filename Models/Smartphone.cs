namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string numero { get; set; };
        private string modelo { get; set; };
        private string IMEI { get; set; };
        private int memoria;

        public Smartphone(string numero, string modelo, string IMEI, int memoria)
        {
            //os valores são alterados de acordo com o código da classe principal
            numero = numero;
            modelo = modelo;
            IMEI - IMEI;
            memoria = memoria;
            
        }
       

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}