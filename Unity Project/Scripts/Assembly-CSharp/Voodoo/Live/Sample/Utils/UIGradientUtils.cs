using UnityEngine;

namespace Voodoo.Live.Sample.Utils
{
	public static class UIGradientUtils
	{
		public struct Matrix2x3
		{
			public float m00;

			public float m01;

			public float m02;

			public float m10;

			public float m11;

			public float m12;

			public Matrix2x3(float m00, float m01, float m02, float m10, float m11, float m12)
			{
				this.m00 = 0f;
				this.m01 = 0f;
				this.m02 = 0f;
				this.m10 = 0f;
				this.m11 = 0f;
				this.m12 = 0f;
			}

			public static Vector2 operator *(Matrix2x3 m, Vector2 v)
			{
				return default(Vector2);
			}
		}

		private static Vector2[] ms_verticesPositions;

		public static Vector2[] VerticePositions => null;

		public static Matrix2x3 LocalPositionMatrix(Rect rect, Vector2 dir)
		{
			return default(Matrix2x3);
		}

		public static Vector2 RotationDir(float angle)
		{
			return default(Vector2);
		}

		public static Vector2 CompensateAspectRatio(Rect rect, Vector2 dir)
		{
			return default(Vector2);
		}

		public static float InverseLerp(float a, float b, float v)
		{
			return 0f;
		}

		public static Color Bilerp(Color a1, Color a2, Color b1, Color b2, Vector2 t)
		{
			return default(Color);
		}

		public static void Lerp(UIVertex a, UIVertex b, float t, ref UIVertex c)
		{
		}
	}
}
