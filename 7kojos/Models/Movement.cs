﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace _7kojos.Models
{
    public interface Movement
    {
        Point Move(Point currentPos);
        Movement Clone();
    }
}
