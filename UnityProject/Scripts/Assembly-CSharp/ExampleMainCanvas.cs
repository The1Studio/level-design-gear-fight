using UnityEngine;

public class ExampleMainCanvas : MonoBehaviour
{
	public NotConnectedScreen NotConnectedScreen;

	public ConnectedScreen ConnectedScreen;

	public LeaderboardExampleUI LeaderboardUI;

	public CloudSaveAccountResolutionPopup CloudSaveAccountResolutionPopup;

	public GenericPopup GenericPopup;

	private static ExampleMainCanvas _instance;

	public static ExampleMainCanvas Instance => null;

	private void Awake()
	{
	}

	public void ShowConnectedScreen()
	{
	}
}
