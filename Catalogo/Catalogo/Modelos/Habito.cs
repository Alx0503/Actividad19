namespace Catalogo.Modelos
{
    public class Habito
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        virtual public ICollection<Persona>? Personas { get; set; } 
    }
}
