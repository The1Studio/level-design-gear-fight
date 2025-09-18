using System.Collections.Generic;
using UnityEngine;

public class AudioSourceVariable : MonoBehaviour
{
	[SerializeField]
	private AudioSource source;

	[SerializeField]
	private Vector2 pitchRange;

	[SerializeField]
	private bool constantPitchChange;

	[SerializeField]
	private bool limitMultiplePlays;

	[SerializeField]
	private float timeBetweenPlays;

	[SerializeField]
	private string uniqueID;

	[SerializeField]
	private bool incrementPitch;

	[SerializeField]
	private string uniquePitchID;

	[SerializeField]
	private float pitchIncrement;

	[SerializeField]
	private float pitchIncrementMax;

	[SerializeField]
	private float pitchIncrementMaxTime;

	private static readonly Dictionary<string, float> dictionaryTimer;

	private static readonly Dictionary<string, float> dictionaryPitchScaleTime;

	private static readonly Dictionary<string, float> dictionaryPitchNumber;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnValidate()
	{
	}

	public void Play()
	{
	}
}
