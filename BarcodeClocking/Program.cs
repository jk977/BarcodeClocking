﻿// Copyright © 2015 Lower Columbia College Computer Science Club

// This file is part of Barcode Clocking.

// Barcode Clocking is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.

// Barcode Clocking is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.

// You should have received a copy of the GNU Affero General Public License
// along with Barcode Clocking.  If not, see <http://www.gnu.org/licenses/>.

// If you have any questions or comments, please contact the current Club
// President or Club Vice President.

using System;
using System.Windows.Forms;

namespace BarcodeClocking {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}