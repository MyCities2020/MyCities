using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCities.Models
{
    public class BatimentReligieux : Batiment
    {
        protected string TypeReligieux { get; set; }
        protected string Culte { get; set; }
    }
}
