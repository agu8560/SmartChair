﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartChair.model
{
    public class SensorData
    {
        private float _bottomLeft, _bottomoRight, _topLeft, _topRight, _weightKg;
        private CenterOfGravity _cog;

        public CenterOfGravity Cog
        {
            get { return _cog; }
            set { _cog = value; }
        }

        public float WeightKg
        {
            get { return _weightKg; }
            set { _weightKg = value; }
        }

        public float TopRight
        {
            get { return _topRight; }
            set { _topRight = value; }
        }

        public float TopLeft
        {
            get { return _topLeft; }
            set { _topLeft = value; }
        }

        public float BottomoRight
        {
            get { return _bottomoRight; }
            set { _bottomoRight = value; }
        }

        public float BottomLeft
        {
            get { return _bottomLeft; }
            set { _bottomLeft = value; }
        }

        public SensorData(float bL, float bR, float tL, float tR, float wKg, CenterOfGravity cog){
            _bottomLeft = bL;
            _bottomoRight = bR;
            _topLeft = tL;
            _topRight = tR;
            _weightKg = wKg;
            _cog = cog;
        }

        public class CenterOfGravity
        {
            private float _X, _Y;

            public float Y
            {
                get { return _Y; }
                set { _Y = value; }
            }

            public float X
            {
                get { return _X; }
                set { _X = value; }
            }

            public CenterOfGravity(float X, float Y)
            {
                _X = X;
                _Y = Y;
            }
        }
    }
}