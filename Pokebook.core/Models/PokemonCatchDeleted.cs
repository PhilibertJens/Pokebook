﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebook.core.Models
{
    public class PokemonCatchDeleted: EntityBase
    {
        public Guid PokemonId { get; set; }
        public Guid UserId { get; set; }

        public int HP { get; set; }
        public int CP { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }
        public bool Gender { get; set; }
        public bool IsShiny { get; set; }
        public bool IsAlolan { get; set; }
        public string FolderType { get; set; }
        public string Nickname { get; set; }
        public string AppType { get; set; }
        public int CurrentCP { get; set; }
        public int CurrentHP { get; set; }
        public string HPColor { get; set; }
        public string CatchLocation { get; set; }

        public DateTime Deleted { get; set; }

        /*Navigation properties*/
        public Pokemon Pokemon { get; set; }
        public User User { get; set; }
        //public ICollection<PokemonMoveCatch> PokemonMoveCatches { get; set; }
    }
}
