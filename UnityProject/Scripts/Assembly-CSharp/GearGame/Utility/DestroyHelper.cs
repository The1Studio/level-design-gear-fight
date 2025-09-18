using UnityEngine;

namespace GearGame.Utility
{
	public class DestroyHelper : MonoBehaviour
	{
		public IOnDestroyHelper AttachedObject { get; set; }

		private void OnDestroy()
		{
		}
	}
}
