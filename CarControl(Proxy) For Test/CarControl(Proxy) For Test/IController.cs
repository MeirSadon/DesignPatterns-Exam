﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarControl_Proxy__For_Test
{
    public interface IController
    {
        void StartDriving();
        void StopDriving();
        void Turbo();
        void SlowDown();
        void TurnRight();
        void TurnLeft();

    }
}
