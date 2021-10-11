using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSecond
{
    class Triangle
    {
        #region Sides
        private float _a;
        public float A {
            get { return _a; }
            set {
                if (value > 0)
                    _a = value;
                else
                    throw new ArgumentException("Side a must be greater then 0");
            } 
        }

        private float _b;
        public float B
        {
            get { return _b; }
            set
            {
                if (value > 0)
                    _b = value;
                else
                    throw new ArgumentException("Side b must be greater then 0");
            }
        }

        private float _c;

        public float C
        {
            get { return _c; }
            set
            {
                if (value > 0)
                    _c = value;
                else
                    throw new ArgumentException("Side c must be greater then 0");
            }
        }
        #endregion

        public void SetSides(float a, float b, float c)
        {
            A = a;
            B = b;
            C = c;
        }

        public Triangle(float a, float b, float c)
        {
            A = a;
            B = b;
            C = c;
        }
        public Triangle(float side)
        {
            A = B = C = side;
        }

        public float Alpha
        {
            get { 
                return 0; 
            }
        }

        public float Beta
        {
            get
            {
                return 0;
            }
        }

        public float Gamma
        {
            get
            {
                return 0;
            }
        }

        public float Outline
        {
            get
            {
                return A + B + C;
            }
        }

        public float GetOutline()
        {
            return A + B + C;
        }
        public float Area
        {
            get
            {
                return 0;
            }
        }

        public float GetArea()
        {
            return 0;
        }

        /// <summary>
        /// Static method. Checks if triangle given by sides can be constructed.
        /// </summary>
        /// <param name="a">Side a</param>
        /// <param name="b">Side b</param>
        /// <param name="c">Side c</param>
        /// <returns>Bool. True if can be constructed, otherwise returns false.</returns>
        public static bool CanExists(float a, float b, float c)
        {
            float outline = a + b + c;
            float[] sides = new float[] { a, b, c };
            float maxSide = sides.Max();
            return maxSide < (outline - maxSide);
        }

        public bool IsExisting()
        {
            return CanExists(A, B, C);
        }
    }
}
