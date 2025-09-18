using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Internal.DebugScreen
{
	public abstract class DebugAdStateBadge : MonoBehaviour
	{
		[SerializeField]
		private GameObject badgeObject;

		[SerializeField]
		private Image stateObject;

		protected abstract bool IsEnabled();

		protected abstract Color StateColor();

		protected virtual void Awake()
		{
		}

		protected void UpdateVisibility()
		{
		}

		private void Update()
		{
		}
	}
}
