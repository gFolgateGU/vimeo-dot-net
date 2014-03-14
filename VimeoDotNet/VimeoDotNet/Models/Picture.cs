﻿using System;

namespace VimeoDotNet.Models
{
    [Serializable]
    public class Picture
    {
        public string type { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string link { get; set; }
    }
}