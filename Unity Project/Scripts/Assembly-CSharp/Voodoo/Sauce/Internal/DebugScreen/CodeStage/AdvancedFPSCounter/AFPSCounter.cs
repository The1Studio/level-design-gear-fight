using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Voodoo.Sauce.Internal.DebugScreen.CodeStage.AdvancedFPSCounter.CountersData;
using Voodoo.Sauce.Internal.DebugScreen.CodeStage.AdvancedFPSCounter.Labels;

namespace Voodoo.Sauce.Internal.DebugScreen.CodeStage.AdvancedFPSCounter
{
	[DisallowMultipleComponent]
	[AddComponentMenu("Code Stage/\ud83d\ude80 Advanced FPS Counter")]
	[HelpURL("http://codestage.net/uas_files/afps/api/class_code_stage_1_1_advanced_f_p_s_counter_1_1_a_f_p_s_counter.html")]
	public class AFPSCounter : MonoBehaviour
	{
		private const string MenuPath = "Code Stage/\ud83d\ude80 Advanced FPS Counter";

		private const string ComponentName = "Advanced FPS Counter";

		internal const string LogPrefix = "[AFPSCounter]: ";

		internal const char NewLine = '\n';

		internal const char Space = ' ';

		public FPSCounterData fpsCounter;

		public MemoryCounterData memoryCounter;

		public DeviceInfoCounterData deviceInfoCounter;

		[Tooltip("Used to enable / disable plugin at runtime.\nSet to None to disable.")]
		public KeyCode hotKey;

		[Tooltip("Used to enable / disable plugin at runtime.\nMake two circle gestures with your finger \\ mouse to switch plugin on and off.")]
		public bool circleGesture;

		[Tooltip("Hot key modifier: any Control on Windows or any Command on Mac.")]
		public bool hotKeyCtrl;

		[Tooltip("Hot key modifier: any Shift.")]
		public bool hotKeyShift;

		[Tooltip("Hot key modifier: any Alt.")]
		public bool hotKeyAlt;

		[SerializeField]
		[Tooltip("Prevents current or other topmost Game Object from destroying on level (scene) load.\nApplied once, on Start phase.")]
		private bool keepAlive;

		private Canvas canvas;

		private CanvasScaler canvasScaler;

		private bool externalCanvas;

		private DrawableLabel[] labels;

		private int anchorsCount;

		private int cachedVSync;

		private int cachedFrameRate;

		private bool inited;

		private readonly List<Vector2> gesturePoints;

		private int gestureCount;

		[SerializeField]
		[Tooltip("Disabled: removes labels and stops all internal processes except Hot Key listener.\n\nBackground: removes labels keeping counters alive; use for hidden performance monitoring.\n\nNormal: shows labels and runs all internal processes as usual.")]
		private OperationMode operationMode;

		[Tooltip("Allows to see how your game performs on specified frame rate.\nDoes not guarantee selected frame rate. Set -1 to render as fast as possible in current conditions.\nIMPORTANT: this option disables VSync while enabled!")]
		[SerializeField]
		private bool forceFrameRate;

		[SerializeField]
		[Range(-1f, 200f)]
		private int forcedFrameRate;

		[SerializeField]
		[Tooltip("Background for all texts. Cheapest effect. Overhead: 1 Draw Call.")]
		private bool background;

		[SerializeField]
		[Tooltip("Color of the background.")]
		private Color backgroundColor;

		[SerializeField]
		[Range(0f, 30f)]
		[Tooltip("Padding of the background.")]
		private int backgroundPadding;

		[Tooltip("Shadow effect for all texts. This effect uses extra resources. Overhead: medium CPU and light GPU usage.")]
		[SerializeField]
		private bool shadow;

		[Tooltip("Color of the shadow effect.")]
		[SerializeField]
		private Color shadowColor;

		[Tooltip("Distance of the shadow effect.")]
		[SerializeField]
		private Vector2 shadowDistance;

