using Cinemachine;
using UnityEngine;

namespace GearGame.Gameplay.Managers
{
	public class CameraManager2D : MonoBehaviour
	{
		private static CameraManager2D instance;

		[SerializeField]
		private Camera cam;

		[SerializeField]
		private CinemachineVirtualCamera storeCamera;

		[SerializeField]
		private CinemachineVirtualCamera combatCamera;

		[SerializeField]
		private CinemachineVirtualCamera pregameCamera;

		[SerializeField]
		private float xBuffer;

		private float cachedLeftBound;

		private float cachedRightBound;

		public static CameraManager2D Instance => null;

		private void CreateSingleton()
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Start()
		{
		}

		private void StateChanged(GameStateManager.GameState state)
		{
		}

		public float GetLeftBound(bool includeBuffer)
		{
			return 0f;
		}

		public float GetRightBound(bool includeBuffer)
		{
			return 0f;
		}

		public bool IsInBounds(Vector3 position, float additionalX)
		{
			return false;
		}

		public Vector3 ConvertFrom3DWorldspace(Vector3 worldspace)
		{
			return default(Vector3);
		}
	}
}
