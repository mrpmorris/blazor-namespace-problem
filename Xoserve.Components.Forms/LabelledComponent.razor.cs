using Microsoft.AspNetCore.Components;
using System;

namespace Xoserve.Components.Forms
{
	public partial class LabelledComponent
	{
		private readonly string Id = "xos-" + Guid.NewGuid().ToString();

		[Parameter]
		public string Label { get; set; }

		[Parameter]
		public RenderFragment<string> ChildContent { get; set; }
	}
}
