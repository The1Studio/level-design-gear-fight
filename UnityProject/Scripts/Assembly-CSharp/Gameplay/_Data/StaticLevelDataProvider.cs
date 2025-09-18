using Sirenix.OdinInspector;
using UnityEngine;

namespace Gameplay._Data
{
	[CreateAssetMenu(menuName = "StaticData/LevelDataProvider")]
	public class StaticLevelDataProvider : SerializedScriptableObject
	{
		[SerializeField]
		private double[] blueCoinPayouts;

		[SerializeField]
		private double[] greenCoinPayouts;

		public static StaticLevelDataProvider Instance { get; private set; }

		public static double[] BlueCoinPayouts => null;

		public static double[] GreenCoinPayouts => null;

		public void CreateSingleton()
		{
		}
	}
}
