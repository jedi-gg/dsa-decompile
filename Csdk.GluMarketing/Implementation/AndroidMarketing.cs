using Csdk.GluMarketing;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Csdk.GluMarketing.Implementation
{
	public class AndroidMarketing : MonoBehaviour, IMarketing, IDisposable
	{
		[FieldOffset(Offset="0x18")]
		private AndroidJavaObject javaMarketing;

		[FieldOffset(Offset="0x20")]
		private AndroidJavaClass javaUtil;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060CB4", Offset="0x1060CB4")]
		[FieldOffset(Offset="0x28")]
		private Action<DynamicLinkEvent> DynamicLinkEventReceived;

		[Address(RVA="0x21ED4C4", Offset="0x21ED4C4", VA="0x21ED4C4")]
		public AndroidMarketing()
		{
		}

		[Address(RVA="0x21ED308", Offset="0x21ED308", VA="0x21ED308")]
		private void AndroidMarketingOnDynamicLinkEvent(string message)
		{
		}

		[Address(RVA="0x21EBE90", Offset="0x21EBE90", VA="0x21EBE90", Slot="18")]
		public void Dispose()
		{
		}

		[Address(RVA="0x21EB980", Offset="0x21EB980", VA="0x21EB980")]
		public void Initialize(string jsonConfig, IDictionary<string, object> runtimeConfig)
		{
		}

		[Address(RVA="0x21EBEF8", Offset="0x21EBEF8", VA="0x21EBEF8", Slot="6")]
		public void LogEvent(string eventName, IDictionary<string, object> extra)
		{
		}

		[Address(RVA="0x21EC0A8", Offset="0x21EC0A8", VA="0x21EC0A8", Slot="7")]
		public void LogInAppPurchaseInUsd(string productId, decimal price, IDictionary<string, object> extra)
		{
		}

		[Address(RVA="0x21ED428", Offset="0x21ED428", VA="0x21ED428")]
		private void OnApplicationPause(bool paused)
		{
		}

		[Address(RVA="0x21ED38C", Offset="0x21ED38C", VA="0x21ED38C")]
		private void OnDestroy()
		{
		}

		[Address(RVA="0x21EC308", Offset="0x21EC308", VA="0x21EC308", Slot="8")]
		public void SetAlias(string name, string value)
		{
		}

		[Address(RVA="0x21EC4AC", Offset="0x21EC4AC", VA="0x21EC4AC", Slot="9")]
		public void SetEmail(string email)
		{
		}

		[Address(RVA="0x21EC5F0", Offset="0x21EC5F0", VA="0x21EC5F0", Slot="10")]
		public void SetSubscriptionStatus(string channel, string status)
		{
		}

		[Address(RVA="0x21EC794", Offset="0x21EC794", VA="0x21EC794", Slot="11")]
		public void SetUserAttribute(string key, bool value)
		{
		}

		[Address(RVA="0x21EC950", Offset="0x21EC950", VA="0x21EC950", Slot="12")]
		public void SetUserAttribute(string key, double value)
		{
		}

		[Address(RVA="0x21ECB08", Offset="0x21ECB08", VA="0x21ECB08", Slot="13")]
		public void SetUserAttribute(string key, long value)
		{
		}

		[Address(RVA="0x21ECCC0", Offset="0x21ECCC0", VA="0x21ECCC0", Slot="14")]
		public void SetUserAttribute(string key, string value)
		{
		}

		[Address(RVA="0x21ECE64", Offset="0x21ECE64", VA="0x21ECE64", Slot="15")]
		public void SetUserAttribute(string key, IList<string> value)
		{
		}

		[Address(RVA="0x21ED014", Offset="0x21ED014", VA="0x21ED014", Slot="16")]
		public void SetUserID(string userID)
		{
		}

		[Address(RVA="0x21ED158", Offset="0x21ED158", VA="0x21ED158", Slot="17")]
		public void SetUserSocialData(IDictionary<string, object> userSocialData, string socialNetwork)
		{
		}

		public event Action<DynamicLinkEvent> DynamicLinkEventReceived
		{
			[Address(RVA="0x21EBCB8", Offset="0x21EBCB8", VA="0x21EBCB8", Slot="4")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10745B0", Offset="0x10745B0")]
			add
			{
			}
			[Address(RVA="0x21EBDA4", Offset="0x21EBDA4", VA="0x21EBDA4", Slot="5")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10745C0", Offset="0x10745C0")]
			remove
			{
			}
		}
	}
}