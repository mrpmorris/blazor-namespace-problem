using Microsoft.AspNetCore.Components;

namespace Xoserve.Components.Forms
{
	public partial class XosForm<TModel>
	{
		[Parameter]
		public XosFormMode Mode { get; set; }

		[Parameter]
		public TModel Model { get; set; }

		[Parameter]
		public RenderFragment<XosFormState> ChildContent { get; set; }

		private XosFormState State;

		protected override void OnParametersSet()
		{
			base.OnParametersSet();
			State = new XosFormState(Mode);
		}

	}
}
