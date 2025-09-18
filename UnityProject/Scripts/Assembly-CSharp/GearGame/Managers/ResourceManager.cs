using System;
using System.Collections.Generic;
using UnityEngine;

namespace GearGame.Managers
{
	public class ResourceManager : MonoBehaviour
	{
		[Serializable]
		public class Pool
		{
			[field: SerializeField]
			public string Tag { get; private set; }

			[field: SerializeField]
			public GameObject Prefab { get; private set; }

			[field: SerializeField]
			public int Size { get; private set; }

			[field: SerializeField]
			public Transform Parent { get; private set; }
		}

		private static ResourceManager instance;

		[SerializeField]
		private List<Pool> pools;

		private readonly Dictionary<string, Queue<GameObject>> poolDictionary;

		private readonly Dictionary<string, Pool> objectReferenceDict;

		public static ResourceManager Instance => null;

		private void CreateSingleton()
		{
		}

		private void OnDestroy()
		{
		}

		private void Awake()
		{
		}

		private void Init()
		{
		}

		public void UpdatePool(string tag, GameObject prefab)
		{
		}

		public List<GameObject> GetObjectReferenceList(string tag)
		{
			return null;
		}

		public GameObject SpawnFromPool(string tag, Vector3 position, Transform parent = null)
		{
			return null;
		}
	}
}
