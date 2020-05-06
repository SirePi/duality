﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duality.Utility.Coroutines
{
	/// <summary>
	/// A Coroutine's current execution Status
	/// </summary>
	public enum CoroutineStatus : byte
	{
		Paused,
		Running,
		Complete,
		Cancelled,
		Disposed,
		Error
	}
}