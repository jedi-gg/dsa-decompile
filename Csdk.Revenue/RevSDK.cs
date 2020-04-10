using Csdk.GluAds;
using Csdk.GluAppTracking;
using Csdk.GluCentralServices;
using Csdk.GluIAP;
using Csdk.GluMarketing;
using Glu.Plugins.GluAnalytics;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Csdk.Revenue
{
	public class RevSDK : MonoBehaviour, IDisposable
	{
		[FieldOffset(Offset="0x0")]
		private static RevSDK sInstance;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060C54", Offset="0x1060C54")]
		[FieldOffset(Offset="0x18")]
		private IAdvertising <GluAds>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060C64", Offset="0x1060C64")]
		[FieldOffset(Offset="0x20")]
		private IGluAnalytics <GluAnalytics>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060C74", Offset="0x1060C74")]
		[FieldOffset(Offset="0x28")]
		private IGluAppTracking <GluAppTracking>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060C84", Offset="0x1060C84")]
		[FieldOffset(Offset="0x30")]
		private IGluCentralServices <GluCentralServices>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060C94", Offset="0x1060C94")]
		[FieldOffset(Offset="0x38")]
		private IInAppPurchase <GluIAP>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060CA4", Offset="0x1060CA4")]
		[FieldOffset(Offset="0x40")]
		private IMarketing <GluMarketing>k__BackingField;

		public IAdvertising GluAds
		{
			[Address(RVA="0x153A8B8", Offset="0x153A8B8", VA="0x153A8B8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10744D0", Offset="0x10744D0")]
			get
			{
				return null;
			}
			[Address(RVA="0x153A8C0", Offset="0x153A8C0", VA="0x153A8C0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10744E0", Offset="0x10744E0")]
			private set
			{
			}
		}

		public IGluAnalytics GluAnalytics
		{
			[Address(RVA="0x153A8C8", Offset="0x153A8C8", VA="0x153A8C8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10744F0", Offset="0x10744F0")]
			get
			{
				return null;
			}
			[Address(RVA="0x153A8D0", Offset="0x153A8D0", VA="0x153A8D0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1074500", Offset="0x1074500")]
			private set
			{
			}
		}

		public IGluAppTracking GluAppTracking
		{
			[Address(RVA="0x153A8D8", Offset="0x153A8D8", VA="0x153A8D8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1074510", Offset="0x1074510")]
			get
			{
				return null;
			}
			[Address(RVA="0x153A8E0", Offset="0x153A8E0", VA="0x153A8E0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1074520", Offset="0x1074520")]
			private set
			{
			}
		}

		public IGluCentralServices GluCentralServices
		{
			[Address(RVA="0x153A8E8", Offset="0x153A8E8", VA="0x153A8E8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1074530", Offset="0x1074530")]
			get
			{
				return null;
			}
			[Address(RVA="0x153A8F0", Offset="0x153A8F0", VA="0x153A8F0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1074540", Offset="0x1074540")]
			private set
			{
			}
		}

		public IInAppPurchase GluIAP
		{
			[Address(RVA="0x153A8F8", Offset="0x153A8F8", VA="0x153A8F8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1074550", Offset="0x1074550")]
			get
			{
				return null;
			}
			[Address(RVA="0x153A900", Offset="0x153A900", VA="0x153A900")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1074560", Offset="0x1074560")]
			private set
			{
			}
		}

		public IMarketing GluMarketing
		{
			[Address(RVA="0x153A908", Offset="0x153A908", VA="0x153A908")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1074570", Offset="0x1074570")]
			get
			{
				return null;
			}
			[Address(RVA="0x153A910", Offset="0x153A910", VA="0x153A910")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1074580", Offset="0x1074580")]
			private set
			{
			}
		}

		public static RevSDK Instance
		{
			[Address(RVA="0x153A758", Offset="0x153A758", VA="0x153A758")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x153B3C0", Offset="0x153B3C0", VA="0x153B3C0")]
		public RevSDK()
		{
		}

		[Address(RVA="0x153B038", Offset="0x153B038", VA="0x153B038", Slot="4")]
		public void Dispose()
		{
		}

		[Address(RVA="0x153A918", Offset="0x153A918", VA="0x153A918")]
		public void Initialize(IDictionary<RevSDKComponent, string> jsonConfigs, IDictionary<string, object> runtimeConfig)
		{
		}

		[Address(RVA="0x153B0C8", Offset="0x153B0C8", VA="0x153B0C8")]
		private void OnDestroy()
		{
		}

		[Address(RVA="0x153AE78", Offset="0x153AE78", VA="0x153AE78")]
		public void SetUserID(string userID)
		{
		}
	}
}