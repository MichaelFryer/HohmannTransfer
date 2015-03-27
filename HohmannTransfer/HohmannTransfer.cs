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
    class HohmannTransfer
    {
        private double v1; 
        private double v2;
        private double r1;
        private double r2;
        private double u;

        /// <summary>Description for SomeMethod.</summary>
        /// <param name="s"> Parameter description for s goes here</param>
        /// <seealso cref="String">
        /// You can use the cref attribute on any tag to reference a type or member 
        /// and the compiler will check that the reference exists. </seealso>
        public HohmannTransfer(double r1, double r2, double u)
        {
            this.r1 = r1;
            this.r2 = r2;
            this.u = u;
            Update();
        }

        /// <summary>
        /// Delta-v to enter the elliptical orbit from the initial circular orbit </summary>
        public double V1 { get { return v1; } }

        /// <summary>
        /// Delta-v to enter the desired circular orbit from the elliptical orbit entered using V1 </summary>
        public double V2 { get { return v2; } }

        /// <summary>
        /// Radius of the initial circular orbit </summary>
        /// <value>
        /// Radius of the initial circular orbit in m</value>
        public double R1 { get { return r1; } set { r1 = value; Update(); } }

        /// <summary>
        /// Radius of the desired circular orbit </summary>
        public double R2 { get { return r2; } set { r2 = value; Update(); } }

        /// <summary>
        /// Standard gravitational parameter of the parent body </summary>
        public double U { get { return u; } set { u = value; Update(); } }

        private void Update()
        {
            v1 = Math.Sqrt(u / r1) * (Math.Sqrt((2 * r2) / (r1 + r2)) - 1);
            v2 = Math.Sqrt(u / r2) * (1 - Math.Sqrt((2 * r1) / (r1 + r2)));
        }
    }
}