		[Tooltip("Outline effect for all texts. Resource-heaviest effect. Overhead: huge CPU and medium GPU usage. Not recommended for use unless really necessary.")]
		[SerializeField]
		private bool outline;

		[Tooltip("Color of the outline effect.")]
		[SerializeField]
		private Color outlineColor;

		[Tooltip("Distance of the outline effect.")]
		[SerializeField]
		private Vector2 outlineDistance;

		[Tooltip("Controls own Canvas Scaler scale mode. Check to use ScaleWithScreenSize. Otherwise ConstantPixelSize will be used.")]
		[SerializeField]
		private bool autoScale;

		[Tooltip("Controls global scale of all texts.")]
		[SerializeField]
		[Range(0f, 30f)]
		private float scaleFactor;

		[SerializeField]
		[Tooltip("Leave blank to use default font.")]
		private Font labelsFont;

		[SerializeField]
		[Range(0f, 100f)]
		[Tooltip("Set to 0 to use font size specified in the font importer.")]
		private int fontSize;

		[Range(0f, 10f)]
		[Tooltip("Space between lines in labels.")]
		[SerializeField]
		private float lineSpacing;

		[Range(0f, 10f)]
		[Tooltip("Lines count between different counters in a single label.")]
		[SerializeField]
		private int countersSpacing;

		[Tooltip("Pixel offset for anchored labels. Automatically applied to all labels.")]
		[SerializeField]
		private Vector2 paddingOffset;

		[Tooltip("Controls own canvas Pixel Perfect property.")]
		[SerializeField]
		private bool pixelPerfect;

		[Tooltip("Sorting order to use for the canvas.\nSet higher value to get closer to the user.")]
		[SerializeField]
		private int sortingOrder;

		public bool KeepAlive => false;

		public OperationMode OperationMode
		{
			get
			{
				return default(OperationMode);
			}
			set
			{
			}
		}

		public bool ForceFrameRate
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int ForcedFrameRate
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool Background
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Color BackgroundColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public int BackgroundPadding
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool Shadow
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Color ShadowColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Vector2 ShadowDistance
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public bool Outline
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Color OutlineColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Vector2 OutlineDistance
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public bool AutoScale
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float ScaleFactor
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Font LabelsFont
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int FontSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float LineSpacing
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int CountersSpacing
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Vector2 PaddingOffset
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public bool PixelPerfect
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int SortingOrder
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static AFPSCounter Instance { get; private set; }

		private AFPSCounter()
		{
		}

		private static AFPSCounter GetOrCreateInstance(bool keepAlive)
		{
			return null;
		}

		public static AFPSCounter AddToScene()
		{
			return null;
		}

		public static AFPSCounter AddToScene(bool keepAlive)
		{
			return null;
		}

		[Obsolete("Please use SelfDestroy() instead. This method will be removed in future updates.")]
		public static void Dispose()
		{
		}

		public static void SelfDestroy()
		{
		}

		internal static string Color32ToHex(Color32 color)
		{
			return null;
		}

		private static AFPSCounter CreateInScene(bool lookForExistingContainer = true)
		{
			return null;
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
		}

		private void OnLevelLoadedCallback()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		internal void MakeDrawableLabelDirty(LabelAnchor anchor)
		{
		}

		internal void UpdateTexts()
		{
		}

		private void ConfigureCanvas()
		{
		}

		private void ConfigureLabels()
		{
		}

		private void DisposeInternal()
		{
		}

		private void ProcessHotKey()
		{
		}

		private bool CircleGestureMade()
		{
			return false;
		}

		private void SwitchCounter()
		{
		}

		private void ActivateCounters()
		{
		}

		private void DeactivateCounters()
		{
		}

		private void RefreshForcedFrameRate()
		{
		}

		private void RefreshForcedFrameRate(bool disabling)
		{
		}
	}
}
