﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdanEngine {
    public class Player: Entity {

        private Text Name;

        public Player(Animation animation, bool isColide, bool isGravity, string name) : base(animation, isColide, isGravity) {
            Name = new Text(FontType.Default, name, new Vector2(0, 0), Color.White, true, Color.Green);
        }

        public void MoveUp() {
            Rectangle.Y -= Speed;
        }

        public void MoveDown() {
            Rectangle.Y += Speed;
        }

        public void MoveRight() {
            Rectangle.X += Speed;
        }

        public void MoveLeft() {
            Rectangle.X -= Speed;
        }

        public override void Update() {

            base.Update();
        }

        public override void Draw() {
            Animation.Draw();
        }
    }
}
