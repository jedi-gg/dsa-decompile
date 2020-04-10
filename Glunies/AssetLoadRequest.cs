using Il2CppDummyDll;
using System;

namespace Glunies
{
	public class AssetLoadRequest : IAsyncRequest
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1063E2C", Offset="0x1063E2C")]
		[FieldOffset(Offset="0x10")]
		private Glunies.AssetId <AssetId>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1063E3C", Offset="0x1063E3C")]
		[FieldOffset(Offset="0x18")]
		private bool <Persistent>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1063E4C", Offset="0x1063E4C")]
		[FieldOffset(Offset="0x20")]
		private Action<AssetHandle> <Finished>k__BackingField;

		[FieldOffset(Offset="0x28")]
		private IAsyncRequest _currentRequest;

		public Glunies.AssetId AssetId
		{
			[Address(RVA="0x14FD33C", Offset="0x14FD33C", VA="0x14FD33C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A144", Offset="0x108A144")]
			get
			{
				return null;
			}
			[Address(RVA="0x14FD344", Offset="0x14FD344", VA="0x14FD344")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A154", Offset="0x108A154")]
			private set
			{
			}
		}

		public Action<AssetHandle> Finished
		{
			[Address(RVA="0x14F456C", Offset="0x14F456C", VA="0x14F456C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A184", Offset="0x108A184")]
			get
			{
				return null;
			}
			[Address(RVA="0x14FD360", Offset="0x14FD360", VA="0x14FD360")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A194", Offset="0x108A194")]
			private set
			{
			}
		}

		public bool IsDone
		{
			[Address(RVA="0x14FD288", Offset="0x14FD288", VA="0x14FD288", Slot="4")]
			get
			{
				return new bool();
			}
		}

		public bool Persistent
		{
			[Address(RVA="0x14FD34C", Offset="0x14FD34C", VA="0x14FD34C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A164", Offset="0x108A164")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x14FD354", Offset="0x14FD354", VA="0x14FD354")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A174", Offset="0x108A174")]
			private set
			{
			}
		}

		[Address(RVA="0x14F40D8", Offset="0x14F40D8", VA="0x14F40D8")]
		public AssetLoadRequest(Glunies.AssetId assetId, bool persistent, Action<AssetHandle> finished)
		{
		}

		[Address(RVA="0x14FD368", Offset="0x14FD368", VA="0x14FD368", Slot="5")]
		public void Abort(Action aborted = // 
		// Current member / type: System.Void Glunies.AssetLoadRequest::Abort(System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void Abort(System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x14FD438", Offset="0x14FD438", VA="0x14FD438")]
		public void SetCurrentRequest(IAsyncRequest request)
		{
		}

		[Address(RVA="0x14F4694", Offset="0x14F4694", VA="0x14F4694")]
		public void Shutdown()
		{
		}
	}
}