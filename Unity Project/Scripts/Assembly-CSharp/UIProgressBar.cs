using UnityEngine;

[ExecuteAlways]
public class UIProgressBar : MonoBehaviour
{
	[SerializeField]
	[Range(0f, 1f)]
	private float testProgress;

	[SerializeField]
	private GameObject progressFillGameObject;

	private float progress;

	private float progressContainerWidth;

	private RectTransform progressContainerRect;

	public float Progress
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

	private void OnValidate()
	{
	}
}
