using UnityEngine;

public class CheatEnabler : MonoBehaviour
{
	[SerializeField]
	private string _featureDisplayName;

	[SerializeField]
	private GameObject _root;

	public string FeatureName => null;

	private bool ShouldBeVisible => false;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void RefreshVisibility()
	{
	}

	private void Hide()
	{
	}
}
