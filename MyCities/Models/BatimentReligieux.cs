using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace MyCities.Models
{
    public enum TypeCulte
    {
        Catholique,
        Protestant,
        Musulman,
        Juif,
        Bouddhiste
    }
    public class BatimentReligieux : Batiment
    {
        protected string TypeReligieux { get; set; }
        protected TypeCulte Culte { get; set; }
    }
}
