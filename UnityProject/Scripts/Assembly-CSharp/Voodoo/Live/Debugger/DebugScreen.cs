using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Voodoo.Live.Utils;

namespace Voodoo.Live.Debugger
{
	public class DebugScreen : MonoSingleton<DebugScreen>
	{
		[SerializeField]
		[Header("References")]
		private Button _closeBtn;

		[SerializeField]
		private MessageTabTop _messageTabTop;

		[SerializeField]
		private OfferMessage _offerMessage;

		[Header("Debugger Sections")]
		public ShopSection ShopSection;

		public OffersSection OffersSection;

		[Header("No Services Message")]
		public GameObject noServicesMessage;

		private List<GameObject> offerMessages;

		private void Start()
		{
		}

		private void HideScreen()
		{
		}

		public void ShowTabMessage(string message)
		{
		}

		public void ClearTabMessage()
		{
		}

		public void ShowMessage(string messageName, string status, string info)
		{
		}
	}
}
