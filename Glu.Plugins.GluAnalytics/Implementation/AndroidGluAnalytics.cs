using Glu.Plugins.GluAnalytics;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glu.Plugins.GluAnalytics.Implementation
{
	public class AndroidGluAnalytics : MonoBehaviour, IGluAnalytics, IDisposable
	{
		[FieldOffset(Offset="0x18")]
		private AndroidJavaClass util;

		[FieldOffset(Offset="0x20")]
		private AndroidJavaObject client;

		[FieldOffset(Offset="0x28")]
		private bool pausedResumed;

		[Address(RVA="0x14EEC00", Offset="0x14EEC00", VA="0x14EEC00")]
		public AndroidGluAnalytics()
		{
		}

		[Address(RVA="0x14ED314", Offset="0x14ED314", VA="0x14ED314", Slot="22")]
		public void Dispose()
		{
		}

		[Address(RVA="0x14EE550", Offset="0x14EE550", VA="0x14EE550", Slot="15")]
		public string GetAnalyticsApplicationName()
		{
			return null;
		}

		[Address(RVA="0x14EE4CC", Offset="0x14EE4CC", VA="0x14EE4CC", Slot="14")]
		public string GetAnalyticsDeviceIdentifier()
		{
			return null;
		}

		[Address(RVA="0x14EE5D4", Offset="0x14EE5D4", VA="0x14EE5D4", Slot="16")]
		public string GetAnalyticsEnvironment()
		{
			return null;
		}

		[Address(RVA="0x14EE760", Offset="0x14EE760", VA="0x14EE760", Slot="19")]
		public GeoLocation GetGeoLocation()
		{
			return null;
		}

		[Address(RVA="0x14EE658", Offset="0x14EE658", VA="0x14EE658", Slot="17")]
		public string GetRevenueIdentifier()
		{
			return null;
		}

		[Address(RVA="0x14EE6DC", Offset="0x14EE6DC", VA="0x14EE6DC", Slot="18")]
		public string GetSessionIdentifier()
		{
			return null;
		}

		[Address(RVA="0x14ED040", Offset="0x14ED040", VA="0x14ED040")]
		public void Initialize(string jsonConfig, IDictionary<string, object> runtimeConfig)
		{
		}

		[Address(RVA="0x14EE2B4", Offset="0x14EE2B4", VA="0x14EE2B4", Slot="12")]
		public void LogAdvertisementOpportunity(string placement, string rewardItem, long rewardAmount, bool missed, IDictionary<string, object> userData)
		{
		}

		[Address(RVA="0x14EDE3C", Offset="0x14EDE3C", VA="0x14EDE3C", Slot="10")]
		public void LogCurrencySink(long amount, string currencyName, string item, string itemCategory, string missionId, string missionType, string missionTier, long? hcBalance, long? scBalance, long? secondsInGame, IDictionary<string, object> userData)
		{
		}

		[Address(RVA="0x14EE078", Offset="0x14EE078", VA="0x14EE078", Slot="11")]
		public void LogCurrencySource(long amount, string currencyName, string source, string sourceType, string missionId, string missionType, string missionTier, long? hcBalance, long? scBalance, long? secondsInGame, IDictionary<string, object> userData)
		{
		}

		[Address(RVA="0x14ED37C", Offset="0x14ED37C", VA="0x14ED37C", Slot="4")]
		public void LogEvent(string name, string st1, string st2, string st3, long? val, long? level, IDictionary<string, object> data)
		{
		}

		[Address(RVA="0x14ED5B8", Offset="0x14ED5B8", VA="0x14ED5B8", Slot="5")]
		public void LogInAppPurchaseInUsd(decimal price, string sku, string missionId, string missionType, string missionTier, long? hcBalance, long? scBalance, long? secondsInGame, IDictionary<string, object> userData)
		{
		}

		[Address(RVA="0x14EDC90", Offset="0x14EDC90", VA="0x14EDC90", Slot="9")]
		public void LogMissionCompleted(string missionId, string missionType, string missionTier, long? hcBalance, long? scBalance, long? secondsInGame, IDictionary<string, object> userData)
		{
		}

		[Address(RVA="0x14EDAC4", Offset="0x14EDAC4", VA="0x14EDAC4", Slot="8")]
		public void LogMissionFailed(string failureReason, string missionId, string missionType, string missionTier, long? hcBalance, long? scBalance, long? secondsInGame, IDictionary<string, object> userData)
		{
		}

		[Address(RVA="0x14ED918", Offset="0x14ED918", VA="0x14ED918", Slot="7")]
		public void LogMissionStarted(string missionId, string missionType, string missionTier, long? hcBalance, long? scBalance, long? secondsInGame, IDictionary<string, object> userData)
		{
		}

		[Address(RVA="0x14ED7C4", Offset="0x14ED7C4", VA="0x14ED7C4", Slot="6")]
		public void LogTutorialStepCompleted(string stepName, long? stepNumber, string tutorialId, long? secondsInGame, IDictionary<string, object> userData)
		{
		}

		[Address(RVA="0x14EEB40", Offset="0x14EEB40", VA="0x14EEB40")]
		private void OnApplicationPause(bool paused)
		{
		}

		[Address(RVA="0x14EEAA0", Offset="0x14EEAA0", VA="0x14EEAA0")]
		private void OnDestroy()
		{
		}

		[Address(RVA="0x14EE95C", Offset="0x14EE95C", VA="0x14EE95C", Slot="21")]
		public void PerfSampleEnd(string placement)
		{
		}

		[Address(RVA="0x14EE860", Offset="0x14EE860", VA="0x14EE860", Slot="20")]
		public void PerfSampleStart(string placement, PerfType type, IDictionary<string, object> extraData)
		{
		}

		[Address(RVA="0x14EE3EC", Offset="0x14EE3EC", VA="0x14EE3EC", Slot="13")]
		public void SetUserIdentifier(string userId)
		{
		}

		[Address(RVA="0x14EEA24", Offset="0x14EEA24", VA="0x14EEA24")]
		private static long ValueOrMin(long? v)
		{
			return new long();
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E3F8", Offset="0x104E3F8")]
		private sealed class <>c__DisplayClass10_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidGluAnalytics <>4__this;

			[FieldOffset(Offset="0x18")]
			public string missionId;

			[FieldOffset(Offset="0x20")]
			public string missionType;

			[FieldOffset(Offset="0x28")]
			public string missionTier;

			[FieldOffset(Offset="0x30")]
			public long? hcBalance;

			[FieldOffset(Offset="0x40")]
			public long? scBalance;

			[FieldOffset(Offset="0x50")]
			public long? secondsInGame;

			[FieldOffset(Offset="0x60")]
			public IDictionary<string, object> userData;

			[Address(RVA="0x14EDE34", Offset="0x14EDE34", VA="0x14EDE34")]
			public <>c__DisplayClass10_0()
			{
			}

			[Address(RVA="0x14EEC08", Offset="0x14EEC08", VA="0x14EEC08")]
			internal void <LogMissionCompleted>b__0()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E408", Offset="0x104E408")]
		private sealed class <>c__DisplayClass11_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidGluAnalytics <>4__this;

			[FieldOffset(Offset="0x18")]
			public long amount;

			[FieldOffset(Offset="0x20")]
			public string currencyName;

			[FieldOffset(Offset="0x28")]
			public string item;

			[FieldOffset(Offset="0x30")]
			public string itemCategory;

			[FieldOffset(Offset="0x38")]
			public string missionId;

			[FieldOffset(Offset="0x40")]
			public string missionType;

			[FieldOffset(Offset="0x48")]
			public string missionTier;

			[FieldOffset(Offset="0x50")]
			public long? hcBalance;

			[FieldOffset(Offset="0x60")]
			public long? scBalance;

			[FieldOffset(Offset="0x70")]
			public long? secondsInGame;

			[FieldOffset(Offset="0x80")]
			public IDictionary<string, object> userData;

			[Address(RVA="0x14EE070", Offset="0x14EE070", VA="0x14EE070")]
			public <>c__DisplayClass11_0()
			{
			}

			[Address(RVA="0x14EEFE8", Offset="0x14EEFE8", VA="0x14EEFE8")]
			internal void <LogCurrencySink>b__0()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E418", Offset="0x104E418")]
		private sealed class <>c__DisplayClass12_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidGluAnalytics <>4__this;

			[FieldOffset(Offset="0x18")]
			public long amount;

			[FieldOffset(Offset="0x20")]
			public string currencyName;

			[FieldOffset(Offset="0x28")]
			public string source;

			[FieldOffset(Offset="0x30")]
			public string sourceType;

			[FieldOffset(Offset="0x38")]
			public string missionId;

			[FieldOffset(Offset="0x40")]
			public string missionType;

			[FieldOffset(Offset="0x48")]
			public string missionTier;

			[FieldOffset(Offset="0x50")]
			public long? hcBalance;

			[FieldOffset(Offset="0x60")]
			public long? scBalance;

			[FieldOffset(Offset="0x70")]
			public long? secondsInGame;

			[FieldOffset(Offset="0x80")]
			public IDictionary<string, object> userData;

			[Address(RVA="0x14EE2AC", Offset="0x14EE2AC", VA="0x14EE2AC")]
			public <>c__DisplayClass12_0()
			{
			}

			[Address(RVA="0x14EF524", Offset="0x14EF524", VA="0x14EF524")]
			internal void <LogCurrencySource>b__0()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E428", Offset="0x104E428")]
		private sealed class <>c__DisplayClass13_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidGluAnalytics <>4__this;

			[FieldOffset(Offset="0x18")]
			public string placement;

			[FieldOffset(Offset="0x20")]
			public string rewardItem;

			[FieldOffset(Offset="0x28")]
			public long rewardAmount;

			[FieldOffset(Offset="0x30")]
			public bool missed;

			[FieldOffset(Offset="0x38")]
			public IDictionary<string, object> userData;

			[Address(RVA="0x14EE3E4", Offset="0x14EE3E4", VA="0x14EE3E4")]
			public <>c__DisplayClass13_0()
			{
			}

			[Address(RVA="0x14EFA60", Offset="0x14EFA60", VA="0x14EFA60")]
			internal void <LogAdvertisementOpportunity>b__0()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E438", Offset="0x104E438")]
		private sealed class <>c__DisplayClass21_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidGluAnalytics <>4__this;

			[FieldOffset(Offset="0x18")]
			public string placement;

			[FieldOffset(Offset="0x20")]
			public PerfType type;

			[FieldOffset(Offset="0x28")]
			public IDictionary<string, object> extraData;

			[Address(RVA="0x14EE954", Offset="0x14EE954", VA="0x14EE954")]
			public <>c__DisplayClass21_0()
			{
			}

			[Address(RVA="0x14EFD44", Offset="0x14EFD44", VA="0x14EFD44")]
			internal void <PerfSampleStart>b__0()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E448", Offset="0x104E448")]
		private sealed class <>c__DisplayClass22_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidGluAnalytics <>4__this;

			[FieldOffset(Offset="0x18")]
			public string placement;

			[Address(RVA="0x14EEA1C", Offset="0x14EEA1C", VA="0x14EEA1C")]
			public <>c__DisplayClass22_0()
			{
			}

			[Address(RVA="0x14EFF74", Offset="0x14EFF74", VA="0x14EFF74")]
			internal void <PerfSampleEnd>b__0()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E388", Offset="0x104E388")]
		private sealed class <>c__DisplayClass3_0
		{
			[FieldOffset(Offset="0x10")]
			public string jsonConfig;

			[FieldOffset(Offset="0x18")]
			public IDictionary<string, object> runtimeConfig;

			[Address(RVA="0x14ED304", Offset="0x14ED304", VA="0x14ED304")]
			public <>c__DisplayClass3_0()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E398", Offset="0x104E398")]
		private sealed class <>c__DisplayClass3_1
		{
			[FieldOffset(Offset="0x10")]
			public AndroidJavaObject factory;

			[FieldOffset(Offset="0x18")]
			public AndroidGluAnalytics.<>c__DisplayClass3_0 CS$<>8__locals1;

			[Address(RVA="0x14ED30C", Offset="0x14ED30C", VA="0x14ED30C")]
			public <>c__DisplayClass3_1()
			{
			}

			[Address(RVA="0x14F00C4", Offset="0x14F00C4", VA="0x14F00C4")]
			internal AndroidJavaObject <Initialize>b__0()
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E3A8", Offset="0x104E3A8")]
		private sealed class <>c__DisplayClass5_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidGluAnalytics <>4__this;

			[FieldOffset(Offset="0x18")]
			public string name;

			[FieldOffset(Offset="0x20")]
			public string st1;

			[FieldOffset(Offset="0x28")]
			public string st2;

			[FieldOffset(Offset="0x30")]
			public string st3;

			[FieldOffset(Offset="0x38")]
			public long? val;

			[FieldOffset(Offset="0x48")]
			public long? level;

			[FieldOffset(Offset="0x58")]
			public IDictionary<string, object> data;

			[Address(RVA="0x14ED500", Offset="0x14ED500", VA="0x14ED500")]
			public <>c__DisplayClass5_0()
			{
			}

			[Address(RVA="0x14F0250", Offset="0x14F0250", VA="0x14F0250")]
			internal void <LogEvent>b__0()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E3B8", Offset="0x104E3B8")]
		private sealed class <>c__DisplayClass6_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidGluAnalytics <>4__this;

			[FieldOffset(Offset="0x18")]
			public decimal price;

			[FieldOffset(Offset="0x28")]
			public string sku;

			[FieldOffset(Offset="0x30")]
			public string missionId;

			[FieldOffset(Offset="0x38")]
			public string missionType;

			[FieldOffset(Offset="0x40")]
			public string missionTier;

			[FieldOffset(Offset="0x48")]
			public long? hcBalance;

			[FieldOffset(Offset="0x58")]
			public long? scBalance;

			[FieldOffset(Offset="0x68")]
			public long? secondsInGame;

			[FieldOffset(Offset="0x78")]
			public IDictionary<string, object> userData;

			[Address(RVA="0x14ED7BC", Offset="0x14ED7BC", VA="0x14ED7BC")]
			public <>c__DisplayClass6_0()
			{
			}

			[Address(RVA="0x14F0660", Offset="0x14F0660", VA="0x14F0660")]
			internal void <LogInAppPurchaseInUsd>b__0()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E3C8", Offset="0x104E3C8")]
		private sealed class <>c__DisplayClass7_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidGluAnalytics <>4__this;

			[FieldOffset(Offset="0x18")]
			public string stepName;

			[FieldOffset(Offset="0x20")]
			public long? stepNumber;

			[FieldOffset(Offset="0x30")]
			public string tutorialId;

			[FieldOffset(Offset="0x38")]
			public long? secondsInGame;

			[FieldOffset(Offset="0x48")]
			public IDictionary<string, object> userData;

			[Address(RVA="0x14ED910", Offset="0x14ED910", VA="0x14ED910")]
			public <>c__DisplayClass7_0()
			{
			}

			[Address(RVA="0x14F0B24", Offset="0x14F0B24", VA="0x14F0B24")]
			internal void <LogTutorialStepCompleted>b__0()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E3D8", Offset="0x104E3D8")]
		private sealed class <>c__DisplayClass8_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidGluAnalytics <>4__this;

			[FieldOffset(Offset="0x18")]
			public string missionId;

			[FieldOffset(Offset="0x20")]
			public string missionType;

			[FieldOffset(Offset="0x28")]
			public string missionTier;

			[FieldOffset(Offset="0x30")]
			public long? hcBalance;

			[FieldOffset(Offset="0x40")]
			public long? scBalance;

			[FieldOffset(Offset="0x50")]
			public long? secondsInGame;

			[FieldOffset(Offset="0x60")]
			public IDictionary<string, object> userData;

			[Address(RVA="0x14EDABC", Offset="0x14EDABC", VA="0x14EDABC")]
			public <>c__DisplayClass8_0()
			{
			}

			[Address(RVA="0x14F0E30", Offset="0x14F0E30", VA="0x14F0E30")]
			internal void <LogMissionStarted>b__0()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E3E8", Offset="0x104E3E8")]
		private sealed class <>c__DisplayClass9_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidGluAnalytics <>4__this;

			[FieldOffset(Offset="0x18")]
			public string failureReason;

			[FieldOffset(Offset="0x20")]
			public string missionId;

			[FieldOffset(Offset="0x28")]
			public string missionType;

			[FieldOffset(Offset="0x30")]
			public string missionTier;

			[FieldOffset(Offset="0x38")]
			public long? hcBalance;

			[FieldOffset(Offset="0x48")]
			public long? scBalance;

			[FieldOffset(Offset="0x58")]
			public long? secondsInGame;

			[FieldOffset(Offset="0x68")]
			public IDictionary<string, object> userData;

			[Address(RVA="0x14EDC88", Offset="0x14EDC88", VA="0x14EDC88")]
			public <>c__DisplayClass9_0()
			{
			}

			[Address(RVA="0x14F1204", Offset="0x14F1204", VA="0x14F1204")]
			internal void <LogMissionFailed>b__0()
			{
			}
		}
	}
}