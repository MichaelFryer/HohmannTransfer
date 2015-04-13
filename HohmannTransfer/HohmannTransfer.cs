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
    public class HohmannTransfer
    {
        private double v1; 
        private double v2;
        private double r1;
        private double r2;
        private double u;

        /// <summary>Calculate delta-v requirements for a Hohmann transfer</summary>
        /// <param name="r1">Initial circular orbit radius</param>
        /// <param name="r2">Final circular orbit radius</param>
        /// <param name="u">Standard gravity parameter for parent body</param>
        public HohmannTransfer(double r1, double r2, double u)
        {
            R1 = r1;
            R2 = r2;
            U = u;
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
        public double R1 { get { return r1; } 
            set {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("r1", "Initial orbit radius must be greater than 0");
                r1 = value; 
                Update(); 
            } 
        }

        /// <summary>
        /// Radius of the initial circular orbit </summary>
        public double R2
        {
            get { return r2; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("r2", "Final orbit radius must be greater than 0");
                r2 = value; 
                Update();
            }
        }

        /// <summary>
        /// Radius of the initial circular orbit </summary>
        public double U
        {
            get { return u; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("u", "Standard gravitational paremeter must be greater than 0");
                u = value; 
                Update();
            }
        }

        /// <summary>
        /// Calculate v1 and v2 based on current r1, r2 and u</summary>
        private void Update()
        {
            v1 = Math.Sqrt(u / r1) * (Math.Sqrt((2 * r2) / (r1 + r2)) - 1);
            v2 = Math.Sqrt(u / r2) * (1 - Math.Sqrt((2 * r1) / (r1 + r2)));
        }
    }
}
