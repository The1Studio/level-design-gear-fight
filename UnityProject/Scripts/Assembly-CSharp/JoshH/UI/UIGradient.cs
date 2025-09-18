using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace JoshH.UI
{
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("UI/Effects/UI Gradient")]
	public class UIGradient : BaseMeshEffect
	{
		public enum UIGradientBlendMode
		{
			Override = 0,
			Multiply = 1
		}

		public enum UIGradientType
		{
			Linear = 0,
			Corner = 1,
			ComplexLinear = 2
		}

		[Tooltip("How the gradient color will be blended with the graphics color.")]
		[SerializeField]
		private UIGradientBlendMode blendMode;

		[SerializeField]
		[Range(0f, 1f)]
		private float intensity;

		[SerializeField]
		private UIGradientType gradientType;

		[SerializeField]
		private Color linearColor1;

		[SerializeField]
		private Color linearColor2;

		[SerializeField]
		private Color cornerColorUpperLeft;

		[SerializeField]
		private Color cornerColorUpperRight;

		[SerializeField]
		private Color cornerColorLowerRight;

		[SerializeField]
		private Color cornerColorLowerLeft;

		[SerializeField]
		private Gradient linearGradient;

		[Range(0f, 360f)]
		[SerializeField]
		private float angle;

		private RectTransform _rectTransform;

		protected RectTransform rectTransform => null;

		public UIGradientBlendMode BlendMode
		{
			get
			{
				return default(UIGradientBlendMode);
			}
			set
			{
			}
		}

		public float Intensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public UIGradientType GradientType
		{
			get
			{
				return default(UIGradientType);
			}
			set
			{
			}
		}

		public Color LinearColor1
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color LinearColor2
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color CornerColorUpperLeft
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color CornerColorUpperRight
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color CornerColorLowerRight
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color CornerColorLowerLeft
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public float Angle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Gradient LinearGradient
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override void ModifyMesh(VertexHelper vh)
		{
		}

		protected void CutMesh(VertexHelper vh)
		{
		}

		private UIVertex UIVertexLerp(UIVertex v1, UIVertex v2, float f)
		{
			return default(UIVertex);
		}

		private Vector2 GetCutDirection()
		{
			return default(Vector2);
		}

		private void CutTriangle(List<UIVertex> tris, int idx, List<UIVertex> list, Vector2 cutDirection, Vector2 point)
		{
		}

		private bool IsOnLine(float f)
		{
			return false;
		}

		private float OnLine(Vector2 p1, Vector2 p2, Vector2 o, Vector2 dir)
		{
			return 0f;
		}

		private float ProjectedDistance(Vector2 p1, Vector2 p2, Vector2 normal)
		{
			return 0f;
		}

		private Vector2 GetCutOrigin(float f)
		{
			return default(Vector2);
		}

		private Color BlendColor(Color c1, Color c2, UIGradientBlendMode mode, float intensity)
		{
			return default(Color);
		}

		private Vector2 RotateNormalizedPosition(Vector2 normalizedPosition, float angle)
		{
			return default(Vector2);
		}

		public void ForceUpdateGraphic()
		{
		}

		private Color GetColorInGradient(Color ul, Color ur, Color lr, Color ll, Vector2 normalizedPosition)
		{
			return default(Color);
		}
	}
}
