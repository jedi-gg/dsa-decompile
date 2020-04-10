using Csdk.GluIAP;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Csdk.GluIAP.Implementation
{
	public class AndroidInAppPurchase : MonoBehaviour, IInAppPurchase, IDisposable
	{
		[FieldOffset(Offset="0x18")]
		private AndroidJavaObject javaInAppPurchase;

		[FieldOffset(Offset="0x20")]
		private AndroidJavaClass javaUtil;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060CD4", Offset="0x1060CD4")]
		[FieldOffset(Offset="0x28")]
		private Action<PurchaseEvent> PurchaseEventReceived;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060CE4", Offset="0x1060CE4")]
		[FieldOffset(Offset="0x30")]
		private Action<QueryEvent> QueryEventReceived;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060CF4", Offset="0x1060CF4")]
		[FieldOffset(Offset="0x38")]
		private Action<QuerySubscriptionsEvent> QuerySubscriptionsEventReceived;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060D04", Offset="0x1060D04")]
		[FieldOffset(Offset="0x40")]
		private Action<QuerySubscriptionAwardsEvent> QuerySubscriptionAwardsEventReceived;

		[Address(RVA="0x21E2A20", Offset="0x21E2A20", VA="0x21E2A20")]
		public AndroidInAppPurchase()
		{
		}

		[Address(RVA="0x21E1484", Offset="0x21E1484", VA="0x21E1484")]
		private void AndroidInAppPurchaseOnPurchaseEvent(string message)
		{
		}

		[Address(RVA="0x21E1758", Offset="0x21E1758", VA="0x21E1758")]
		private void AndroidInAppPurchaseOnQueryEvent(string message)
		{
		}

		[Address(RVA="0x21E22E0", Offset="0x21E22E0", VA="0x21E22E0")]
		private void AndroidInAppPurchaseOnQuerySubscriptionAwardsEvent(string message)
		{
		}

		[Address(RVA="0x21E1D6C", Offset="0x21E1D6C", VA="0x21E1D6C")]
		private void AndroidInAppPurchaseOnQuerySubscriptionsEvent(string message)
		{
		}

		[Address(RVA="0x21E0ED4", Offset="0x21E0ED4", VA="0x21E0ED4", Slot="16")]
		public void ConsumePurchase(string consumeID, decimal priceInUSD, IDictionary<string, object> extra)
		{
		}

		[Address(RVA="0x21E0978", Offset="0x21E0978", VA="0x21E0978", Slot="19")]
		public void Dispose()
		{
		}

		[Address(RVA="0x21DFD8C", Offset="0x21DFD8C", VA="0x21DFD8C")]
		public void Initialize(string jsonConfig, IDictionary<string, object> runtimeConfig)
		{
		}

		[Address(RVA="0x21E12FC", Offset="0x21E12FC", VA="0x21E12FC")]
		public string internal_getConsumeRequestBody(string consumeID, string productID)
		{
			return null;
		}

		[Address(RVA="0x21E297C", Offset="0x21E297C", VA="0x21E297C")]
		private void OnDestroy()
		{
		}

		[Address(RVA="0x21E0C04", Offset="0x21E0C04", VA="0x21E0C04", Slot="14")]
		public void QueryProducts(IList<string> productIds)
		{
		}

		[Address(RVA="0x21E121C", Offset="0x21E121C", VA="0x21E121C", Slot="18")]
		public void QuerySubscriptionAwards()
		{
		}

		[Address(RVA="0x21E113C", Offset="0x21E113C", VA="0x21E113C", Slot="17")]
		public void QuerySubscriptions()
		{
		}

		[Address(RVA="0x21E0D90", Offset="0x21E0D90", VA="0x21E0D90", Slot="15")]
		public void RequestPurchase(string productId)
		{
		}

		[Address(RVA="0x21E0B24", Offset="0x21E0B24", VA="0x21E0B24", Slot="13")]
		public void RestorePurchases()
		{
		}

		[Address(RVA="0x21E09E0", Offset="0x21E09E0", VA="0x21E09E0", Slot="12")]
		public void SetUserID(string userID)
		{
		}

		public event Action<PurchaseEvent> PurchaseEventReceived
		{
			[Address(RVA="0x21E020C", Offset="0x21E020C", VA="0x21E020C", Slot="4")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10747CC", Offset="0x10747CC")]
			add
			{
			}
			[Address(RVA="0x21E02F8", Offset="0x21E02F8", VA="0x21E02F8", Slot="5")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10747DC", Offset="0x10747DC")]
			remove
			{
			}
		}

		public event Action<QueryEvent> QueryEventReceived
		{
			[Address(RVA="0x21E03E4", Offset="0x21E03E4", VA="0x21E03E4", Slot="6")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10747EC", Offset="0x10747EC")]
			add
			{
			}
			[Address(RVA="0x21E04D0", Offset="0x21E04D0", VA="0x21E04D0", Slot="7")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10747FC", Offset="0x10747FC")]
			remove
			{
			}
		}

		public event Action<QuerySubscriptionAwardsEvent> QuerySubscriptionAwardsEventReceived
		{
			[Address(RVA="0x21E0794", Offset="0x21E0794", VA="0x21E0794", Slot="10")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x107482C", Offset="0x107482C")]
			add
			{
			}
			[Address(RVA="0x21E0880", Offset="0x21E0880", VA="0x21E0880", Slot="11")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x107483C", Offset="0x107483C")]
			remove
			{
			}
		}

		public event Action<QuerySubscriptionsEvent> QuerySubscriptionsEventReceived
		{
			[Address(RVA="0x21E05BC", Offset="0x21E05BC", VA="0x21E05BC", Slot="8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x107480C", Offset="0x107480C")]
			add
			{
			}
			[Address(RVA="0x21E06A8", Offset="0x21E06A8", VA="0x21E06A8", Slot="9")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x107481C", Offset="0x107481C")]
			remove
			{
			}
		}
	}
}