﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havit.Blazor.Components.Web.Bootstrap
{
	/// <summary>
	/// Settings for the <see cref="HxListLayout"/> and derived components.
	/// </summary>
	public record ListLayoutSettings
	{
		/// <summary>
		/// Settings for the wrapping <see cref="HxCard"/>.
		/// </summary>
		public CardSettings CardSettings { get; set; }

		/// <summary>
		/// Settings for the <see cref="HxButton"/> opening filtering offcanvas.
		/// </summary>
		public ButtonSettings FilterOpenButtonSettings { get; set; }

		/// <summary>
		/// Settings for the <see cref="HxButton"/> submitting the filter.
		/// </summary>
		public ButtonSettings FilterSubmitButtonSettings { get; set; }

		/// <summary>
		/// Settings for the <see cref="HxOffcanvas"/> with the filter.
		/// </summary>
		public OffcanvasSettings FilterOffcanvasSettings { get; set; }
	}
}