using UnityEngine;
using VInspector;

namespace Items
{
	[CreateAssetMenu(menuName = "Items/Rarity")]
	public class RaritySO : ScriptableObject
	{
		public string Id;

		public string LocalizationKey;

		public Color Color;

		[Header("Sprites")]
		public SerializedDictionary<string, Sprite> Backgrounds;

		public byte Order { get; set; }

		public string LocalizedName => null;

		public string ColoredLocalizedName => null;

		public int CompareTo(RaritySO other)
		{
			return 0;
		}

		public static bool operator <=(RaritySO a, RaritySO b)
		{
			return false;
		}

		public static bool operator >=(RaritySO a, RaritySO b)
		{
			return false;
		}

		public static bool operator <(RaritySO a, RaritySO b)
		{
			return false;
		}

		public static bool operator >(RaritySO a, RaritySO b)
		{
			return false;
		}
	}
}
