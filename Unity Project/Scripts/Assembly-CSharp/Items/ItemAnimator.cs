using UnityEngine;

namespace Items
{
	public class ItemAnimator : MonoBehaviour
	{
		public static ItemAnimator Instance { get; private set; }

		[field: SerializeField]
		public RectTransform Root { get; private set; }

		private void Awake()
		{
		}
	}
}
