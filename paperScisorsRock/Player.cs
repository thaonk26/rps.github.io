﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paperScisorsRock
{
    class Player
    {
        string name;
        string option;

        public Player(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
        public void setOption(string option)
        {
            this.option = option;
        }
        public string getOption()
        {
            return this.option;
        }
    }
}
