using UnityEngine;
using Voodoo.Sauce.Debugger;

namespace Voodoo.Sauce.Internal.DebugScreen
{
	public abstract class DebugToggleComponent : MonoBehaviour
	{
		private DebugToggleButton _button;

		protected DebugToggleButton Button => null;

		protected virtual void Start()
		{
		}

		protected abstract bool DefaultButtonState();

		public virtual void SetEnabled(bool isEnabled)
		{
		}

		protected void UpdateEnabled()
		{
		}
	}
}
