using System;
using GearGame.Gameplay;
using UnityEngine;

namespace GearGame.Control
{
	[Serializable]
	public class GridData : ScriptableObject
	{
		public GearPeg PegObject;

		public GameObject GearObject;

		public string CustomGearInformation;

		public string CustomPegInformation;
	}
}
