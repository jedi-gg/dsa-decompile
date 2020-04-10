using Csdk.GluAppTracking;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Csdk.GluAppTracking.Implementation
{
	public class AndroidAppTracking : MonoBehaviour, IGluAppTracking, IDisposable
	{
		[FieldOffset(Offset="0x18")]
		private AndroidJavaObject mJavaObject;

		[FieldOffset(Offset="0x20")]
		private AndroidJavaClass javaUtil;

		[Address(RVA="0x1559970", Offset="0x1559970", VA="0x1559970")]
		public AndroidAppTracking()
		{
		}

		[Address(RVA="0x1559704", Offset="0x1559704", VA="0x1559704", Slot="8")]
		public void Dispose()
		{
		}

		[Address(RVA="0x15591A0", Offset="0x15591A0", VA="0x15591A0")]
		public void Init(string jsonConfig)
		{
		}

		[Address(RVA="0x15593E4", Offset="0x15593E4", VA="0x15593E4", Slot="4")]
		public void LogEvent(string eventName)
		{
		}

		[Address(RVA="0x155955C", Offset="0x155955C", VA="0x155955C", Slot="5")]
		public void LogEvent(string eventName, IDictionary<string, object> extra)
		{
		}

		[Address(RVA="0x15598D4", Offset="0x15598D4", VA="0x15598D4")]
		private void OnApplicationPause(bool paused)
		{
		}

		[Address(RVA="0x1559834", Offset="0x1559834", VA="0x1559834")]
		private void OnDestroy()
		{
		}

		[Address(RVA="0x155976C", Offset="0x155976C", VA="0x155976C", Slot="7")]
		public void SetPushToken(string pushNotificationsToken)
		{
		}

		[Address(RVA="0x1559638", Offset="0x1559638", VA="0x1559638", Slot="6")]
		public void TrackRevenueInUsd(decimal price)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E4F8", Offset="0x104E4F8")]
		private sealed class <>c__DisplayClass2_0
		{
			[FieldOffset(Offset="0x10")]
			public string jsonConfig;

			[Address(RVA="0x15593D4", Offset="0x15593D4", VA="0x15593D4")]
			public <>c__DisplayClass2_0()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E508", Offset="0x104E508")]
		private sealed class <>c__DisplayClass2_1
		{
			[FieldOffset(Offset="0x10")]
			public AndroidJavaObject factory;

			[FieldOffset(Offset="0x18")]
			public AndroidAppTracking.<>c__DisplayClass2_0 CS$<>8__locals1;

			[Address(RVA="0x15593DC", Offset="0x15593DC", VA="0x15593DC")]
			public <>c__DisplayClass2_1()
			{
			}

			[Address(RVA="0x1559978", Offset="0x1559978", VA="0x1559978")]
			internal AndroidJavaObject <Init>b__0()
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E518", Offset="0x104E518")]
		private sealed class <>c__DisplayClass3_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidAppTracking <>4__this;

			[FieldOffset(Offset="0x18")]
			public string eventName;

			[Address(RVA="0x15594A4", Offset="0x15594A4", VA="0x15594A4")]
			public <>c__DisplayClass3_0()
			{
			}

			[Address(RVA="0x1559A8C", Offset="0x1559A8C", VA="0x1559A8C")]
			internal void <LogEvent>b__0()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E528", Offset="0x104E528")]
		private sealed class <>c__DisplayClass4_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidAppTracking <>4__this;

			[FieldOffset(Offset="0x18")]
			public string eventName;

			[FieldOffset(Offset="0x20")]
			public IDictionary<string, object> extra;

			[Address(RVA="0x1559630", Offset="0x1559630", VA="0x1559630")]
			public <>c__DisplayClass4_0()
			{
			}

			[Address(RVA="0x1559B94", Offset="0x1559B94", VA="0x1559B94")]
			internal void <LogEvent>b__0()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E538", Offset="0x104E538")]
		private sealed class <>c__DisplayClass5_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidAppTracking <>4__this;

			[FieldOffset(Offset="0x18")]
			public decimal price;

			[Address(RVA="0x15596FC", Offset="0x15596FC", VA="0x15596FC")]
			public <>c__DisplayClass5_0()
			{
			}

			[Address(RVA="0x1559D68", Offset="0x1559D68", VA="0x1559D68")]
			internal void <TrackRevenueInUsd>b__0()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E548", Offset="0x104E548")]
		private sealed class <>c__DisplayClass7_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidAppTracking <>4__this;

			[FieldOffset(Offset="0x18")]
			public string pushNotificationsToken;

			[Address(RVA="0x155982C", Offset="0x155982C", VA="0x155982C")]
			public <>c__DisplayClass7_0()
			{
			}

			[Address(RVA="0x1559EB8", Offset="0x1559EB8", VA="0x1559EB8")]
			internal void <SetPushToken>b__0()
			{
			}
		}
	}
}