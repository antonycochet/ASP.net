using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using System.Threading.Tasks;
using Pizza.Utils;
using Pizza.Models;

namespace Pizza.Models
{
    public class PizzaViewModel
    {
        public PizzaModel Pizza { get; set; }
        public List<SelectListItem> Ingredients { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Pates { get; set; } = new List<SelectListItem>();

        [Required]
        public int? IdPate { get; set; }
        public List<int> IdsIngredients { get; set; } = new List<int>();


    }
}
