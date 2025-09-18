using System;
using DG.Tweening;
using UnityEngine;

[Serializable]
public class AnimatedProperties
{
	public AnimationType AnimationType;

	public bool IsRelative;

	public Ease EaseType;

	public int LoopCount;

	public float Duration;

	public LoopType LoopType;

	public bool blockNext;

	public bool hasStartValue;

	public Vector3 startVector;

	public float startValue;

	public Vector3 endVector;

	public float endValue;

	public float power;

	public int numberOfJumps;

	public bool UseCustomCurve;

	public AnimationCurve CustomCurve;

	public bool useShortestRotation;

	public float punchElasticity;

	public int punchVibration;

	public bool IsPlaying;

	public bool IsInitialised;

	public bool IsShowing;

	public string uniqueID;

	public AnimatedProperties Copy()
	{
		return null;
	}
}
