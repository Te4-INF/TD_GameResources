﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TowerDefenceINF.GameResources.Code
{
    class FireShot : Shots
    {

        public FireShot(Texture2D texture, Vector2 pos, Enemy enemy) : base(texture, pos, enemy)
        {
            

        }
    }
}
