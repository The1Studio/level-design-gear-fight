using Sirenix.OdinInspector;
using UnityEngine;

namespace Gameplay._Data
{
	[CreateAssetMenu(menuName = "StaticData/Troop Data")]
	public class StaticTroopDataProvider : SerializedScriptableObject
	{
		[SerializeField]
		private double[] levelToNIV;

		[SerializeField]
		private double[] costValues;

		[SerializeField]
		private int[] damageValues;

		[SerializeField]
		private int[] healthValues;

		public static StaticTroopDataProvider Instance { get; private set; }

		public static double[] LevelToNIV => null;

		public static double[] CostValues => null;

		public static int[] DamageValues => null;

		public static int[] HealthValues => null;

		public void CreateSingleton()
		{
		}
	}
}
