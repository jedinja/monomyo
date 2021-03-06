﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git.jrowberg.bglib.Bluegiga.BLE.Responses.Hardware
{
	public delegate void IOPortIrqEnableEventHandler (object sender, IOPortIrqEnableEventArgs e);

	public class IOPortIrqEnableEventArgs : EventArgs
	{
		public readonly UInt16 result;

		public IOPortIrqEnableEventArgs (UInt16 result)
		{
			this.result = result;
		}
	}
}
