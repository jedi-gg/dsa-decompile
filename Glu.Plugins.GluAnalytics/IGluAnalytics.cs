using System;
using System.Collections.Generic;

namespace Glu.Plugins.GluAnalytics
{
	public interface IGluAnalytics : IDisposable
	{
		string GetAnalyticsApplicationName();

		string GetAnalyticsDeviceIdentifier();

		string GetAnalyticsEnvironment();

		GeoLocation GetGeoLocation();

		string GetRevenueIdentifier();

		string GetSessionIdentifier();

		void LogAdvertisementOpportunity(string placement, string rewardItem, long rewardAmount, bool missed, IDictionary<string, object> userData);

		void LogCurrencySink(long amount, string currencyName, string item, string itemCategory, string missionId, string missionType, string missionTier, long? hcBalance, long? scBalance, long? secondsInGame, IDictionary<string, object> userData);

		void LogCurrencySource(long amount, string currencyName, string source, string sourceType, string missionId, string missionType, string missionTier, long? hcBalance, long? scBalance, long? secondsInGame, IDictionary<string, object> userData);

		void LogEvent(string name, string st1, string st2, string st3, long? val, long? level, IDictionary<string, object> data);

		void LogInAppPurchaseInUsd(decimal price, string sku, string missionId, string missionType, string missionTier, long? hcBalance, long? scBalance, long? secondsInGame, IDictionary<string, object> userData);

		void LogMissionCompleted(string missionId, string missionType, string missionTier, long? hcBalance, long? scBalance, long? secondsInGame, IDictionary<string, object> userData);

		void LogMissionFailed(string failureReason, string missionId, string missionType, string missionTier, long? hcBalance, long? scBalance, long? secondsInGame, IDictionary<string, object> userData);

		void LogMissionStarted(string missionId, string missionType, string missionTier, long? hcBalance, long? scBalance, long? secondsInGame, IDictionary<string, object> userData);

		void LogTutorialStepCompleted(string stepName, long? stepNumber, string tutorialId, long? secondsInGame, IDictionary<string, object> userData);

		void PerfSampleEnd(string placement);

		void PerfSampleStart(string placement, PerfType type, IDictionary<string, object> extraData);

		void SetUserIdentifier(string userId);
	}
}