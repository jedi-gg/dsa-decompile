using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Csdk.GluIAP
{
	public interface IInAppPurchase : IDisposable
	{
		void ConsumePurchase(string consumeID, decimal priceInUSD, IDictionary<string, object> extra);

		void QueryProducts(IList<string> productIds);

		void QuerySubscriptionAwards();

		void QuerySubscriptions();

		void RequestPurchase(string productId);

		void RestorePurchases();

		void SetUserID(string userID);

		event Action<PurchaseEvent> PurchaseEventReceived;

		event Action<QueryEvent> QueryEventReceived;

		event Action<QuerySubscriptionAwardsEvent> QuerySubscriptionAwardsEventReceived;

		event Action<QuerySubscriptionsEvent> QuerySubscriptionsEventReceived;
	}
}