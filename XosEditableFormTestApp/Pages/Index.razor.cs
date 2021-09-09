using Xoserve.Components.Forms;

namespace XosEditableFormTestApp.Pages
{
	public partial class Index
	{
		XosFormMode Mode;

		public Person Editable = new Person { FirstName = "Bob", LastName = "Monkhouse" };

		private void ToggleFormMode()
		{
			Mode = Mode == XosFormMode.Edit
				? XosFormMode.View
				: XosFormMode.Edit;
			Editable.FirstName += "!";
		}
	}
}
