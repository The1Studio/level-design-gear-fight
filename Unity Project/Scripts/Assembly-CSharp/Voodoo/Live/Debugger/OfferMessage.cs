using TMPro;
using UnityEngine;

namespace Voodoo.Live.Debugger
{
	public class OfferMessage : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		private TextMeshProUGUI _offerNameTxt;

		[SerializeField]
		private TextMeshProUGUI _offerStatusTxt;

		[SerializeField]
		private TextMeshProUGUI _offerInfoTxt;

		public void Init(string name, string status, string info)
		{
		}
	}
}
