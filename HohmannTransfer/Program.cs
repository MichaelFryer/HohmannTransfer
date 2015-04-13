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
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hohmann_Transfer
{
    static class Program
    {
         /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            BindingList<CelestialBody> bodyParamatersList = new BindingList<CelestialBody>
            (new[] {
            
                    new CelestialBody ("Kerbol", 1.7565670e+28, 2.616e+8),
                    new CelestialBody (" - Moho", 2.5263617e+21, 2.500e+5),
                    new CelestialBody (" - Eve", 1.2244127e+23, 7.000e+5),
                    new CelestialBody (" - - Gilly", 1.2420512e+17, 1.300e+4),
                    new CelestialBody (" - Kerbin", 5.2915793e+22, 6.000e+5),
                    new CelestialBody (" - - Mun", 9.7600236e+20, 2.000e+5),
                    new CelestialBody (" - - Minmus", 2.6457897e+19, 6.000e+4),
                    new CelestialBody (" - Duna", 4.5154812e+21, 3.200e+5),
                    new CelestialBody (" - - Ike", 2.7821949e+20, 1.300e+5),
                    new CelestialBody (" - Dres", 3.2191322e+20, 1.380e+5),
                    new CelestialBody (" - Jool", 4.2332635e+24, 6.000e+6),
                    new CelestialBody (" - - Laythe", 2.9397663e+22, 5.000e+5),
                    new CelestialBody (" - - Vall", 3.1088028e+21, 3.000e+5),
                    new CelestialBody (" - - Tylo", 4.2332635e+22, 6.000e+5),
                    new CelestialBody (" - - Bop", 3.7261536e+19, 6.500e+4),
                    new CelestialBody (" - - Pol", 1.0813636e+19, 4.400e+4),
                    new CelestialBody (" - Eeloo", 1.1149358e+21, 2.100e+5),
            });

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HohmannTransferUI(bodyParamatersList));
        }
    }
}
