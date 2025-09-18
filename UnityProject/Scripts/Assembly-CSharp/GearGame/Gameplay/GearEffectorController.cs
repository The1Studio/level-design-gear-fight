using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Gameplay
{
	public abstract class GearEffectorController : MonoBehaviour
	{
		public enum EffectorDirection
		{
			Column = 0,
			Row = 1
		}

		public enum EffectorMotion
		{
			None = 0,
			Random = 1,
			Increment = 2,
			Deincrement = 3
		}

		[SerializeField]
		protected EffectorDirection effectorDirection;

		[SerializeField]
		protected GameStateManager.GameState effectorApplication;

		[SerializeField]
		protected EffectorMotion effectorMotion;

		[SerializeField]
		protected GameStateManager.GameState effectorMotionApplication;

		protected int attachmentIndex;

		protected abstract void ApplyEffect(GearPeg[] pegs);

		protected abstract void RevertEffect(GearPeg[] pegs);

		protected virtual void OnDestroy()
		{
		}

		protected GearPeg[] GetCurrentPegs()
		{
			return null;
		}

		private void StateChanged(GameStateManager.GameState state)
		{
		}

		protected virtual void MovePosition()
		{
		}

		public string GenerateCustomInformation(EffectorDirection direction, GameStateManager.GameState application, EffectorMotion motion, GameStateManager.GameState effectorMotionApplication, int index)
		{
			return null;
		}

		public void InformationReceived(string[] information, GearPeg _, bool __)
		{
		}
	}
}
