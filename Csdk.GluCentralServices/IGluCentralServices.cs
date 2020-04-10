using System;

namespace Csdk.GluCentralServices
{
	public interface IGluCentralServices : IDisposable
	{
		ICIDS CIDS
		{
			get;
		}

		IConsent Consent
		{
			get;
		}

		IProfileService ProfileService
		{
			get;
		}

		ITags Tags
		{
			get;
		}

		int GetDeviceTier();

		string GetIdentityPin();

		void RegisterCustomActionHandler(string action, CustomActionHandler h);

		void SetUserID(string userID);

		void TriggerEvent(string evt);
	}
}