using Microsoft.AspNetCore.Components;
using System;

namespace Xoserve.Components.Forms
{
	public partial class XosInputSelectOption<TValue> : ComponentBase
	{
		[Parameter]
		public string Text { get; set; }

		[Parameter]
		public TValue Value { get; set; }

		[CascadingParameter]
		public XosInputSelect<TValue> Selector { get; set; }

		protected override void OnInitialized()
		{
			base.OnInitialized();
			Selector.RegisterOption(this);
		}

		protected override void OnParametersSet()
		{
			base.OnParametersSet();
			if (Selector is null)
				throw new InvalidOperationException($"Must be embedded within XosInputSelect<{typeof(TValue).Name}>");
			if (Text is null && Selector.GetDisplayText is null)
				throw new InvalidOperationException(
					"Must set either XosInputSelectOption.Text or XosInputSelect.GetDisplayText");
		}

		private string GetDisplayText() => Text ?? Selector.GetDisplayText(Value);
	}
}
