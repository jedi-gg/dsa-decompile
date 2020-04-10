using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Csdk.GluMarketing
{
	public interface IMarketing : IDisposable
	{
		void LogEvent(string eventName, IDictionary<string, object> extra);

		void LogInAppPurchaseInUsd(string productId, decimal price, IDictionary<string, object> extra);

		void SetAlias(string name, string value);

		void SetEmail(string email);

		void SetSubscriptionStatus(string channel, string status);

		void SetUserAttribute(string key, bool value);

		void SetUserAttribute(string key, double value);

		void SetUserAttribute(string key, long value);

		void SetUserAttribute(string key, string value);

		void SetUserAttribute(string key, IList<string> value);

		void SetUserID(string userID);

		void SetUserSocialData(IDictionary<string, object> userSocialData, string socialNetwork);

		event Action<DynamicLinkEvent> DynamicLinkEventReceived;
	}
}