using System;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Live.Debugger
{
	public class MainButtonsSection : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		private Button _resetBtn;

		public static Action OnResetOffers;

		private void Start()
		{
		}

		private void ResetOffers()
		{
		}
	}
}
