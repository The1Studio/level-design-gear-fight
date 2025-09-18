using UnityEngine;

namespace GearGame.Managers.SingleLoad
{
	public class AudioManager : MonoBehaviour
	{
		private static AudioManager instance;

		[SerializeField]
		private AudioSource oneShotSource;

		public static AudioManager Instance => null;

		protected void CreateSingleton()
		{
		}

		private void Awake()
		{
		}

		public void PlayClip(AudioClip clip)
		{
		}
	}
}
