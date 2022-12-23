namespace Ucu.Poo.Defense
{
    //La operación que determinar si dos objetos son iguales es correcta, pero el método debe sobreescribir al método Equals de un objeto de tipo object.
    public class Material
    {
        public string Name { get; set; }

        public MaterialType Type { get; set; }

        public Material(string name, MaterialType type)
        {
            this.Name = name;
            this.Type = type;
        }

        /// <summary>
        /// Determina cuándo este material es igual a otro que se recibe como parámetro.
        /// </summary>
        /// <param name="obj">El objeto a comparar.</param>
        /// <returns><c>True</c> si este objeto es igual al que se recibe como parámetro; <c>False</c> en caso
        /// contrario.</returns>
        public override bool Equals(object obj)
        {
            // Si el otro objeto es null no puede ser igual a este objeto que no es null; retornar False
            if (obj == null)
            {
                return false;
            }
            // Si el otro objeto no es del mismo tipo que este objeto no pueden ser iguales; retornar False
            else if  (!this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            // Retornar True si el otro objeto tiene el mismo texto que este objeto; y False en caso contrario
            else
            {
                return this.Type.Equals(((Material)obj).Type) &&
                    this.Name.Equals(((Material)obj).Name);
            }
        }
    }
}