using Lanchonete.API.Models;
using System.Collections.Generic;

namespace Lanchonete.API.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Lanche> LanchesPreferidos { get; set; }
    }
}
