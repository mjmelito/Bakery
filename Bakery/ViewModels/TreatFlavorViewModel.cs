using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.ViewModels
{
    public class TreatFlavorViewModel
    {
        public List<Treat> Treats { get; set; }
        public List<Flavor> Flavors { get; set; }
    }
}