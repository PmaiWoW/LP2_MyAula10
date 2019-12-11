using System;
using System.Collections.Generic;
using System.Text;

namespace OperOver
{
    public struct Vector3
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float Magnitude =>
            MathF.Sqrt(MathF.Pow(X, X) + MathF.Pow(X, X) + MathF.Pow(Z, Z));

        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static bool operator >(Vector3 v1, Vector3 v2) =>
            v1.Magnitude > v2.Magnitude;

        public static bool operator <(Vector3 v1, Vector3 v2) =>
            v1.Magnitude < v2.Magnitude;
    }
}
