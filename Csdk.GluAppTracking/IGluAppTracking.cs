using System;
using System.Collections.Generic;

namespace Csdk.GluAppTracking
{
	public interface IGluAppTracking : IDisposable
	{
		void LogEvent(string eventName);

		void LogEvent(string eventName, IDictionary<string, object> extra);

		void SetPushToken(string pushNotificationsToken);

		void TrackRevenueInUsd(decimal price);
	}
}