using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Fubar;

namespace Xoserve.Components.Forms
{
	public partial class XosInputText : InputText
	{
		[Parameter]
		public string Label { get; set; }

		[Parameter]
		public bool BindOnKeypress { get; set; }

		[CascadingParameter]
		public XosFormState State { get; set; }
	}
}
