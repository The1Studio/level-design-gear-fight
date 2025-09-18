using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Debugger
{
	public class VoodooTuneConfigurationDetailsScreen : Screen
	{
		[SerializeField]
		[Header("Configuration Details")]
		private TMP_Text configurationDetailsLabel;

		[SerializeField]
		private Button copyButton;

		private static readonly Regex ClassNameRegex;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private static string FormatClassName(string value)
		{
			return null;
		}

		private static string FormatVariables(string value)
		{
			return null;
		}

		public void CopyConfigurationDetails()
		{
		}
	}
}
