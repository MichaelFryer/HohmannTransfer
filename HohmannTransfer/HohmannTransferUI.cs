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
        public HohmannTransferUI(BindingList<CelestialBody> bodyParamatersList)
        {
            InitializeComponent();
            cbBody.DataSource = bodyParamatersList;
            cbBody.DisplayMember = "name";
            cbBody.SelectedIndex = 4; // Select Kerbin
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double initialOrbit, finalOrbit;
            CelestialBody selectedBody = ((BindingList<CelestialBody>)cbBody.DataSource)[cbBody.SelectedIndex];

            // Check inputs are numbers
            if (!double.TryParse(txtInitOrb.Text, out initialOrbit)){
                MessageBox.Show ("Initial Orbit is not a number.", "Hohmann Transfer Calculator", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                return;
            }
            if (!double.TryParse(txtFinalOrb.Text, out finalOrbit))
            {
                MessageBox.Show("Final Orbit is not a number.", "Hohmann Transfer Calculator", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                return;
            }

            // Convert orbit heights from km to m and from height above sea level to distance from focus
            initialOrbit = selectedBody.SeaHeightToFocusDistance(initialOrbit * 1000);
            finalOrbit = selectedBody.SeaHeightToFocusDistance(finalOrbit * 1000);

            // Check the distances are greater than 0
            if (initialOrbit <= 0){
                MessageBox.Show ("Initial orbit must be greater than -"+(selectedBody.Radius/1000).ToString("0")+"km", 
                    "Hohmann Transfer Calculator", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                return;
            }
            if (finalOrbit <= 0){
                MessageBox.Show("Final orbit must be greater than -" + (selectedBody.Radius / 1000).ToString("0") + "km", 
                    "Hohmann Transfer Calculator", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                return;
            }
            
            // Calculate delta-v
            HohmannTransfer ht = new HohmannTransfer(
                initialOrbit, 
                finalOrbit,
                selectedBody.GravityParameter);
            
            // Display results
            txtFirstBurn.Text = Math.Abs(ht.V1).ToString("0.0000");
            txtSecondBurn.Text = Math.Abs(ht.V2).ToString("0.0000");
            txtTotal.Text = Math.Abs(ht.V1 + ht.V2).ToString("0.0000");
        }

    }
}
