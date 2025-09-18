using UnityEngine;

public class ResourceManagedParticleSystem : MonoBehaviour, IPooledObject
{
	private ParticleSystem ps;

	private void Awake()
	{
	}

	public void OnObjectSpawn()
	{
	}
}
