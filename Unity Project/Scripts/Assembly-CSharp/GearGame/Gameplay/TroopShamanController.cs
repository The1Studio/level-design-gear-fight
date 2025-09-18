using Gameplay._Data;

namespace GearGame.Gameplay
{
	public class TroopShamanController : TroopController
	{
		private ShamanData _data;

		public override TroopData Data => null;

		protected override void Start()
		{
		}

		private void HealthChanged(TroopHealthController _, double health)
		{
		}
	}
}
