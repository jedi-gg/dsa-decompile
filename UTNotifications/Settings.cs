using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace UTNotifications
{
	public class Settings : ScriptableObject
	{
		[FieldOffset(Offset="0x0")]
		public const string Version = "1.7.3";

		[FieldOffset(Offset="0x0")]
		public const string DEFAULT_PROFILE_NAME = "default";

		[FieldOffset(Offset="0x0")]
		public const string DEFAULT_PROFILE_NAME_INTERNAL = "__default_profile";

		[FieldOffset(Offset="0x18")]
		[SerializeField]
		private List<Settings.NotificationProfile> m_notificationProfiles;

		[FieldOffset(Offset="0x20")]
		[SerializeField]
		private string m_pushPayloadTitleFieldName;

		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private string m_pushPayloadTextFieldName;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private string m_pushPayloadIdFieldName;

		[FieldOffset(Offset="0x38")]
		[SerializeField]
		private string m_pushPayloadUserDataParentFieldName;

		[FieldOffset(Offset="0x40")]
		[SerializeField]
		private string m_pushPayloadNotificationProfileFieldName;

		[FieldOffset(Offset="0x48")]
		[SerializeField]
		private string m_pushPayloadBadgeFieldName;

		[FieldOffset(Offset="0x50")]
		[SerializeField]
		private string m_pushPayloadButtonsParentName;

		[FieldOffset(Offset="0x58")]
		[SerializeField]
		private string m_googlePlayServicesLibVersion;

		[FieldOffset(Offset="0x60")]
		[SerializeField]
		private string m_androidSupportLibVersion;

		[FieldOffset(Offset="0x68")]
		[SerializeField]
		private Settings.ShowNotifications m_androidShowNotificationsMode;

		[FieldOffset(Offset="0x6C")]
		[SerializeField]
		private bool m_android4CompatibilityMode;

		[FieldOffset(Offset="0x6D")]
		[SerializeField]
		private bool m_androidRestoreScheduledNotificationsAfterReboot;

		[FieldOffset(Offset="0x70")]
		[SerializeField]
		private Settings.NotificationsGroupingMode m_androidNotificationsGrouping;

		[FieldOffset(Offset="0x74")]
		[SerializeField]
		private bool m_androidShowLatestNotificationOnly;

		[FieldOffset(Offset="0x75")]
		[SerializeField]
		private bool m_pushNotificationsEnabledIOS;

		[FieldOffset(Offset="0x76")]
		[SerializeField]
		private bool m_pushNotificationsEnabledFirebase;

		[FieldOffset(Offset="0x77")]
		[SerializeField]
		private bool m_pushNotificationsEnabledAmazon;

		[FieldOffset(Offset="0x78")]
		[SerializeField]
		private bool m_pushNotificationsEnabledWindows;

		[FieldOffset(Offset="0x7C")]
		[SerializeField]
		private Settings.GooglePlayUpdatingIfRequiredMode m_allowUpdatingGooglePlayIfRequired;

		[FieldOffset(Offset="0x80")]
		[SerializeField]
		private string m_firebaseSenderID;

		[FieldOffset(Offset="0x88")]
		[SerializeField]
		private string m_assetVersionSaved;

		[FieldOffset(Offset="0x90")]
		[SerializeField]
		private bool m_windowsDontShowWhenRunning;

		[FieldOffset(Offset="0x0")]
		private const string m_assetName = "UTNotificationsSettings";

		[FieldOffset(Offset="0x0")]
		private const string m_settingsMenuItem = "Edit/Project Settings/UTNotifications";

		[FieldOffset(Offset="0x0")]
		private static Settings m_instance;

		public Settings.GooglePlayUpdatingIfRequiredMode AllowUpdatingGooglePlayIfRequired
		{
			[Address(RVA="0x1582788", Offset="0x1582788", VA="0x1582788")]
			get
			{
				return new Settings.GooglePlayUpdatingIfRequiredMode();
			}
			[Address(RVA="0x1582790", Offset="0x1582790", VA="0x1582790")]
			set
			{
			}
		}

		public Settings.NotificationsGroupingMode AndroidNotificationsGrouping
		{
			[Address(RVA="0x158276C", Offset="0x158276C", VA="0x158276C")]
			get
			{
				return new Settings.NotificationsGroupingMode();
			}
			[Address(RVA="0x1582774", Offset="0x1582774", VA="0x1582774")]
			set
			{
			}
		}

		public bool AndroidRestoreScheduledNotificationsAfterReboot
		{
			[Address(RVA="0x1582764", Offset="0x1582764", VA="0x1582764")]
			get
			{
				return new bool();
			}
		}

		public bool AndroidShowLatestNotificationOnly
		{
			[Address(RVA="0x15827A4", Offset="0x15827A4", VA="0x15827A4")]
			get
			{
				return new bool();
			}
		}

		public Settings.ShowNotifications AndroidShowNotificationsMode
		{
			[Address(RVA="0x1582748", Offset="0x1582748", VA="0x1582748")]
			get
			{
				return new Settings.ShowNotifications();
			}
			[Address(RVA="0x1582750", Offset="0x1582750", VA="0x1582750")]
			set
			{
			}
		}

		public string AndroidSupportLibVersion
		{
			[Address(RVA="0x158266C", Offset="0x158266C", VA="0x158266C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1582674", Offset="0x1582674", VA="0x1582674")]
			set
			{
			}
		}

		public string FirebaseSenderID
		{
			[Address(RVA="0x15827AC", Offset="0x15827AC", VA="0x15827AC")]
			get
			{
				return null;
			}
		}

		public string GooglePlayServicesLibVersion
		{
			[Address(RVA="0x1582630", Offset="0x1582630", VA="0x1582630")]
			get
			{
				return null;
			}
			[Address(RVA="0x1582638", Offset="0x1582638", VA="0x1582638")]
			set
			{
			}
		}

		public static Settings Instance
		{
			[Address(RVA="0x1582224", Offset="0x1582224", VA="0x1582224")]
			get
			{
				return null;
			}
		}

		public List<Settings.NotificationProfile> NotificationProfiles
		{
			[Address(RVA="0x1582364", Offset="0x1582364", VA="0x1582364")]
			get
			{
				return null;
			}
		}

		public bool PushNotificationsEnabledAmazon
		{
			[Address(RVA="0x15826F8", Offset="0x15826F8", VA="0x15826F8")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1582700", Offset="0x1582700", VA="0x1582700")]
			set
			{
			}
		}

		public bool PushNotificationsEnabledFirebase
		{
			[Address(RVA="0x15826D0", Offset="0x15826D0", VA="0x15826D0")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x15826D8", Offset="0x15826D8", VA="0x15826D8")]
			set
			{
			}
		}

		public bool PushNotificationsEnabledIOS
		{
			[Address(RVA="0x15826A8", Offset="0x15826A8", VA="0x15826A8")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x15826B0", Offset="0x15826B0", VA="0x15826B0")]
			set
			{
			}
		}

		public bool PushNotificationsEnabledWindows
		{
			[Address(RVA="0x1582720", Offset="0x1582720", VA="0x1582720")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1582728", Offset="0x1582728", VA="0x1582728")]
			set
			{
			}
		}

		public string PushPayloadBadgeFieldName
		{
			[Address(RVA="0x15825B8", Offset="0x15825B8", VA="0x15825B8")]
			get
			{
				return null;
			}
			[Address(RVA="0x15825C0", Offset="0x15825C0", VA="0x15825C0")]
			set
			{
			}
		}

		public string PushPayloadButtonsParentName
		{
			[Address(RVA="0x15825F4", Offset="0x15825F4", VA="0x15825F4")]
			get
			{
				return null;
			}
			[Address(RVA="0x15825FC", Offset="0x15825FC", VA="0x15825FC")]
			set
			{
			}
		}

		public string PushPayloadIdFieldName
		{
			[Address(RVA="0x1582504", Offset="0x1582504", VA="0x1582504")]
			get
			{
				return null;
			}
			[Address(RVA="0x158250C", Offset="0x158250C", VA="0x158250C")]
			set
			{
			}
		}

		public string PushPayloadNotificationProfileFieldName
		{
			[Address(RVA="0x158257C", Offset="0x158257C", VA="0x158257C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1582584", Offset="0x1582584", VA="0x1582584")]
			set
			{
			}
		}

		public string PushPayloadTextFieldName
		{
			[Address(RVA="0x15824C8", Offset="0x15824C8", VA="0x15824C8")]
			get
			{
				return null;
			}
			[Address(RVA="0x15824D0", Offset="0x15824D0", VA="0x15824D0")]
			set
			{
			}
		}

		public string PushPayloadTitleFieldName
		{
			[Address(RVA="0x158248C", Offset="0x158248C", VA="0x158248C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1582494", Offset="0x1582494", VA="0x1582494")]
			set
			{
			}
		}

		public string PushPayloadUserDataParentFieldName
		{
			[Address(RVA="0x1582540", Offset="0x1582540", VA="0x1582540")]
			get
			{
				return null;
			}
			[Address(RVA="0x1582548", Offset="0x1582548", VA="0x1582548")]
			set
			{
			}
		}

		public bool WindowsDontShowWhenRunning
		{
			[Address(RVA="0x15827B4", Offset="0x15827B4", VA="0x15827B4")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x15827BC", Offset="0x15827BC", VA="0x15827BC")]
		public Settings()
		{
		}

		public enum GooglePlayUpdatingIfRequiredMode
		{
			[FieldOffset(Offset="0x0")]
			DISABLED,
			[FieldOffset(Offset="0x0")]
			ONCE,
			[FieldOffset(Offset="0x0")]
			EVERY_INITIALIZE
		}

		[Serializable]
		public struct NotificationProfile
		{
			[FieldOffset(Offset="0x0")]
			public string profileName;

			[FieldOffset(Offset="0x8")]
			public string iosSound;

			[FieldOffset(Offset="0x10")]
			public string androidChannelName;

			[FieldOffset(Offset="0x18")]
			public string androidChannelDescription;

			[FieldOffset(Offset="0x20")]
			public string androidIcon;

			[FieldOffset(Offset="0x28")]
			public string androidLargeIcon;

			[FieldOffset(Offset="0x30")]
			public string androidIcon5Plus;

			[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x106C8B4", Offset="0x106C8B4")]
			[FieldOffset(Offset="0x38")]
			public bool colorSpecified;

			[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x106C8EC", Offset="0x106C8EC")]
			[FieldOffset(Offset="0x3C")]
			public Color androidColor;

			[FieldOffset(Offset="0x50")]
			public string androidSound;

			[FieldOffset(Offset="0x58")]
			public bool androidHighPriority;
		}

		public enum NotificationsGroupingMode
		{
			[FieldOffset(Offset="0x0")]
			NONE,
			[FieldOffset(Offset="0x0")]
			BY_NOTIFICATION_PROFILES,
			[FieldOffset(Offset="0x0")]
			FROM_USER_DATA,
			[FieldOffset(Offset="0x0")]
			ALL_IN_A_SINGLE_GROUP
		}

		public enum ShowNotifications
		{
			[FieldOffset(Offset="0x0")]
			WHEN_CLOSED_OR_IN_BACKGROUND,
			[FieldOffset(Offset="0x0")]
			WHEN_CLOSED,
			[FieldOffset(Offset="0x0")]
			ALWAYS
		}

		private class UpdateMessage
		{
			[FieldOffset(Offset="0x10")]
			public readonly string version;

			[FieldOffset(Offset="0x18")]
			public readonly string text;

			[Address(RVA="0x15828CC", Offset="0x15828CC", VA="0x15828CC")]
			public UpdateMessage(string version, string text)
			{
			}
		}
	}
}