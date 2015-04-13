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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hohmann_Transfer;

namespace HohmannTransferTests
{
    [TestClass]
    public class HohmannTransferTests
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_R1IsZero_ThrowException()
        {
            new HohmannTransfer(0, 1, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_R2IsZero_ThrowException()
        {
            new HohmannTransfer(1, 0, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_UIsZero_ThrowException()
        {
            new HohmannTransfer(1, 1, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_R1IsNegative_ThrowException()
        {
            new HohmannTransfer(-1000, 1, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_R2IsNegative_ThrowException()
        {
            new HohmannTransfer(1, -1000, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_UIsNegative_ThrowException()
        {
            new HohmannTransfer(1, 1, -1000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void R1_SetZero_ThrowException()
        {
            HohmannTransfer t = new HohmannTransfer(1, 1, 1);
            t.R1 = 0;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void R2_SetZero_ThrowException()
        {
            HohmannTransfer t = new HohmannTransfer(1, 1, 1);
            t.R2 = 0;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void U_SetZero_ThrowException()
        {
            HohmannTransfer t = new HohmannTransfer(1, 1, 1);
            t.U = 0;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void R1_SetNegative_ThrowException()
        {
            HohmannTransfer t = new HohmannTransfer(1, 1, 1);
            t.R1 = -1000;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void R2_SetNegative_ThrowException()
        {
            HohmannTransfer t = new HohmannTransfer(1, 1, 1);
            t.R2 = -1000;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void U_SetNegative_ThrowException()
        {
            HohmannTransfer t = new HohmannTransfer(1, 1, 1);
            t.U = -1000;
        }

        [TestMethod]
        public void Constructor_CalculateRaiseOrbit_CalculationsCorrect()
        {
            // Raise orbit from 10km to 999km around Mun
            HohmannTransfer t = new HohmannTransfer(210000, 1199000, 65128637482.8);
            Assert.AreEqual(169.6175, t.V1, 0.0001);
            Assert.AreEqual(105.8182, t.V2, 0.0001);
        }

        [TestMethod]
        public void Constructor_CalculateLowerOrbit_CalculationsCorrect()
        {
            // Lower orbit from 4000km to 250km around Eve
            HohmannTransfer t = new HohmannTransfer(4700000, 950000, 8170505947100);
            Assert.AreEqual(-553.8969, t.V1, 0.0001);
            Assert.AreEqual(-850.0377, t.V2, 0.0001);
        }

        [TestMethod]
        public void R1_Set_UpdateSucceeded()
        {
            // Raise orbit from 100km to 200km around Kerbin, construct with dummy r1 value
            HohmannTransfer t = new HohmannTransfer(1, 800000, 3531070866890);
            t.R1 = 700000;
            Assert.AreEqual(700000, t.R1, 0.0001);

            // Updates to R1, R2 & U should prompt a recalculation of V1 & V2
            Assert.AreEqual(73.6579, t.V1, 0.0001);
            Assert.AreEqual(71.2382, t.V2, 0.0001);
        }
        [TestMethod]
        public void R2_Set_UpdateSucceeded()
        {
            // Raise orbit from 100km to 200km around Kerbin, construct with dummy r2 value
            HohmannTransfer t = new HohmannTransfer(700000, 1, 3531070866890);
            t.R2 = 800000;
            Assert.AreEqual(800000, t.R2, 0.0001);

            // Updates to R1, R2 & U should prompt a recalculation of V1 & V2
            Assert.AreEqual(73.6579, t.V1, 0.0001);
            Assert.AreEqual(71.2382, t.V2, 0.0001);
        }
        [TestMethod]
        public void U_Set_UpdateSucceeded()
        {
            // Raise orbit from 100km to 200km around Kerbin, construct with dummy u value
            HohmannTransfer t = new HohmannTransfer(700000, 800000, 1);
            t.U = 3531070866890;
            Assert.AreEqual(3531070866890, t.U, 0.0001);

            // Updates to R1, R2 & U should prompt a recalculation of V1 & V2
            Assert.AreEqual(73.6579, t.V1, 0.0001);
            Assert.AreEqual(71.2382, t.V2, 0.0001);
        }

    }
}
