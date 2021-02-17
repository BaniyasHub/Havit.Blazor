﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Havit.Blazor.Components.Web.Bootstrap
{
	/// <summary>
	/// Chip item to be rendered in UI.
	/// </summary>
	public class ChipItem
	{
		/// <summary>
		/// Chip template.
		/// </summary>
		public RenderFragment ChipTemplate { get; init; }

		/// <summary>
		/// True when it is possible to remove the chip.
		/// </summary>
		public bool Removable { get; init; } = false;

		/// <summary>
		/// Remove callback called when chip should be removed.
		/// It receives the model from which the chip should be removed.
		/// It is not the same instance as the one from which the chip was generated!
		/// </summary>
		public Action<object> RemoveCallback { get; init; }
	}
}
