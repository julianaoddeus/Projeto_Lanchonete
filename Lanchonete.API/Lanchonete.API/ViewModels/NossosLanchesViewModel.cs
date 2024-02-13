﻿using Lanchonete.API.Models;
using System.Collections.Generic;

namespace Lanchonete.API.ViewModels
{
    public class LanchesViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }
        public int CategoriaId { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
