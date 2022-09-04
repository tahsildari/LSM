﻿namespace LSM.Dto
{
    public class BuildingDto : IWeighted
    {
        public string Shortcut { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }


        public int SearchWeight { get; set; }
    }
}
