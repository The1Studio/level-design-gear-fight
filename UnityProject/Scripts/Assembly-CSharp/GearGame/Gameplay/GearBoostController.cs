using System;
using System.Collections.Generic;
using Gameplay._Data;
using GearGame.Control;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class GearBoostController : GearController
	{
		public enum BoostTypes
		{
			Acorn = 0,
			Brain = 1,
			Juice = 2
		}

		[SerializeField]
		private ScriptableBoostDetails scriptableBoost;

		private readonly Dictionary<string, Type> attachmentTypes;

		private List<BoostController> spawnedBuffs;

		[field: SerializeField]
		public SpriteRenderer DisplaySpriteForegound { get; private set; }

		[field: SerializeField]
		public BoostTypes BoostType { get; private set; }

		public BuffData BoostData => null;

		public override GearData GearData => null;

		public override bool CanBeFrozen => false;

		public override ScriptableGear.GearType GearType => default(ScriptableGear.GearType);

		public BuffData GetBoostData(BoostTypes type)
		{
			return null;
		}

		protected override void OnDestroy()
		{
		}

		public void Refresh()
		{
		}

		private void SetAttachmentTypeAndTryAttach(Type type, ref List<GearController> gearsAroundPeg)
		{
		}

		private void OnBuffDestroyed(BoostController buff)
		{
		}
	}
}
