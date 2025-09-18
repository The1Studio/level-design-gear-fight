using UnityEngine;
using UnityEngine.Events;

public class SimpleAnimationCallbackHandler : MonoBehaviour
{
	public GameObject[] additionalCallbackGameObjects;

	public UnityEvent TriggerEvent0;

	public UnityEvent TriggerEvent1;

	public UnityEvent TriggerEvent2;

	public UnityEvent TriggerEvent3;

	public UnityEvent TriggerEvent4;

	public UnityEvent TriggerEvent5;

	public UnityEvent TriggerEvent6;

	public UnityEvent OnEnabled;

	[SerializeField]
	private Animator anim;

	private UnityEvent[] _triggerEvents;

	public UnityEvent this[int index]
	{
		get
		{
			return null;
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

	public void Destroy()
	{
	}

	public void DeactivateThis()
	{
	}

	public void PlayAudio(string tag)
	{
	}

	public void ToggleAnimationBool(string property)
	{
	}

	public void Trigger0()
	{
	}

	public void Trigger1()
	{
	}

	public void Trigger2()
	{
	}

	public void Trigger3()
	{
	}

	public void Trigger4()
	{
	}

	public void Trigger5()
	{
	}

	public void Trigger6()
	{
	}

	public void SetTrigger(string trigger)
	{
	}

	public void SetBoolTrue(string boolString)
	{
	}

	public void SetBoolFalse(string boolString)
	{
	}
}
