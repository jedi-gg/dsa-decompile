using Csdk.GluCentralServices;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Csdk.GluCentralServices.Implementation
{
	public class NativeGluCentralServices : MonoBehaviour, IGluCentralServices, IDisposable, ICIDS, IProfileService, ITags, IConsent
	{
		[FieldOffset(Offset="0x0")]
		private const string DLLImportName = "glucentralservices";

		[FieldOffset(Offset="0x18")]
		private IntPtr nativeService;

		[FieldOffset(Offset="0x20")]
		private IDictionary<string, TagCallback> mTagDelegates;

		[FieldOffset(Offset="0x28")]
		private IDictionary<string, PayloadCallback> mPayloadDelegates;

		[FieldOffset(Offset="0x30")]
		private IDictionary<string, CustomActionHandler> mCustomActionHandlers;

		[FieldOffset(Offset="0x38")]
		private long mIDCounter;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060D54", Offset="0x1060D54")]
		[FieldOffset(Offset="0x40")]
		private Action<ShowConsentResult> ShowConsentReceived;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060D64", Offset="0x1060D64")]
		[FieldOffset(Offset="0x48")]
		private Action<ConsentUpdateResult> ConsentUpdateReceived;

		public ICIDS CIDS
		{
			[Address(RVA="0x21DB938", Offset="0x21DB938", VA="0x21DB938", Slot="4")]
			get
			{
				return null;
			}
		}

		public IConsent Consent
		{
			[Address(RVA="0x21DB944", Offset="0x21DB944", VA="0x21DB944", Slot="7")]
			get
			{
				return null;
			}
		}

		public IProfileService ProfileService
		{
			[Address(RVA="0x21DB93C", Offset="0x21DB93C", VA="0x21DB93C", Slot="5")]
			get
			{
				return null;
			}
		}

		public ITags Tags
		{
			[Address(RVA="0x21DB940", Offset="0x21DB940", VA="0x21DB940", Slot="6")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x21DF63C", Offset="0x21DF63C", VA="0x21DF63C")]
		public NativeGluCentralServices()
		{
		}

		[Address(RVA="0x21DC210", Offset="0x21DC210", VA="0x21DC210", Slot="14")]
		public void AddIdentity(string idKey, string idValue)
		{
		}

		[Address(RVA="0x21DD5F4", Offset="0x21DD5F4", VA="0x21DD5F4")]
		private void Awake()
		{
		}

		[Address(RVA="0x21DBA74", Offset="0x21DBA74", VA="0x21DBA74", Slot="13")]
		public void Dispose()
		{
		}

		[Address(RVA="0x21DBBA4", Offset="0x21DBBA4", VA="0x21DBBA4", Slot="9")]
		public int GetDeviceTier()
		{
			return new int();
		}

		[Address(RVA="0x21DBC48", Offset="0x21DBC48", VA="0x21DBC48", Slot="10")]
		public string GetIdentityPin()
		{
			return null;
		}

		[Address(RVA="0x21DD07C", Offset="0x21DD07C", VA="0x21DD07C", Slot="17")]
		public void GetTag(string tagName, string currentTag, TagCallback tagCallback, PayloadCallback payloadCallback)
		{
		}

		// 
		// Current member / type: System.Void Csdk.GluCentralServices.Implementation.NativeGluCentralServices::GluCentralServices_Consent_show(System.IntPtr,System.String,System.String,System.String)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void GluCentralServices_Consent_show(System.IntPtr,System.String,System.String,System.String)
		// 
		// Object reference not set to an instance of an object.
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\AttributesUtilities.cs:line 312
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 381
		//    at ..(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 330
		//    at ..(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 67
		//    at Telerik.JustDecompiler.Languages.CSharp.CSharpAttributeWriter.(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\CSharp\CSharpAttributeWriter.cs:line 45
		//    at ..(IMemberDefinition , IEnumerable`1 , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 40
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(IMemberDefinition , IEnumerable`1 ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 106
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 438
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		// 
		// Current member / type: System.IntPtr Csdk.GluCentralServices.Implementation.NativeGluCentralServices::GluCentralServices_createCentralServices(System.String,System.String)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.IntPtr GluCentralServices_createCentralServices(System.String,System.String)
		// 
		// Object reference not set to an instance of an object.
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\AttributesUtilities.cs:line 312
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 381
		//    at ..(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 330
		//    at ..(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 67
		//    at Telerik.JustDecompiler.Languages.CSharp.CSharpAttributeWriter.(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\CSharp\CSharpAttributeWriter.cs:line 45
		//    at ..(IMemberDefinition , IEnumerable`1 , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 40
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(IMemberDefinition , IEnumerable`1 ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 106
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 438
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		// 
		// Current member / type: System.Void Csdk.GluCentralServices.Implementation.NativeGluCentralServices::GluCentralServices_destroy(System.IntPtr)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void GluCentralServices_destroy(System.IntPtr)
		// 
		// Object reference not set to an instance of an object.
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\AttributesUtilities.cs:line 312
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 381
		//    at ..(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 330
		//    at ..(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 67
		//    at Telerik.JustDecompiler.Languages.CSharp.CSharpAttributeWriter.(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\CSharp\CSharpAttributeWriter.cs:line 45
		//    at ..(IMemberDefinition , IEnumerable`1 , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 40
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(IMemberDefinition , IEnumerable`1 ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 106
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 438
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		// 
		// Current member / type: System.Int32 Csdk.GluCentralServices.Implementation.NativeGluCentralServices::GluCentralServices_getDeviceTier(System.IntPtr)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Int32 GluCentralServices_getDeviceTier(System.IntPtr)
		// 
		// Object reference not set to an instance of an object.
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\AttributesUtilities.cs:line 312
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 381
		//    at ..(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 330
		//    at ..(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 67
		//    at Telerik.JustDecompiler.Languages.CSharp.CSharpAttributeWriter.(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\CSharp\CSharpAttributeWriter.cs:line 45
		//    at ..(IMemberDefinition , IEnumerable`1 , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 40
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(IMemberDefinition , IEnumerable`1 ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 106
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 438
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		// 
		// Current member / type: System.IntPtr Csdk.GluCentralServices.Implementation.NativeGluCentralServices::GluCentralServices_getIdentityPin(System.IntPtr)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.IntPtr GluCentralServices_getIdentityPin(System.IntPtr)
		// 
		// Object reference not set to an instance of an object.
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\AttributesUtilities.cs:line 312
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 381
		//    at ..(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 330
		//    at ..(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 67
		//    at Telerik.JustDecompiler.Languages.CSharp.CSharpAttributeWriter.(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\CSharp\CSharpAttributeWriter.cs:line 45
		//    at ..(IMemberDefinition , IEnumerable`1 , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 40
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(IMemberDefinition , IEnumerable`1 ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 106
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 438
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		// 
		// Current member / type: System.Void Csdk.GluCentralServices.Implementation.NativeGluCentralServices::GluCentralServices_ProfileService_updateValue(System.IntPtr,System.String,System.String,System.String,System.String,System.String,System.String)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void GluCentralServices_ProfileService_updateValue(System.IntPtr,System.String,System.String,System.String,System.String,System.String,System.String)
		// 
		// Object reference not set to an instance of an object.
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\AttributesUtilities.cs:line 312
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 381
		//    at ..(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 330
		//    at ..(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 67
		//    at Telerik.JustDecompiler.Languages.CSharp.CSharpAttributeWriter.(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\CSharp\CSharpAttributeWriter.cs:line 45
		//    at ..(IMemberDefinition , IEnumerable`1 , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 40
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(IMemberDefinition , IEnumerable`1 ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 106
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 438
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		// 
		// Current member / type: System.Void Csdk.GluCentralServices.Implementation.NativeGluCentralServices::GluCentralServices_registerCustomActionHandler(System.IntPtr,System.String,System.String)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void GluCentralServices_registerCustomActionHandler(System.IntPtr,System.String,System.String)
		// 
		// Object reference not set to an instance of an object.
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\AttributesUtilities.cs:line 312
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 381
		//    at ..(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 330
		//    at ..(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 67
		//    at Telerik.JustDecompiler.Languages.CSharp.CSharpAttributeWriter.(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\CSharp\CSharpAttributeWriter.cs:line 45
		//    at ..(IMemberDefinition , IEnumerable`1 , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 40
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(IMemberDefinition , IEnumerable`1 ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 106
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 438
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		// 
		// Current member / type: System.Void Csdk.GluCentralServices.Implementation.NativeGluCentralServices::GluCentralServices_setUserID(System.IntPtr,System.String)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void GluCentralServices_setUserID(System.IntPtr,System.String)
		// 
		// Object reference not set to an instance of an object.
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\AttributesUtilities.cs:line 312
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 381
		//    at ..(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 330
		//    at ..(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 67
		//    at Telerik.JustDecompiler.Languages.CSharp.CSharpAttributeWriter.(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\CSharp\CSharpAttributeWriter.cs:line 45
		//    at ..(IMemberDefinition , IEnumerable`1 , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 40
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(IMemberDefinition , IEnumerable`1 ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 106
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 438
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		// 
		// Current member / type: System.Void Csdk.GluCentralServices.Implementation.NativeGluCentralServices::GluCentralServices_Tags_getTag(System.IntPtr,System.String,System.String,System.String,System.String)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void GluCentralServices_Tags_getTag(System.IntPtr,System.String,System.String,System.String,System.String)
		// 
		// Object reference not set to an instance of an object.
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\AttributesUtilities.cs:line 312
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 381
		//    at ..(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 330
		//    at ..(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 67
		//    at Telerik.JustDecompiler.Languages.CSharp.CSharpAttributeWriter.(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\CSharp\CSharpAttributeWriter.cs:line 45
		//    at ..(IMemberDefinition , IEnumerable`1 , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 40
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(IMemberDefinition , IEnumerable`1 ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 106
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 438
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		// 
		// Current member / type: System.Void Csdk.GluCentralServices.Implementation.NativeGluCentralServices::GluCentralServices_triggerEvent(System.IntPtr,System.String)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void GluCentralServices_triggerEvent(System.IntPtr,System.String)
		// 
		// Object reference not set to an instance of an object.
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\AttributesUtilities.cs:line 312
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 381
		//    at ..(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 330
		//    at ..(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 67
		//    at Telerik.JustDecompiler.Languages.CSharp.CSharpAttributeWriter.(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\CSharp\CSharpAttributeWriter.cs:line 45
		//    at ..(IMemberDefinition , IEnumerable`1 , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 40
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(IMemberDefinition , IEnumerable`1 ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 106
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 438
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x21DB948", Offset="0x21DB948", VA="0x21DB948")]
		public void Initialize(string jsonConfig, IDictionary<string, object> runtimeConfig)
		{
		}

		[Address(RVA="0x21DB98C", Offset="0x21DB98C", VA="0x21DB98C")]
		private static string JSONArg(object val)
		{
			return null;
		}

		[Address(RVA="0x21DEDFC", Offset="0x21DEDFC", VA="0x21DEDFC")]
		private void OnConsentUpdate(string json)
		{
		}

		[Address(RVA="0x21DF00C", Offset="0x21DF00C", VA="0x21DF00C")]
		private void OnCustomAction(string json)
		{
		}

		[Address(RVA="0x21DD6AC", Offset="0x21DD6AC", VA="0x21DD6AC")]
		private void OnDestroy()
		{
		}

		[Address(RVA="0x21DE1A0", Offset="0x21DE1A0", VA="0x21DE1A0")]
		private void OnPayloadReceived(string json)
		{
		}

		[Address(RVA="0x21DEC14", Offset="0x21DEC14", VA="0x21DEC14")]
		private void OnShowConsent(string json)
		{
		}

		[Address(RVA="0x21DD798", Offset="0x21DD798", VA="0x21DD798")]
		private void OnTagReceived(string json)
		{
		}

		[Address(RVA="0x21DBE24", Offset="0x21DBE24", VA="0x21DBE24", Slot="12")]
		public void RegisterCustomActionHandler(string action, CustomActionHandler h)
		{
		}

		[Address(RVA="0x21DBADC", Offset="0x21DBADC", VA="0x21DBADC", Slot="8")]
		public void SetUserID(string userID)
		{
		}

		[Address(RVA="0x21DC214", Offset="0x21DC214", VA="0x21DC214", Slot="15")]
		public void SetValue(string name, object val, string op)
		{
		}

		[Address(RVA="0x21DD474", Offset="0x21DD474", VA="0x21DD474", Slot="22")]
		public void Show(string placement)
		{
		}

		[Address(RVA="0x21DD47C", Offset="0x21DD47C", VA="0x21DD47C", Slot="23")]
		public void Show(string placement, IDictionary<string, string> overrideText)
		{
		}

		[Address(RVA="0x21DBD5C", Offset="0x21DBD5C", VA="0x21DBD5C", Slot="11")]
		public void TriggerEvent(string evt)
		{
		}

		[Address(RVA="0x21DCE7C", Offset="0x21DCE7C", VA="0x21DCE7C", Slot="16")]
		public void UpdateValue(UpdateValueInput val)
		{
		}

		public event Action<ConsentUpdateResult> ConsentUpdateReceived
		{
			[Address(RVA="0x21DB760", Offset="0x21DB760", VA="0x21DB760", Slot="20")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1074A88", Offset="0x1074A88")]
			add
			{
			}
			[Address(RVA="0x21DB84C", Offset="0x21DB84C", VA="0x21DB84C", Slot="21")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1074A98", Offset="0x1074A98")]
			remove
			{
			}
		}

		public event Action<ShowConsentResult> ShowConsentReceived
		{
			[Address(RVA="0x21DB588", Offset="0x21DB588", VA="0x21DB588", Slot="18")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1074A68", Offset="0x1074A68")]
			add
			{
			}
			[Address(RVA="0x21DB674", Offset="0x21DB674", VA="0x21DB674", Slot="19")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1074A78", Offset="0x1074A78")]
			remove
			{
			}
		}
	}
}