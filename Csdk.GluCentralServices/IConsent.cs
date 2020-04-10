using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Csdk.GluCentralServices
{
	public interface IConsent
	{
		void Show(string placement);

		void Show(string placement, IDictionary<string, string> overrideText);

		event Action<ConsentUpdateResult> ConsentUpdateReceived;

		event Action<ShowConsentResult> ShowConsentReceived;
	}
}