﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagCloudGraphicalUserInterface
{
    public interface IActionForm
    {
        string Category { get; }
        string Name { get; }
        string Description { get; }
        void Perform();
    }
}
