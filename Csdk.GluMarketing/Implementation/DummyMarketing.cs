using Csdk.GluMarketing;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Csdk.GluMarketing.Implementation
{
	public class DummyMarketing : IMarketing, IDisposable
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060CC4", Offset="0x1060CC4")]
		[FieldOffset(Offset="0x10")]
		private Action<DynamicLinkEvent> DynamicLinkEventReceived;

		[Address(RVA="0x21EB8E8", Offset="0x21EB8E8", VA="0x21EB8E8")]
		public DummyMarketing()
		{
		}

		[Address(RVA="0x21ED6A4", Offset="0x21ED6A4", VA="0x21ED6A4", Slot="18")]
		public void Dispose()
		{
		}

		[Address(RVA="0x21ED6AC", Offset="0x21ED6AC", VA="0x21ED6AC", Slot="6")]
		public void LogEvent(string eventName, IDictionary<string, object> extra)
		{
		}

		[Address(RVA="0x21ED6B0", Offset="0x21ED6B0", VA="0x21ED6B0", Slot="7")]
		public void LogInAppPurchaseInUsd(string productId, decimal price, IDictionary<string, object> extra)
		{
		}

		[Address(RVA="0x21ED6B4", Offset="0x21ED6B4", VA="0x21ED6B4", Slot="8")]
		public void SetAlias(string name, string value)
		{
		}

		[Address(RVA="0x21ED6B8", Offset="0x21ED6B8", VA="0x21ED6B8", Slot="9")]
		public void SetEmail(string email)
		{
		}

		[Address(RVA="0x21ED6BC", Offset="0x21ED6BC", VA="0x21ED6BC", Slot="10")]
		public void SetSubscriptionStatus(string channel, string status)
		{
		}

		[Address(RVA="0x21ED6C0", Offset="0x21ED6C0", VA="0x21ED6C0", Slot="11")]
		public void SetUserAttribute(string key, bool value)
		{
		}

		[Address(RVA="0x21ED6C4", Offset="0x21ED6C4", VA="0x21ED6C4", Slot="12")]
		public void SetUserAttribute(string key, double value)
		{
		}

		[Address(RVA="0x21ED6C8", Offset="0x21ED6C8", VA="0x21ED6C8", Slot="13")]
		public void SetUserAttribute(string key, long value)
		{
		}

		[Address(RVA="0x21ED6CC", Offset="0x21ED6CC", VA="0x21ED6CC", Slot="14")]
		public void SetUserAttribute(string key, string value)
		{
		}

		[Address(RVA="0x21ED6D0", Offset="0x21ED6D0", VA="0x21ED6D0", Slot="15")]
		public void SetUserAttribute(string key, IList<string> value)
		{
		}

		[Address(RVA="0x21ED6D4", Offset="0x21ED6D4", VA="0x21ED6D4", Slot="16")]
		public void SetUserID(string userID)
		{
		}

		[Address(RVA="0x21ED6D8", Offset="0x21ED6D8", VA="0x21ED6D8", Slot="17")]
		public void SetUserSocialData(IDictionary<string, object> userSocialData, string socialNetwork)
		{
		}

		public event Action<DynamicLinkEvent> DynamicLinkEventReceived
		{
			[Address(RVA="0x21ED4CC", Offset="0x21ED4CC", VA="0x21ED4CC", Slot="4")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10745D0", Offset="0x10745D0")]
			add
			{
			}
			[Address(RVA="0x21ED5B8", Offset="0x21ED5B8", VA="0x21ED5B8", Slot="5")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10745E0", Offset="0x10745E0")]
			remove
			{
			}
		}
	}
}