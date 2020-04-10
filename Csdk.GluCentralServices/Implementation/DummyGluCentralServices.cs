using Csdk.GluCentralServices;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Csdk.GluCentralServices.Implementation
{
	public class DummyGluCentralServices : IGluCentralServices, IDisposable, ICIDS, IProfileService, ITags, IConsent
	{
		public ICIDS CIDS
		{
			[Address(RVA="0x155CCB8", Offset="0x155CCB8", VA="0x155CCB8", Slot="4")]
			get
			{
				return null;
			}
		}

		public IConsent Consent
		{
			[Address(RVA="0x155CCC4", Offset="0x155CCC4", VA="0x155CCC4", Slot="7")]
			get
			{
				return null;
			}
		}

		public IProfileService ProfileService
		{
			[Address(RVA="0x155CCBC", Offset="0x155CCBC", VA="0x155CCBC", Slot="5")]
			get
			{
				return null;
			}
		}

		public ITags Tags
		{
			[Address(RVA="0x155CCC0", Offset="0x155CCC0", VA="0x155CCC0", Slot="6")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x155CC04", Offset="0x155CC04", VA="0x155CC04")]
		public DummyGluCentralServices()
		{
		}

		[Address(RVA="0x155CD28", Offset="0x155CD28", VA="0x155CD28", Slot="14")]
		public void AddIdentity(string idKey, string idValue)
		{
		}

		[Address(RVA="0x155CCC8", Offset="0x155CCC8", VA="0x155CCC8", Slot="13")]
		public void Dispose()
		{
		}

		[Address(RVA="0x155CCD0", Offset="0x155CCD0", VA="0x155CCD0", Slot="9")]
		public int GetDeviceTier()
		{
			return new int();
		}

		[Address(RVA="0x155CCD8", Offset="0x155CCD8", VA="0x155CCD8", Slot="10")]
		public string GetIdentityPin()
		{
			return null;
		}

		[Address(RVA="0x155CDC0", Offset="0x155CDC0", VA="0x155CDC0", Slot="17")]
		public void GetTag(string tagName, string currentTag, TagCallback tagCallback, PayloadCallback payloadCallback)
		{
		}

		[Address(RVA="0x155CD24", Offset="0x155CD24", VA="0x155CD24", Slot="12")]
		public void RegisterCustomActionHandler(string action, CustomActionHandler h)
		{
		}

		[Address(RVA="0x155CCCC", Offset="0x155CCCC", VA="0x155CCCC", Slot="8")]
		public void SetUserID(string userID)
		{
		}

		[Address(RVA="0x155CD2C", Offset="0x155CD2C", VA="0x155CD2C", Slot="15")]
		public void SetValue(string name, object val, string op)
		{
		}

		[Address(RVA="0x155CDB8", Offset="0x155CDB8", VA="0x155CDB8", Slot="22")]
		public void Show(string placement)
		{
		}

		[Address(RVA="0x155CDBC", Offset="0x155CDBC", VA="0x155CDBC", Slot="23")]
		public void Show(string placement, IDictionary<string, string> overrideText)
		{
		}

		[Address(RVA="0x155CD20", Offset="0x155CD20", VA="0x155CD20", Slot="11")]
		public void TriggerEvent(string evt)
		{
		}

		[Address(RVA="0x155CD30", Offset="0x155CD30", VA="0x155CD30", Slot="16")]
		public void UpdateValue(UpdateValueInput val)
		{
		}

		public event Action<ConsentUpdateResult> ConsentUpdateReceived
		{
			[Address(RVA="0x155CCB0", Offset="0x155CCB0", VA="0x155CCB0", Slot="20")]
			add
			{
			}
			[Address(RVA="0x155CCB4", Offset="0x155CCB4", VA="0x155CCB4", Slot="21")]
			remove
			{
			}
		}

		public event Action<ShowConsentResult> ShowConsentReceived
		{
			[Address(RVA="0x155CCA8", Offset="0x155CCA8", VA="0x155CCA8", Slot="18")]
			add
			{
			}
			[Address(RVA="0x155CCAC", Offset="0x155CCAC", VA="0x155CCAC", Slot="19")]
			remove
			{
			}
		}
	}
}