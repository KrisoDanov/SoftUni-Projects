﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P03_FootballBetting.Data.Models
{
    public class Color
    {
        public Color()
        {
            PrimaryKitTeams = new HashSet<Team>();
            SecondaryKitTEam = new HashSet<Team>();
        }
        public int ColorId { get; set; }
       
        public string Name { get; set; }
        public virtual ICollection<Team> PrimaryKitTeams { get; set; }
        public virtual ICollection<Team> SecondaryKitTEam { get; set; }
    }
}
