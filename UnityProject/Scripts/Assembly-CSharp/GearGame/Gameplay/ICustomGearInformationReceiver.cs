namespace GearGame.Gameplay
{
	public interface ICustomGearInformationReceiver
	{
		void InformationReceived(string[] information, GearPeg targetPeg, bool allowMovement);
	}
}
