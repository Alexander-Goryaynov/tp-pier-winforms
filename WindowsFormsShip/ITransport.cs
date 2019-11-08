﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShip
{
    public interface ITransport
    {
        void SetPosition(int x, int y, int width, int height);
        void DrawShip(Graphics g);
        void MoveShip(Direction direction);
        void SetMainColor(Color color);
    }
}
