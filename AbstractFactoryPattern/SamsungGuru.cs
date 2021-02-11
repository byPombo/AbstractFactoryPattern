using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// ProdutoB2
    /// </summary>
    public class SamsungGuru : INormalPhone
    {
        public string BuscarDetalhesModelo()
        {
            return "Modelo: Samsung Guru\nRAM: NA\nCamera: NA\n";
        }
    }
}
