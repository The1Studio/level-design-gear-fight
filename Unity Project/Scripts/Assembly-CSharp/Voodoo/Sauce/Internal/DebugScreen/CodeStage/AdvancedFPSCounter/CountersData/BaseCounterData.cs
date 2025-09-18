using System;
using System.Text;
using UnityEngine;
using Voodoo.Sauce.Internal.DebugScreen.CodeStage.AdvancedFPSCounter.Labels;

namespace Voodoo.Sauce.Internal.DebugScreen.CodeStage.AdvancedFPSCounter.CountersData
{
	[Serializable]
	public abstract class BaseCounterData
	{
		protected const string BoldStart = "<b>";

		protected const string BoldEnd = "</b>";

		protected const string ItalicStart = "<i>";

		protected const string ItalicEnd = "</i>";

		internal StringBuilder text;

		internal bool dirty;

		[NonSerialized]
		protected AFPSCounter main;

		protected string colorCached;

		protected bool inited;

		[SerializeField]
		protected bool enabled;

		[Tooltip("Current anchoring label for the counter output.\nRefreshes both previous and specified label when switching anchor.")]
		[SerializeField]
		protected LabelAnchor anchor;

		[Tooltip("Regular color of the counter output.")]
		[SerializeField]
		protected Color color;

		[Tooltip("Controls text style.")]
		[SerializeField]
		protected FontStyle style;

		[Tooltip("Additional text to append to the end of the counter in normal Operation Mode.")]
		protected string extraText;

		public bool Enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public LabelAnchor Anchor
		{
			get
			{
				return default(LabelAnchor);
			}
			set
			{
			}
		}

		public Color Color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public FontStyle Style
		{
			get
			{
				return default(FontStyle);
			}
			set
			{
			}
		}

		public string ExtraText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Refresh()
		{
		}

		internal virtual void UpdateValue()
		{
		}

		internal abstract void UpdateValue(bool force);

		internal void Init(AFPSCounter reference)
		{
		}

		internal void Destroy()
		{
		}

		internal virtual void Activate()
		{
		}

		internal virtual void Deactivate()
		{
		}

		protected virtual void PerformInitActions()
		{
		}

		protected virtual void PerformActivationActions()
		{
		}

		protected virtual void PerformDeActivationActions()
		{
		}

		protected abstract bool HasData();

		protected abstract void CacheCurrentColor();

		protected void ApplyTextStyles()
		{
		}
	}
}
