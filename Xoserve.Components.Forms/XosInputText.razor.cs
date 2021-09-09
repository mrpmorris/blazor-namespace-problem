using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace Xoserve.Components.Forms
{
	public partial class XosInputText : InputText
	{
		[Parameter]
		public string Label { get; set; }

		[CascadingParameter]
		public XosFormState State { get; set; }
	}
}
