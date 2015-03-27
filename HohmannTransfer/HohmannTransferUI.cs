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
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hohmann_Transfer
{

    public partial class HohmannTransferUI : Form
    {
        static readonly double gravityConstant = 6.673e-11;

        private struct CelestialBody
        {
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

            public string Name { get { return name; } }
            public double Mass { get { return mass; } }
            public double Radius { get { return radius; } }
            public double GravityParameter { get { return gravityParameter; } }
        }

        static readonly IList<CelestialBody> bodyParamatersList = new ReadOnlyCollection<CelestialBody>
        (new[] {
            
             new CelestialBody ("Kerbol",       1.7565670e+28, 2.616e+8),
             new CelestialBody (" - Moho",      2.5263617e+21, 2.500e+5),
             new CelestialBody (" - Eve",       1.2244127e+23, 7.000e+5),
             new CelestialBody (" - - Gilly",   1.2420512e+17, 1.300e+4),
             new CelestialBody (" - Kerbin",    5.2915793e+22, 6.000e+5),
             new CelestialBody (" - - Mun",     9.7600236e+20, 2.000e+5),
             new CelestialBody (" - - Minmus",  2.6457897e+19, 6.000e+4),
             new CelestialBody (" - Duna",      4.5154812e+21, 3.200e+5),
             new CelestialBody (" - - Ike",     2.7821949e+20, 1.300e+5),
             new CelestialBody (" - Dres",      3.2191322e+20, 1.380e+5),
             new CelestialBody (" - Jool",      4.2332635e+24, 6.000e+6),
             new CelestialBody (" - - Laythe",  2.9397663e+22, 5.000e+5),
             new CelestialBody (" - - Vall",    3.1088028e+21, 3.000e+5),
             new CelestialBody (" - - Tylo",      4.2332635e+22, 6.000e+5),
             new CelestialBody (" - - Bop",      3.7261536e+19, 6.500e+4),
             new CelestialBody (" - - Pol",      1.0813636e+19, 4.400e+4),
             new CelestialBody (" - Eeloo",      1.1149358e+21, 2.100e+5),
        });

        public HohmannTransferUI()
        {
            InitializeComponent();

            cbBody.DataSource = new BindingSource(bodyParamatersList, null);
            cbBody.DisplayMember = "name";
            cbBody.SelectedIndex = 4; // Select Kerbin
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double initialOrbit, finalOrbit, v1, v2;

            // Check input
            if (!double.TryParse(txtInitOrb.Text, out initialOrbit)){
                MessageBox.Show ("Initial Orbit is not a number.", "Hohmann Transfer Calculator", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                return;
            }
            if (!double.TryParse(txtFinalOrb.Text, out finalOrbit))
            {
                MessageBox.Show("Final Orbit is not a number.", "Hohmann Transfer Calculator", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                return;
            }
            if (initialOrbit <= 0){
                MessageBox.Show ("Initial Orbit must be greater than 0", "Hohmann Transfer Calculator", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                return;
            }
            if (finalOrbit <= 0){
                MessageBox.Show ("Final Orbit must be greater than 0", "Hohmann Transfer Calculator", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                return;
            }


            // Convert orbit heights from km to m
            initialOrbit *= 1000;
            finalOrbit *= 1000;

            // Convert the orbit heights from distance from sea level to distance from parent body center (focus)
            initialOrbit += bodyParamatersList[cbBody.SelectedIndex].Radius;
            finalOrbit += bodyParamatersList[cbBody.SelectedIndex].Radius;
            
            // Calculate delta-v
            HohmannTransfer ht = new HohmannTransfer(
                initialOrbit, 
                finalOrbit,
                bodyParamatersList[cbBody.SelectedIndex].GravityParameter);

            
            // Display results
            txtFirstBurn.Text = Math.Abs(ht.V1).ToString("0.00");
            txtSecondBurn.Text = Math.Abs(ht.V2).ToString("0.00");
            txtTotal.Text = Math.Abs(ht.V1 + ht.V2).ToString("0.00");
        }

    }
}
