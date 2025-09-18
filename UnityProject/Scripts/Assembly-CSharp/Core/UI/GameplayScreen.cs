using System.Collections.Generic;
using UnityEngine;

namespace Core.UI
{
	public class GameplayScreen : Screen
	{
		[SerializeField]
		private Animator simpleDiamondDisplayElementAnimator;

		[SerializeField]
		private Animator simpleSkipTicketDisplayElementAnimator;

		private readonly List<object> allDiamondDisplayEnforcers;

		private readonly List<object> allSkipTicketDisplayEnforcers;

		protected void Awake()
		{
		}

		public void OnSettingsButtonClicked()
		{
		}

		public void AddDiamondDisplayEnforcer(object o)
		{
		}

		public void RemoveDiamondDisplayEnforcer(object o)
		{
		}

		public void AddSkipTicketDisplayEnforcer(object o)
		{
		}

		public void RemoveSkipTicketDisplayEnforcer(object o)
		{
		}
	}
}
