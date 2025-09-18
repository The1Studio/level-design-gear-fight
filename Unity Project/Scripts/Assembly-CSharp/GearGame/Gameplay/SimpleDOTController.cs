using UnityEngine;

namespace GearGame.Gameplay
{
	public class SimpleDOTController : MonoBehaviour
	{
		[SerializeField]
		private string id;

		[SerializeField]
		private float timeBetweenTicks;

		[SerializeField]
		private float aliveTimer;

		private double damagePerSecond;

		private float tickTimer;

		private float timer;

		private TroopController attachedCharacter;

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void OnValidate()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public void SetDamagePerSecond(double damagePerSecond)
		{
		}

		public void Refresh()
		{
		}

		public bool Attach(TroopController controller)
		{
			return false;
		}

		private void DestroyThis(TroopController c)
		{
		}

		public void ApplyDamage(double amount)
		{
		}
	}
}
