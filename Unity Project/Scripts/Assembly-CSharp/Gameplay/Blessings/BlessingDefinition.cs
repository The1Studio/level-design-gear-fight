using UnityEngine;

namespace Gameplay.Blessings
{
	[CreateAssetMenu(fileName = "BlessingDefinition", menuName = "Blessings/BlessingDefinition", order = 0)]
	public class BlessingDefinition : ScriptableObject
	{
		public string Id;

		public Sprite Icon;

		[SerializeField]
		private string _nameLocKey;

		public string GetLocalizedName()
		{
			return null;
		}
	}
}
