﻿using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Repositories.Specific
{
    public interface IPokemonRepository : IRepository<Pokemon>
    {
        Task<Pokemon> GetByName(string name);
    }
}