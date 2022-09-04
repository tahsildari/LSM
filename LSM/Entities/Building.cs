﻿using LSM.Attributes;

namespace LSM.Entities
{
    public class Building
    {
        public int Id { get; set; }

        [Weight(7)]
        public string Shortcut { get; set; }

        [Weight(9)]
        public string Name { get; set; }

        [Weight(5)]
        public string Description { get; set; }
    }
}
