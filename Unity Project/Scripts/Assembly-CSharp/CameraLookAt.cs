using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
	[SerializeField]
	private bool constrainY;

	[SerializeField]
	private bool flipY;

	[SerializeField]
	private bool hardCameraClamp;

	[SerializeField]
	private bool scaleWithDistance;

	[SerializeField]
	private float distanceScale;

	[SerializeField]
	private Vector2 scaleRange;

	private Vector3 baseScale;

	public Camera Cam { get; set; }

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}
}
