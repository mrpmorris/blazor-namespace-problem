using Xoserve.Components.Forms;

namespace Fubar
{
	public class XosFormState
	{
		public XosFormMode Mode { get; }
		public XosFormState(XosFormMode mode)
		{
			Mode = mode;
		}
	}
}
