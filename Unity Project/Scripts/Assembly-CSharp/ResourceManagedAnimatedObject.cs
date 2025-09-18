using UnityEngine;

public class ResourceManagedAnimatedObject : MonoBehaviour, IPooledObject
{
	public Animator anim;

	public string BaseAnimationStateName;

	public void OnObjectSpawn()
	{
	}

	public void OnAnimationCompleted()
	{
	}
}
