using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouradniceMichalRocek
{
    internal class Coord : IEquatable<Coord>, IComparable<Coord>
    {
        public Coord(int x, int y)
        {
            X = x;
            Y = y;
        }
        public bool Equals(Coord? other)
        {
            return X == other.X && Y == other.Y;
        }
        public int CompareTo(Coord? other)
        {
            if (Magnitude > other.Magnitude) return 1;
            else if (Magnitude < other.Magnitude) return -1;
            return 0;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public int Magnitude { get { return X * X + Y * Y; } }

        //přetížení porovnávacích operátorů
        public static bool operator ==(Coord? coord, Coord? other)
        {
            return coord.Equals(other);
        }
        public static bool operator !=(Coord? coord, Coord? other)
        {
            return !coord.Equals(other);
        }
        public static bool operator >(Coord? coord, Coord? other)
        {
            return coord.CompareTo(other) == 1;
        }
        public static bool operator <(Coord? coord, Coord? other)
        {
            return coord.CompareTo(other) == -1;
        }
        //přetížení matematických operátorů
        public static Coord operator +(Coord? coord, Coord? other)
        {
            return new Coord(coord.X + other.X, coord.Y + other.Y);
        }
        public static Coord operator -(Coord? coord, Coord? other)
        {
            return new Coord(coord.X - other.X, coord.Y - other.Y);
        }
        public static Coord operator *(Coord? coord, double multiplier)
        {
            return new Coord((int)(coord.X * multiplier), (int)(coord.Y * multiplier));
        }
        public static Coord operator *(double multiplier, Coord? coord)
        {
            return new Coord((int)(coord.X * multiplier), (int)(coord.Y * multiplier));
        }
        public static Coord operator /(Coord? coord, double multiplier)
        {
            return new Coord((int)(coord.X / multiplier), (int)(coord.Y / multiplier));
        }

        //přetížení metody
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
