using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Debugger
{
	public class LogsOptionDebugScreen : Screen
	{
		[SerializeField]
		private Toggle enableDebugLogsToggle;

		[SerializeField]
		private GameObject restartLogsView;

		[SerializeField]
		private RectTransform logFilterContainer;

		[SerializeField]
		private GameObject logFilterParent;

		[SerializeField]
		[Header("Prefabs")]
		private Toggle logFilterPrefab;

		[SerializeField]
		private TextMeshProUGUI logHeaderTextPrefab;

		private bool _originalDebugLogsEnabled;

		private Toggle[] _logFilterToggles;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Start()
		{
		}

		private void CreateLogModuleToggles()
		{
		}

		private Toggle CreateModuleToggle(int index, string moduleName)
		{
			return null;
		}

		private string FormatModuleName(string module)
		{
			return null;
		}

		private void OnLogModuleChanged(int value)
		{
		}

		private void OnEnableDebugLogsToggled(bool enableLogs)
		{
		}

		private string[] GetEnumValues(Type enumType)
		{
			return null;
		}
	}
}
