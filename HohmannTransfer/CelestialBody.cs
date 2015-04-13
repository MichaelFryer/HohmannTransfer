//HohmannTransfer Calculator
//Copyright (C) 2015 Michael Fryer
//
//HohmannTransfer Calculator is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.
//
//HohmannTransfer Calculator is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.
//
//You should have received a copy of the GNU General Public License
//along with HohmannTransfer Calculator.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hohmann_Transfer
{
    public class CelestialBody
    {
        static readonly double gravityConstant = 6.673e-11;

        private readonly string name;
        private readonly double mass;
        private readonly double radius;
        private readonly double gravityParameter;

        public CelestialBody(string name, double mass, double radius)
        {
            this.name = name;
            this.mass = mass;
            this.radius = radius;
            this.gravityParameter = mass * gravityConstant;
        }

        /// <summary>
        /// Convert a height above sea level to a distance from the body focus</summary>
        /// <param name="height">Height above sea level in meters</param>
        /// <returns> 
        /// Distance from body focus in meters</returns> 
        public double SeaHeightToFocusDistance(double height)
        {
            return height + radius;
        }

        /// <summary>
        /// Convert a distance from the body focus to a height above sea level (meters)</summary>
        /// <param name="height">Distance from body focus in meters</param>
        /// <returns> 
        /// Height above sea level in meters</returns> 
        public double FocusDistanceToSeaHeight(double distance)
        {
            return distance - radius;
        }



        public string Name { get { return name; } }
        public double Mass { get { return mass; } }
        public double Radius { get { return radius; } }
        public double GravityParameter { get { return gravityParameter; } }
    }
}
