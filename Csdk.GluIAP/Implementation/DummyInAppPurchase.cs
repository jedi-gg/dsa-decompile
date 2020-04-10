using Csdk.GluIAP;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Csdk.GluIAP.Implementation
{
	public class DummyInAppPurchase : IInAppPurchase, IDisposable
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060D14", Offset="0x1060D14")]
		[FieldOffset(Offset="0x10")]
		private Action<PurchaseEvent> PurchaseEventReceived;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060D24", Offset="0x1060D24")]
		[FieldOffset(Offset="0x18")]
		private Action<QueryEvent> QueryEventReceived;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060D34", Offset="0x1060D34")]
		[FieldOffset(Offset="0x20")]
		private Action<QuerySubscriptionsEvent> QuerySubscriptionsEventReceived;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060D44", Offset="0x1060D44")]
		[FieldOffset(Offset="0x28")]
		private Action<QuerySubscriptionAwardsEvent> QuerySubscriptionAwardsEventReceived;

		[Address(RVA="0x21DFCF4", Offset="0x21DFCF4", VA="0x21DFCF4")]
		public DummyInAppPurchase()
		{
		}

		[Address(RVA="0x21E31A4", Offset="0x21E31A4", VA="0x21E31A4", Slot="16")]
		public void ConsumePurchase(string consumeID, decimal priceInUSD, IDictionary<string, object> extra)
		{
		}

		[Address(RVA="0x21E3188", Offset="0x21E3188", VA="0x21E3188", Slot="19")]
		public void Dispose()
		{
		}

		[Address(RVA="0x21E31B0", Offset="0x21E31B0", VA="0x21E31B0")]
		public string internal_getConsumeRequestBody(string consumeID, string productID)
		{
			return null;
		}

		[Address(RVA="0x21E319C", Offset="0x21E319C", VA="0x21E319C", Slot="14")]
		public void QueryProducts(IList<string> productIds)
		{
		}

		[Address(RVA="0x21E31AC", Offset="0x21E31AC", VA="0x21E31AC", Slot="18")]
		public void QuerySubscriptionAwards()
		{
		}

		[Address(RVA="0x21E31A8", Offset="0x21E31A8", VA="0x21E31A8", Slot="17")]
		public void QuerySubscriptions()
		{
		}

		[Address(RVA="0x21E31A0", Offset="0x21E31A0", VA="0x21E31A0", Slot="15")]
		public void RequestPurchase(string productId)
		{
		}

		[Address(RVA="0x21E3198", Offset="0x21E3198", VA="0x21E3198", Slot="13")]
		public void RestorePurchases()
		{
		}

		[Address(RVA="0x21E3194", Offset="0x21E3194", VA="0x21E3194", Slot="12")]
		public void SetUserID(string userID)
		{
		}

		public event Action<PurchaseEvent> PurchaseEventReceived
		{
			[Address(RVA="0x21E2A28", Offset="0x21E2A28", VA="0x21E2A28", Slot="4")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x107484C", Offset="0x107484C")]
			add
			{
			}
			[Address(RVA="0x21E2B14", Offset="0x21E2B14", VA="0x21E2B14", Slot="5")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x107485C", Offset="0x107485C")]
			remove
			{
			}
		}

		public event Action<QueryEvent> QueryEventReceived
		{
			[Address(RVA="0x21E2C00", Offset="0x21E2C00", VA="0x21E2C00", Slot="6")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x107486C", Offset="0x107486C")]
			add
			{
			}
			[Address(RVA="0x21E2CEC", Offset="0x21E2CEC", VA="0x21E2CEC", Slot="7")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x107487C", Offset="0x107487C")]
			remove
			{
			}
		}

		public event Action<QuerySubscriptionAwardsEvent> QuerySubscriptionAwardsEventReceived
		{
			[Address(RVA="0x21E2FB0", Offset="0x21E2FB0", VA="0x21E2FB0", Slot="10")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10748AC", Offset="0x10748AC")]
			add
			{
			}
			[Address(RVA="0x21E309C", Offset="0x21E309C", VA="0x21E309C", Slot="11")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10748BC", Offset="0x10748BC")]
			remove
			{
			}
		}

		public event Action<QuerySubscriptionsEvent> QuerySubscriptionsEventReceived
		{
			[Address(RVA="0x21E2DD8", Offset="0x21E2DD8", VA="0x21E2DD8", Slot="8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x107488C", Offset="0x107488C")]
			add
			{
			}
			[Address(RVA="0x21E2EC4", Offset="0x21E2EC4", VA="0x21E2EC4", Slot="9")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x107489C", Offset="0x107489C")]
			remove
			{
			}
		}
	}
}