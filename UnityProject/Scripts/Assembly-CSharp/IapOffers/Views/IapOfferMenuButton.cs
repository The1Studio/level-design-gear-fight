using System;
using System.Runtime.CompilerServices;
using GearGame.Gameplay.UI.Pregame;
using Items;
using UnityEngine;
using UnityEngine.UI;

namespace IapOffers.Views
{
	public class IapOfferMenuButton : MonoBehaviour
	{
		[SerializeField]
		protected Button _button;

		[SerializeField]
		protected LockedTabButtonController _lockedTabButtonController;

		[SerializeField]
		protected OfferCategoryType _category;

		public event Action Closed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public bool IsVisible()
		{
			return false;
		}

		public bool ShouldAutoShow()
		{
			return false;
		}

		public void Open()
		{
		}

		private void OnClicked()
		{
		}

		private void OnClosed()
		{
		}
	}
}
