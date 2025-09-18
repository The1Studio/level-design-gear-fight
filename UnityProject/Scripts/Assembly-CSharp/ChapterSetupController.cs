using Refactor.Scripts;
using ScriptableTemplates;
using UnityEngine;

public class ChapterSetupController : MonoBehaviour
{
	private static ChapterSetupController _instance;

	[Header("Scene references")]
	[SerializeField]
	private GameObject environmentThemeContainer;

	[SerializeField]
	private AudioSource musicAudioSource;

	[SerializeField]
	private SpriteRenderer slopeSpriteRenderer;

	[SerializeField]
	private Camera scene2dCam;

	private ChapterSettings chapterSettings;

	private EnvironmentThemeView _environmentTheme;

	public static ChapterSetupController Instance => null;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void Setup()
	{
	}

	private void SetupMusic()
	{
	}

	private void SetupEnvironment()
	{
	}
}
