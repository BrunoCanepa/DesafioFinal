namespace Ucu.Poo.Defense
{
    public class Material
    {
        public string Name { get; set; }

        public MaterialType Type { get; set; }
        //Agregué una propiedad para saber si IsDangerous es true o false
        public bool IsDangerous { get; set; }

        public Material(string name, MaterialType type)
        {
            this.Name = name;
            this.Type = type;
            this.IsDangerous = type.IsDangerous;
        }
    }
}