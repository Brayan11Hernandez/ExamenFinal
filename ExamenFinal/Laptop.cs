using System.Reflection.Metadata;

namespace ExamenFinal
{
    public class Laptop:Dispositivos
    {
        public int MemoriaRam {  get; set; }
        public string Almacenamiento {  get; set; }
        public Laptop()
        {
            MemoriaRam = 0;
            Almacenamiento = string.Empty;
        }
    }
}
