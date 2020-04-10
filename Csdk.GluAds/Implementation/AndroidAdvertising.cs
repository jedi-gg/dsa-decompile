using Csdk.GluAds;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Csdk.GluAds.Implementation
{
	public class AndroidAdvertising : MonoBehaviour, IAdvertising, IDisposable
	{
		[FieldOffset(Offset="0x18")]
		private AndroidJavaObject javaAdvertising;

		[FieldOffset(Offset="0x20")]
		private AndroidJavaClass javaUtil;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060D74", Offset="0x1060D74")]
		[FieldOffset(Offset="0x28")]
		private Action<CustomAction> CustomActionReceived;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060D84", Offset="0x1060D84")]
		[FieldOffset(Offset="0x30")]
		private Action<PlacementEvent> PlacementEventReceived;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060D94", Offset="0x1060D94")]
		[FieldOffset(Offset="0x38")]
		private Action<Reward> RewardReceived;

		[Address(RVA="0x1550EB0", Offset="0x1550EB0", VA="0x1550EB0")]
		public AndroidAdvertising()
		{
		}

		[Address(RVA="0x1550958", Offset="0x1550958", VA="0x1550958")]
		private void AndroidAdvertisingOnCustomActionReceived(string message)
		{
		}

		[Address(RVA="0x1550AA4", Offset="0x1550AA4", VA="0x1550AA4")]
		private void AndroidAdvertisingOnPlacementEvent(string message)
		{
		}

		[Address(RVA="0x1550CF0", Offset="0x1550CF0", VA="0x1550CF0")]
		private void AndroidAdvertisingOnRewardReceived(string message)
		{
		}

		[Address(RVA="0x1550294", Offset="0x1550294", VA="0x1550294", Slot="16")]
		public void Discard(string advertisementType, string identifier, IDictionary<string, object> extra)
		{
		}

		[Address(RVA="0x154F5F4", Offset="0x154F5F4", VA="0x154F5F4", Slot="19")]
		public void Dispose()
		{
		}

		[Address(RVA="0x1550604", Offset="0x1550604", VA="0x1550604", Slot="18")]
		public Reward GetReward(string advertisementType, string placement)
		{
			return null;
		}

		[Address(RVA="0x154ED20", Offset="0x154ED20", VA="0x154ED20")]
		public void Initialize(string jsonConfig, IDictionary<string, object> runtimeConfig)
		{
		}

		[Address(RVA="0x154F65C", Offset="0x154F65C", VA="0x154F65C", Slot="10")]
		public bool IsLoaded(string advertisementType, string placement, IDictionary<string, object> extra)
		{
			return new bool();
		}

		[Address(RVA="0x154F87C", Offset="0x154F87C", VA="0x154F87C", Slot="11")]
		public void Load(string advertisementType, string placement, IDictionary<string, object> extra)
		{
		}

		[Address(RVA="0x154FEC4", Offset="0x154FEC4", VA="0x154FEC4", Slot="14")]
		public void OnAdvertisementClick(string advertisementType, string identifier, IDictionary<string, object> extra)
		{
		}

		[Address(RVA="0x154FCAC", Offset="0x154FCAC", VA="0x154FCAC", Slot="13")]
		public void OnAdvertisementImpression(string advertisementType, string identifier, IDictionary<string, object> extra)
		{
		}

		[Address(RVA="0x1550E14", Offset="0x1550E14", VA="0x1550E14")]
		private void OnApplicationPause(bool paused)
		{
		}

		[Address(RVA="0x1550D70", Offset="0x1550D70", VA="0x1550D70")]
		private void OnDestroy()
		{
		}

		[Address(RVA="0x15504AC", Offset="0x15504AC", VA="0x15504AC", Slot="17")]
		public void SetCustomProperties(IDictionary<string, object> properties)
		{
		}

		[Address(RVA="0x15500DC", Offset="0x15500DC", VA="0x15500DC", Slot="15")]
		public void SetUserIdentifier(string userIdentifier, IDictionary<string, object> extra)
		{
		}

		[Address(RVA="0x154FA94", Offset="0x154FA94", VA="0x154FA94", Slot="12")]
		public void Show(string advertisementType, string placement, IDictionary<string, object> extra)
		{
		}

		public event Action<CustomAction> CustomActionReceived
		{
			[Address(RVA="0x154F060", Offset="0x154F060", VA="0x154F060", Slot="4")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1074D0C", Offset="0x1074D0C")]
			add
			{
			}
			[Address(RVA="0x154F14C", Offset="0x154F14C", VA="0x154F14C", Slot="5")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1074D1C", Offset="0x1074D1C")]
			remove
			{
			}
		}

		public event Action<PlacementEvent> PlacementEventReceived
		{
			[Address(RVA="0x154F238", Offset="0x154F238", VA="0x154F238", Slot="6")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1074D2C", Offset="0x1074D2C")]
			add
			{
			}
			[Address(RVA="0x154F324", Offset="0x154F324", VA="0x154F324", Slot="7")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1074D3C", Offset="0x1074D3C")]
			remove
			{
			}
		}

		public event Action<Reward> RewardReceived
		{
			[Address(RVA="0x154F410", Offset="0x154F410", VA="0x154F410", Slot="8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1074D4C", Offset="0x1074D4C")]
			add
			{
			}
			[Address(RVA="0x154F4FC", Offset="0x154F4FC", VA="0x154F4FC", Slot="9")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1074D5C", Offset="0x1074D5C")]
			remove
			{
			}
		}
	}
}