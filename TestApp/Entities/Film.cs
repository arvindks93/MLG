﻿using System;
using System.Collections.Generic;

namespace TestApp.Entities
{
    public partial class Film
    {
        public int FilmId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? ReleaseYear { get; set; }
        public string Rating { get; set; }
        public int? Runtime { get; set; }
    }
}
