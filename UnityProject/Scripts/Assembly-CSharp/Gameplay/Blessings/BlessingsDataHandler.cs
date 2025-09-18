namespace Gameplay.Blessings
{
	public class BlessingsDataHandler
	{
		public const string BlessingsDataKey = "BlessingsData";

		public BlessingsData BlessingsData { get; }

		public bool UnlimitedBlessings
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private BlessingsData LoadBlessingsData()
		{
			return null;
		}

		public void Save()
		{
		}
	}
}
