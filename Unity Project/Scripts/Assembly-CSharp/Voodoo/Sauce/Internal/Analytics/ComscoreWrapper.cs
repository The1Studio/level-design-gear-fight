using UnityEngine;
using Voodoo.Sauce.Core;

namespace Voodoo.Sauce.Internal.Analytics
{
	public class ComscoreWrapper : MonoBehaviour
	{
		private const string TAG = "ComscoreWrapper";

		private const string CS_UCFR = "cs_ucfr";

		private ComscoreConfig _config;

		private ComscoreState _state;

		public static ComscoreWrapper Instance { get; private set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Initialize(VoodooSauceInitCallbackResult result)
		{
		}

		private void InitializeSdk(string publisherId)
		{
		}

		public string GetStateDesc()
		{
			return null;
		}
	}
}
