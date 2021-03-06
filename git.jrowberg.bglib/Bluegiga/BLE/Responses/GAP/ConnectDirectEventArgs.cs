﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git.jrowberg.bglib.Bluegiga.BLE.Responses.GAP
{
	public delegate void ConnectDirectEventHandler (object sender, ConnectDirectEventArgs e);

	public class ConnectDirectEventArgs : EventArgs
	{
		public readonly UInt16 result;
		public readonly Byte connection_handle;

		public ConnectDirectEventArgs (UInt16 result, Byte connection_handle)
		{
			this.result = result;
			this.connection_handle = connection_handle;
		}
	}
}
