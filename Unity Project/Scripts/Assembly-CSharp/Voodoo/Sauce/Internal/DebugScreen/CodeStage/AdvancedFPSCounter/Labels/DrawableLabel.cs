using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Internal.DebugScreen.CodeStage.AdvancedFPSCounter.Labels
{
	internal class DrawableLabel
	{
		internal GameObject container;

		internal LabelAnchor anchor;

		internal StringBuilder newText;

		internal bool dirty;

		private GameObject labelGameObject;

		private RectTransform labelTransform;

		private ContentSizeFitter labelFitter;

		private HorizontalLayoutGroup labelGroup;

		private GameObject uiTextGameObject;

		private Text uiText;

		private Font font;

		private int fontSize;

		private float lineSpacing;

		private Vector2 pixelOffset;

		private readonly LabelEffect background;

		private Image backgroundImage;

		private readonly LabelEffect shadow;

		private Shadow shadowComponent;

		private readonly LabelEffect outline;

		private Outline outlineComponent;

		internal DrawableLabel(GameObject container, LabelAnchor anchor, LabelEffect background, LabelEffect shadow, LabelEffect outline, Font font, int fontSize, float lineSpacing, Vector2 pixelOffset)
		{
		}

		internal void CheckAndUpdate()
		{
		}

		internal void Clear()
		{
		}

		internal void Destroy()
		{
		}

		internal void ChangeFont(Font labelsFont)
		{
		}

		internal void ChangeFontSize(int newSize)
		{
		}

		internal void ChangeOffset(Vector2 newPixelOffset)
		{
		}

		internal void ChangeLineSpacing(float newValueLineSpacing)
		{
		}

		internal void ChangeBackground(bool enabled)
		{
		}

		internal void ChangeBackgroundColor(Color color)
		{
		}

		public void ChangeBackgroundPadding(int backgroundPadding)
		{
		}

		internal void ChangeShadow(bool enabled)
		{
		}

		internal void ChangeShadowColor(Color color)
		{
		}

		internal void ChangeShadowDistance(Vector2 distance)
		{
		}

		internal void ChangeOutline(bool enabled)
		{
		}

		internal void ChangeOutlineColor(Color color)
		{
		}

		internal void ChangeOutlineDistance(Vector2 distance)
		{
		}

		private void UpdateTextPosition()
		{
		}

		private void NormalizeOffset()
		{
		}

		private void ApplyBackground()
		{
		}

		private void ApplyShadow()
		{
		}

		private void ApplyOutline()
		{
		}

		private void ApplyFont()
		{
		}
	}
}
