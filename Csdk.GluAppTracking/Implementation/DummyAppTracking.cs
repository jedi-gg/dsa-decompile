using Csdk.GluAppTracking;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Csdk.GluAppTracking.Implementation
{
	public class DummyAppTracking : IGluAppTracking, IDisposable
	{
		[Address(RVA="0x1559198", Offset="0x1559198", VA="0x1559198")]
		public DummyAppTracking()
		{
		}

		[Address(RVA="0x1559FCC", Offset="0x1559FCC", VA="0x1559FCC", Slot="8")]
		public void Dispose()
		{
		}

		[Address(RVA="0x1559FC0", Offset="0x1559FC0", VA="0x1559FC0", Slot="4")]
		public void LogEvent(string eventName)
		{
		}

		[Address(RVA="0x1559FC4", Offset="0x1559FC4", VA="0x1559FC4", Slot="5")]
		public void LogEvent(string eventName, IDictionary<string, object> extra)
		{
		}

		[Address(RVA="0x1559FD0", Offset="0x1559FD0", VA="0x1559FD0", Slot="7")]
		public void SetPushToken(string pushNotificationsToken)
		{
		}

		[Address(RVA="0x1559FC8", Offset="0x1559FC8", VA="0x1559FC8", Slot="6")]
		public void TrackRevenueInUsd(decimal price)
		{
		}
	}
}