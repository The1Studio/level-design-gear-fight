using System;
using System.Collections.Generic;
using UnityEngine;
using Voodoo.Sauce.Debugger.Widgets;
using Voodoo.Sauce.Internal.DebugScreen;

namespace Voodoo.Sauce.Debugger
{
	public class Screen : Widget, IComparable, IComparable<Screen>
	{
		[Header("Screen")]
		public Sprite image;

		public Color imageColor;

		public string title;

		public int orderIndex;

		public Screen mainSubScreen;

		[SerializeField]
		private Transform _parent;

		private DebugHideableSection _currentFoldout;

		private DebugRadioGroup _currentRadioGroup;

		private List<DebugRadioGroup> _radioGroups;

		private List<IDebugRefreshable> _refreshables;

		private List<Widget> _widgets;

		protected Transform Parent => null;

		public virtual BadgeCounter Counter()
		{
			return null;
		}

		public virtual void OnScreenShow()
		{
		}

		public virtual void OnScreenHide()
		{
		}

		protected void ClearDisplay()
		{
		}

		public void RefreshWidgets()
		{
		}

		public T Assign<T>(T widget) where T : Widget
		{
			return null;
		}

		public List<T> GetAll<T>() where T : Widget
		{
			return null;
		}

		public DebugMenuItemButton MenuItem(string title, Sprite image, Color imageColor, Action callback, BadgeCounter counter = null)
		{
			return null;
		}

		public DebugTextPair Label(Func<string> refreshFunc)
		{
			return null;
		}

		public DebugTextPair Label(string text)
		{
			return null;
		}

		public DebugTextPair Label(string text, string value)
		{
			return null;
		}

		public DebugTextPair Label(string text, Func<string> refreshFunc)
		{
			return null;
		}

		public DebugTextPair Label(string label, Func<string> value, bool warning)
		{
			return null;
		}

		public DebugTextPair CopyToClipboard(string label, string value)
		{
			return null;
		}

		public DebugTextPair CopyToClipboard(string label, Func<string> refreshFunc)
		{
			return null;
		}

		public DebugTextPair CopyToClipboard(string label, string value, Func<string> valueToCopy)
		{
			return null;
		}

		public DebugTextPair CopyToClipboard(string label, Func<string> value, Func<string> valueToCopy, bool warning)
		{
			return null;
		}

		public DebugButtonWithInputField Button(string label, Action callback)
		{
			return null;
		}

		public DebugButtonWithInputField ButtonWithInput(string label, string placeholderText, Action<string> callback, Func<string> refreshFunc = null)
		{
			return null;
		}

		public DebugButtonWithInputField InputField(string label, string placeholderText, Action<string> callback, Func<string> refreshFunc = null)
		{
			return null;
		}

		public DebugToggleButton Toggle(string label, bool value, Action<bool> callback)
		{
			return null;
		}

		public DebugHideableSection OpenFoldout(string foldoutTitle, bool opened = true)
		{
			return null;
		}

		public void CloseFoldout()
		{
		}

		public DebugRowLabel RowLabel(string rowName, string value)
		{
			return null;
		}

		public DebugRowLabel RowLabel(string rowName, string[] values)
		{
			return null;
		}

		public DebugCheckboxButton CheckboxButton(string label, Action<bool> callback)
		{
			return null;
		}

		public DebugRadioButton RadioButton(string label, Action<bool> callback)
		{
			return null;
		}

		public DebugRadioGroup CreateRadioGroup()
		{
			return null;
		}

		public void CloseRadioGroup()
		{
		}

		public void ResetRadioGroups(bool callCallback)
		{
		}

		public int CompareTo(Screen other)
		{
			return 0;
		}

		public int CompareTo(object obj)
		{
			return 0;
		}
	}
}
