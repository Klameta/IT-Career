﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skeleton.Interfaces
{
   public  interface ITarget
    {
        int Health { get; }
        void TakeAttack(int attackpoints);
        int GiveExperience();
        bool IsDead();
    }
}
