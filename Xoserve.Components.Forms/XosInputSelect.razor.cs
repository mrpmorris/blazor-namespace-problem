using Fubar;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Xoserve.Components.Forms
{
	public partial class XosInputSelect<TValue> : InputBase<TValue>
	{
		[Parameter]
		public string Label { get; set; }

		[Parameter]
		public RenderFragment ChildContent { get; set; }

		[Parameter]
		public Func<TValue, string> GetDisplayText { get; set; }

		[CascadingParameter]
		public XosFormState State { get; set; }

		[Inject]
		private IJSRuntime JSRuntime { get; set; }

		private ElementReference SelectorElement;
		private List<XosInputSelectOption<TValue>> Options = new();

		public XosInputSelect()
		{
			if (typeof(TValue) == typeof(string))
				GetDisplayText = x => x?.ToString();
		}

		internal void RegisterOption(XosInputSelectOption<TValue> option)
		{
			Options.Add(option);
		}

		private async Task SelectedIndexChangedAsync()
		{
			int index = await JSRuntime.InvokeAsync<int>("xoserve.xosInputSelect.getSelectedIndex", SelectorElement);
			await InvokeAsync(async () =>
				{
					Value = Options[index].Value;
					await ValueChanged.InvokeAsync(Value);
				});
		}

		protected override bool TryParseValueFromString(string value, out TValue result, out string validationErrorMessage)
		{
			throw new NotImplementedException();
		}
	}
}
