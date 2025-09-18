using UnityEngine;

namespace PaperPlaneTools
{
	public class RateBoxPrefabScript : MonoBehaviour
	{
		[Header("DISPLAY CONDITIONS:")]
		[Tooltip("Minimum number of sessions before prompting a dialog.\nThe counter increases every time the game starts.")]
		public int minSessionCount;

		[Tooltip("Minimum number of a custom events before prompting a dialog.\nThe custom counter increases every time RateBox.IncrementCustomCounter function is called.")]
		public int minCustomEventsCount;

		[Tooltip("Number of hours to wait before prompting a dialog after the application was first time started.\n\nFor example, a value of 2.5 means that the user won't see a rate prompt at least first 2 and a half hours after the installation.")]
		public float delayAfterInstallInHours;

		[Tooltip("Number of hours to wait before prompting a dialog after the application was started. \n\nFor example, a value of 0.2 means that the user won't see a rate prompt at least first 12 minutes (0.2 * 60) after the applications starts.")]
		public float delayAfterLaunchInHours;

		[Tooltip("Number of hours to wait before prompting a dialog after the former one was displayed.\n\nFor example, a value of 12.5 means that the user won't see a rate prompt at least first 12 and a half hours after dismissing the former one.")]
		public float postponeCooldownInHours;

		[Tooltip("Check internet connection before prompting a dialog. This makes sense because user won't be able to rate the app without an internet connection.")]
		public bool requireInternetConnection;

		[Tooltip("Title of the dialog")]
		[Header("TEXT:")]
		public string title;

		[Multiline]
		[Tooltip("Message of the dialog")]
		public string message;

		[Tooltip("Title of the rate-button")]
		public string rateButton;

		[Tooltip("Title of the later-button")]
		public string postponeButton;

		[Tooltip("Title of the rate button.\nIf empty string, the button won't be displayed.")]
		public string rejectButton;

		[Tooltip("Apple AppStore app id.\nThe url will be https://itunes.apple.com/app/id{iTunesAppId}")]
		[Header("RATE URLS:")]
		public string appStoreAppId;

		[Tooltip("Your app bundle id for Google Playe Market.\nThe url will be https://play.google.com/store/apps/details?id={playMarketAppBundleId}")]
		public string playMarketAppBundleId;

		[Header("Settings:")]
		[Tooltip("Use new iOS SKStoreReviewController if available")]
		public bool useIOSReview;

		[Header("Custom window:")]
		[Tooltip("Show custom UI window instead of native alerts")]
		public GameObject customUIWindow;

		[Header("DEBUG (Unity Editor Only):")]
		[Tooltip("Clear statistics on start.\nSometimes you don't want RateBox to store statistics permanently, for instance, if you reject the prompt once, you will never see it again.\nThis behavior is not always desired when debugging, so by enabling 'Clear On Start' you can start from the blank state every time you launch the app in the Unity Editor.")]
		public bool clearOnStart;

		[Tooltip("Turn on debug to report conditions check log.\nThis will help to understand why a dialog doesn't appear after calling Show method.")]
		public bool logDebugMessages;

		private void Start()
		{
		}
	}
}
