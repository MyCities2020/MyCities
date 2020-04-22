using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCities.Models
{
    public class Batiment
    {
        protected string Nom { get; set; }
        protected string Categorie { get; set; }
        protected string Localisation { get; set; }
        protected string Adresse { get; set; }
        protected string Architecte { get; set; }
        protected string Periode_construction { get; set; }
        protected string Style { get; set; }
        protected string Siteweb { get; set; }
    }
}
