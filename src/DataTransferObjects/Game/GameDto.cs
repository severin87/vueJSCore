﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects.Game
{
    public  class GameDto
    {
        public Guid Id { get; set; }

        public bool IsFinished { get; set; }

        public string PlayerSign { get; set; }
    }
}
