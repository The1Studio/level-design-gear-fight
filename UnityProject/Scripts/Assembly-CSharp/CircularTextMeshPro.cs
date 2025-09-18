using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
[ExecuteInEditMode]
public class CircularTextMeshPro : MonoBehaviour
{
	private TextMeshProUGUI m_TextComponent;

	[SerializeField]
	[HideInInspector]
	private float m_radius;

	[Tooltip("The radius of the text circle arc")]
	public float Radius
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	protected void OnCurvePropertyChanged()
	{
	}

	protected void UpdateTextCurve(TMP_TextInfo textInfo)
	{
	}

	protected Matrix4x4 ComputeTransformationMatrix(Vector3 charMidBaselinePos, TMP_TextInfo textInfo, int charIdx)
	{
		return default(Matrix4x4);
	}
}
