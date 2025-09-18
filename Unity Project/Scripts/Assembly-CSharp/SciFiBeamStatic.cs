using UnityEngine;

public class SciFiBeamStatic : MonoBehaviour
{
	[Header("Prefabs")]
	public GameObject beamLineRendererPrefab;

	public GameObject beamStartPrefab;

	public GameObject beamEndPrefab;

	private GameObject beamStart;

	private GameObject beamEnd;

	private GameObject beam;

	private LineRenderer line;

	[Header("Beam Options")]
	public bool alwaysOn;

	public bool beamCollides;

	public float beamLength;

	public float beamEndOffset;

	public float textureScrollSpeed;

	public float textureLengthScale;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void FixedUpdate()
	{
	}

	public void SpawnBeam()
	{
	}

	public void RemoveBeam()
	{
	}
}
