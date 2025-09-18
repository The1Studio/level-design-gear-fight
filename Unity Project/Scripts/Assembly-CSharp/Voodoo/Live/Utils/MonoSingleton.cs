using UnityEngine;

namespace Voodoo.Live.Utils
{
	public class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
	{
		private static T _instance;

		public static T Instance => null;

		protected virtual void Awake()
		{
		}
	}
}
