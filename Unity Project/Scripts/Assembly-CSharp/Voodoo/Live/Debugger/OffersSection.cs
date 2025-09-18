using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Voodoo.Live.Offers;

namespace Voodoo.Live.Debugger
{
	public class OffersSection : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		private OffersSubHeader _subHeader;

		[SerializeField]
		private Transform _contentTransform;

		[SerializeField]
		private TextMeshProUGUI _offersUrlTXT;

		[SerializeField]
		private Button _offersUrlCopyBtn;

		[SerializeField]
		private Button _serverDataCopyBtn;

		[SerializeField]
		private TriggersSection _triggersSection;

		public void Init(FeatureClient offersManager)
		{
		}

		private void CopyOffersUrl(FeatureClient offersManager)
		{
		}

		private void CopyServerData(FeatureClient offersManager)
		{
		}
	}
}
