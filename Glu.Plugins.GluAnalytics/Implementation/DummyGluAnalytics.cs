using Glu.Plugins.GluAnalytics;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glu.Plugins.GluAnalytics.Implementation
{
	public class DummyGluAnalytics : MonoBehaviour, IGluAnalytics, IDisposable
	{
		[Address(RVA="0x14F16A4", Offset="0x14F16A4", VA="0x14F16A4")]
		public DummyGluAnalytics()
		{
		}

		[Address(RVA="0x14F1630", Offset="0x14F1630", VA="0x14F1630", Slot="22")]
		public void Dispose()
		{
		}

		[Address(RVA="0x14F1674", Offset="0x14F1674", VA="0x14F1674", Slot="15")]
		public string GetAnalyticsApplicationName()
		{
			return null;
		}

		[Address(RVA="0x14F166C", Offset="0x14F166C", VA="0x14F166C", Slot="14")]
		public string GetAnalyticsDeviceIdentifier()
		{
			return null;
		}

		[Address(RVA="0x14F167C", Offset="0x14F167C", VA="0x14F167C", Slot="16")]
		public string GetAnalyticsEnvironment()
		{
			return null;
		}

		[Address(RVA="0x14F1694", Offset="0x14F1694", VA="0x14F1694", Slot="19")]
		public GeoLocation GetGeoLocation()
		{
			return null;
		}

		[Address(RVA="0x14F1684", Offset="0x14F1684", VA="0x14F1684", Slot="17")]
		public string GetRevenueIdentifier()
		{
			return null;
		}

		[Address(RVA="0x14F168C", Offset="0x14F168C", VA="0x14F168C", Slot="18")]
		public string GetSessionIdentifier()
		{
			return null;
		}

		[Address(RVA="0x14ED2F8", Offset="0x14ED2F8", VA="0x14ED2F8")]
		public void Initialize()
		{
		}

		[Address(RVA="0x14F165C", Offset="0x14F165C", VA="0x14F165C")]
		public void LogAdvertisementClicked(string placement, string network, string adType, IDictionary<string, object> userData)
		{
		}

		[Address(RVA="0x14F1660", Offset="0x14F1660", VA="0x14F1660")]
		public void LogAdvertisementDismissed(string placement, string network, string adType, IDictionary<string, object> userData)
		{
		}

		[Address(RVA="0x14F1654", Offset="0x14F1654", VA="0x14F1654")]
		public void LogAdvertisementLoaded(string placement, string network, bool success, string adType, IDictionary<string, object> userData)
		{
		}

		[Address(RVA="0x14F1664", Offset="0x14F1664", VA="0x14F1664", Slot="12")]
		public void LogAdvertisementOpportunity(string placement, string rewardItem, long rewardAmount, bool missed, IDictionary<string, object> userData)
		{
		}

		[Address(RVA="0x14F1658", Offset="0x14F1658", VA="0x14F1658")]
		public void LogAdvertisementShown(string placement, string network, string adType, IDictionary<string, object> userData)
		{
		}

		[Address(RVA="0x14F164C", Offset="0x14F164C", VA="0x14F164C", Slot="10")]
		public void LogCurrencySink(long amount, string currencyName, string item, string itemCategory, string missionId, string missionType, string missionTier, long? hcBalance, long? scBalance, long? secondsInGame, IDictionary<string, object> userData)
		{
		}

		[Address(RVA="0x14F1650", Offset="0x14F1650", VA="0x14F1650", Slot="11")]
		public void LogCurrencySource(long amount, string currencyName, string source, string sourceType, string missionId, string missionType, string missionTier, long? hcBalance, long? scBalance, long? secondsInGame, IDictionary<string, object> userData)
		{
		}

		[Address(RVA="0x14F1634", Offset="0x14F1634", VA="0x14F1634", Slot="4")]
		public void LogEvent(string name, string st1, string st2, string st3, long? val, long? level, IDictionary<string, object> data)
		{
		}

		[Address(RVA="0x14F1638", Offset="0x14F1638", VA="0x14F1638", Slot="5")]
		public void LogInAppPurchaseInUsd(decimal price, string sku, string missionId, string missionType, string missionTier, long? hcBalance, long? scBalance, long? secondsInGame, IDictionary<string, object> userData)
		{
		}

		[Address(RVA="0x14F1648", Offset="0x14F1648", VA="0x14F1648", Slot="9")]
		public void LogMissionCompleted(string missionId, string missionType, string missionTier, long? hcBalance, long? scBalance, long? secondsInGame, IDictionary<string, object> userData)
		{
		}

		[Address(RVA="0x14F1644", Offset="0x14F1644", VA="0x14F1644", Slot="8")]
		public void LogMissionFailed(string failureReason, string missionId, string missionType, string missionTier, long? hcBalance, long? scBalance, long? secondsInGame, IDictionary<string, object> userData)
		{
		}

		[Address(RVA="0x14F1640", Offset="0x14F1640", VA="0x14F1640", Slot="7")]
		public void LogMissionStarted(string missionId, string missionType, string missionTier, long? hcBalance, long? scBalance, long? secondsInGame, IDictionary<string, object> userData)
		{
		}

		[Address(RVA="0x14F163C", Offset="0x14F163C", VA="0x14F163C", Slot="6")]
		public void LogTutorialStepCompleted(string stepName, long? stepNumber, string tutorialId, long? secondsInGame, IDictionary<string, object> userData)
		{
		}

		[Address(RVA="0x14F16A0", Offset="0x14F16A0", VA="0x14F16A0", Slot="21")]
		public void PerfSampleEnd(string placement)
		{
		}

		[Address(RVA="0x14F169C", Offset="0x14F169C", VA="0x14F169C", Slot="20")]
		public void PerfSampleStart(string placement, PerfType type, IDictionary<string, object> extraData)
		{
		}

		[Address(RVA="0x14F1668", Offset="0x14F1668", VA="0x14F1668", Slot="13")]
		public void SetUserIdentifier(string userId)
		{
		}
	}
}