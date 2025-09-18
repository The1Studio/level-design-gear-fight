using System;
using System.Collections.Generic;
using UnityEngine;
using Voodoo.Sauce.Debugger.Widgets;

namespace Voodoo.Sauce.Debugger
{
	public static class WidgetUtility
	{
		private const string BANK_PATH = "VoodooDebuggerWidgetBank";

		private static DebuggerCanvas _debuggerCanvasPrefab;

		private static Dictionary<string, Widget> _bank;

		static WidgetUtility()
		{
		}

		public static T Get<T>(string key) where T : Widget
		{
			return null;
		}

		public static Widget Get(string key)
		{
			return null;
		}

		public static DebuggerCanvas InstantiateDebugger()
		{
			return null;
		}

		public static T InstanceOf<T>(Transform parent = null) where T : Widget
		{
			return null;
		}

		public static DebugMenuItemButton MenuItem(string title, Sprite image, Color imageColor, Action callback, BadgeCounter counter = null, Transform parent = null)
		{
			return null;
		}

		public static DebugHideableSection Foldout(string title, Transform parent = null, bool opened = true)
		{
			return null;
		}

		public static DebugTextPair Label(Func<string> refreshFunc, Transform parent = null)
		{
			return null;
		}

		public static DebugTextPair Label(string text, Transform parent = null)
		{
			return null;
		}

		public static DebugTextPair Label(string text, string value, Transform parent = null)
		{
			return null;
		}

		public static DebugTextPair Label(string text, Func<string> refreshFunc, Transform parent = null)
		{
			return null;
		}

		public static DebugTextPair CopyToClipboard(string label, string value, Transform parent = null)
		{
			return null;
		}

		public static DebugTextPair CopyToClipboard(string label, Func<string> refreshFunc, Transform parent = null)
		{
			return null;
		}

		public static DebugTextPair CopyToClipboard(string label, string value, Func<string> valueToCopy, Transform parent = null)
		{
			return null;
		}

		public static DebugTextPair CopyToClipboard(string label, Func<string> refreshFunc, Func<string> valueToCopy, bool isWarning = false, Transform parent = null)
		{
			return null;
		}

		public static void CreateSpace(int height = 10, Transform parent = null)
		{
		}

		public static void CreateSeparator(int height = 10, Transform parent = null)
		{
		}

		public static void CreateSeparator(int height, bool displayLine, Transform parent = null)
		{
		}

		public static DebugButtonWithInputField Button(string title, Action callback, Transform parent = null)
		{
			return null;
		}

		public static DebugButtonWithInputField ButtonWithInput(string title, string placeholderText, Action<string> callback, Func<string> refreshFunc = null, Transform parent = null)
		{
			return null;
		}

		public static DebugButtonWithInputField InputField(string title, string placeholderText, Action<string> inputCallback, Func<string> refreshFunc = null, Transform parent = null)
		{
			return null;
		}

		public static DebugToggleButton Toggle(string title, bool value, Action<bool> callback, Transform parent = null)
		{
			return null;
		}

		public static DebugRadioButton RadioButton(string label, Action<bool> callback, Transform parent)
		{
			return null;
		}

		public static DebugRowLabel RowLabel(string rowName, string value, Transform parent = null)
		{
			return null;
		}

		public static DebugRowLabel RowLabel(string rowName, string[] values, Transform parent = null)
		{
			return null;
		}

		public static DebugRadioGroup RadioGroup()
		{
			return null;
		}

		public static DebugCheckboxButton CheckboxButton(string label, Action<bool> callback, Transform parent)
		{
			return null;
		}
	}
}
