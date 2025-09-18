using UnityEngine;
using VInspector;

namespace StatSystem
{
	[CreateAssetMenu(menuName = "Stat/FormatData")]
	public class StatFormatSO : ScriptableObject
	{
		[SerializeField]
		private SerializedDictionary<StatNames, StatFormat> _formats;

		public Color UpgradeColor;

		public Color DowngradeColor;

		public StatFormat this[StatNames stat] => default(StatFormat);

		public StatFormat GetFormat(StatNames stat)
		{
			return default(StatFormat);
		}
	}
}
