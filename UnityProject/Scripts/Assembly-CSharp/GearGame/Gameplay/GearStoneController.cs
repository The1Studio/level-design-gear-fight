using Gameplay._Data;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class GearStoneController : GearSpellSpawnerController
	{
		[SerializeField]
		private SpriteRenderer[] allBreakSprites;

		[SerializeField]
		private SpriteRenderer[] allBreakSpritesFill;

		[SerializeField]
		private SpriteRenderer rootDisplaySpriteFill;

		[SerializeField]
		private Animator hitAnim;

		private readonly int mineHash;

		public override GearSpawnerData SpawnerData => null;

		public int NumMineRemaining { get; private set; }

		public bool HasEvolved { get; private set; }

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public void MineThis()
		{
		}

		protected override void DoSpawnAction()
		{
		}
	}
}
