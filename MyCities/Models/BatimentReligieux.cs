using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace MyCities.Models
{
    public class BatimentReligieux : Batiment
    {
        protected string TypeReligieux { get; set; }
        protected string Culte { get; set; }
    }
}
