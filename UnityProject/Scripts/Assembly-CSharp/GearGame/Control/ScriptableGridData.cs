using System;
using GearGame.Gameplay;
using Sirenix.OdinInspector;
using UnityEngine;

namespace GearGame.Control
{
	[CreateAssetMenu(menuName = "Gameplay/Grid Data")]
	public class ScriptableGridData : SerializedScriptableObject
	{
		[Serializable]
		public class PegGears
		{
			public GearPeg PegObject;

			public GameObject GearObject;

			public string PegInformation;

			public string GearInformation;

			public ScriptableGear ScriptableGear;

			public GearController.LockType LockType;
		}

		public PegGears[,] AllPegGears;
	}
}
