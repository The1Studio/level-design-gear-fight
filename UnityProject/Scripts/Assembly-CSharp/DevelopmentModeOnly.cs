using TMPro;
using UnityEngine;

public class DevelopmentModeOnly : MonoBehaviour
{
	public TextMeshProUGUI developmentModeTextUI;

	private const string DEFAULT_DEVELOPMENT_TEXT = "DEVELOPMENT BUILD";

	private const string DEVELOPMENT_TEXT_WITH_SUPER_PREMIUM = "DEVELOPMENT BUILD \nwith Super Premium";

	private void Awake()
	{
	}

	private void Start()
	{
	}
}
