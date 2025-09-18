namespace PaperPlaneTools
{
	public class AlertIOSOptions
	{
		public static AlertIOSButton.Type DefaultPositiveButton;

		public static AlertIOSButton.Type DefaultNegativeButton;

		public static AlertIOSButton.Type DefaultNeutralButton;

		public static Alert.ButtonType DefaultPreferableButton;

		public static Alert.ButtonType[] DefaultButtonsAddOrder;

		public AlertIOSButton.Type PositiveButton { get; set; }

		public AlertIOSButton.Type NegativeButton { get; set; }

		public AlertIOSButton.Type NeutralButton { get; set; }

		public Alert.ButtonType PreferableButton { get; set; }

		public Alert.ButtonType[] ButtonsAddOrder { get; set; }
	}
}
