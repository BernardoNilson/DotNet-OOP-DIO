namespace DotNet_OOP_DIO.Models
{
    public abstract class Smartphone
    {
        protected Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }
        public string Numero { get; set; }
        // Implementar as propriedades faltantes de acordo com o diagrama
        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private string imei;
        public string Imei
        {
            get { return imei; }
            set { imei = value; }
        }

        private int memoria;
        public int Memoria
        {
            get { return memoria; }
            set { memoria = value; }
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