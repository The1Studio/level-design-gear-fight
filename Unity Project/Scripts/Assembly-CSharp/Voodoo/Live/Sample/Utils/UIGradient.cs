using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Live.Sample.Utils
{
	[AddComponentMenu("UI/Effects/Gradient")]
	public class UIGradient : BaseMeshEffect
	{
		public Color m_color1;

		public Color m_color2;

		[Range(-180f, 180f)]
		public float m_angle;

		public bool m_ignoreRatio;

		public override void ModifyMesh(VertexHelper vh)
		{
		}
	}
}
