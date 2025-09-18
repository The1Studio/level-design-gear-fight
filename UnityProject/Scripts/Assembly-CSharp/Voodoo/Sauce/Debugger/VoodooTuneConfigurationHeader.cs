using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Debugger
{
	public class VoodooTuneConfigurationHeader : MonoBehaviour
	{
		[SerializeField]
		[Header("Configuration")]
		private TextMeshProUGUI configId;

		[SerializeField]
		private TextMeshProUGUI configTitle;

		[SerializeField]
		private TextMeshProUGUI configurationDescriptionText;

		[SerializeField]
		private Color appliedConfigurationColor;

		[SerializeField]
		private Color draftConfigurationColor;

		[SerializeField]
		private GameObject warningRoot;

		[SerializeField]
		private GameObject currentConfigurationButtonsRoot;

		[SerializeField]
		private bool hasHiddenButton;

		[SerializeField]
		private Button detailsButton;

		[SerializeField]
		private Button resetButton;

		[SerializeField]
		private Screen detailsScreen;

		private Image _configurationBackground;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnDetailsButtonClick()
		{
		}

		public void OnResetConfigurationBtn()
		{
		}

		private void UpdateScreen()
		{
		}
	}
}
