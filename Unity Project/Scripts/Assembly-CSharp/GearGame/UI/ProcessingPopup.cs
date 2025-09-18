using Core.UI;
using UnityEngine;

namespace GearGame.UI
{
	public class ProcessingPopup : Popup
	{
		[SerializeField]
		private Animator anim;

		private float _timeOutTimer;

		public void Open(float timeOutSeconds)
		{
		}

		private void Update()
		{
		}

		protected override void OnClose()
		{
		}
	}
}
