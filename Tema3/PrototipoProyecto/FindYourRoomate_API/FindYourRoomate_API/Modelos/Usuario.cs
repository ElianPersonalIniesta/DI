using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
namespace FindYourRoomate_API.Modelos
{
    /// <summary>
    /// Modelo de datos Usuario
    /// <para>Tiene los siguientes atributos:</para>
    /// <list type="bullet">
    /// <item><b>String</b>Id</item>
    /// <item><b>String</b>Nombre</item>
    /// <item><b>String</b>Email</item>
    /// <item><b>Int</b>Edad</item>
    /// <item><b>String</b>Localizacion</item>
    /// <item><b>Boolean</b>HaEncontradoPiso</item>
    /// <item><b>DateTime</b>FechaRegistro</item>
    /// <item><b>PreferenciaBusqueda <cref="PreferenciaBusqueda"/></b>PreferenciaBusqueda</item>
    /// </list>
    /// </summary>
    public class Usuario
    {


        //Propiedades del modelo Usuario

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
       
        [Range (18,100)]
        public int Edad { get; set; }

        public string Localizacion { get; set; }
        public bool HaEncontradoPiso { get; set; } = false;
        public DateTime FechaRegistro { get; set; } = DateTime.UtcNow;

    }
}
public class PreferenciaBusqueda
{
    public string CiudadInteres { get; set; }
    public decimal PresupuestoMax { get; set; }
    public string TipoHabitacion { get; set; }
}