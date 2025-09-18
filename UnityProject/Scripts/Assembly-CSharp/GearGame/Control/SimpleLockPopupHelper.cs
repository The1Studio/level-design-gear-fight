using UnityEngine;

namespace GearGame.Control
{
	public class SimpleLockPopupHelper : MonoBehaviour
	{
		[SerializeField]
		protected RectTransform transformUsed;

		[SerializeField]
		protected string localizationString;

		protected float _lastClickTime;

		public virtual void OnClick()
		{
		}
	}
}
