namespace GearGame.Utility
{
	public class Migration
	{
		private MigrationAction _action;

		public string Version { get; private set; }

		public string PreviousVersion { get; private set; }

		public Migration(string previousVersion, string version, MigrationAction action)
		{
		}

		public virtual bool ShouldMigrate(string currentVersion)
		{
			return false;
		}

		public bool Migrate()
		{
			return false;
		}
	}
}
