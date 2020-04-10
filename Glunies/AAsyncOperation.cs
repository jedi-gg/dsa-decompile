using Il2CppDummyDll;
using System;

namespace Glunies
{
	public abstract class AAsyncOperation : IAsyncRequest
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1063F7C", Offset="0x1063F7C")]
		[FieldOffset(Offset="0x10")]
		private bool <IsDone>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1063F8C", Offset="0x1063F8C")]
		[FieldOffset(Offset="0x11")]
		private bool <WasError>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1063F9C", Offset="0x1063F9C")]
		[FieldOffset(Offset="0x12")]
		private bool <WasAborted>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1063FAC", Offset="0x1063FAC")]
		[FieldOffset(Offset="0x18")]
		private Action <Aborted>k__BackingField;

		public Action Aborted
		{
			[Address(RVA="0x14F4728", Offset="0x14F4728", VA="0x14F4728")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A2C4", Offset="0x108A2C4")]
			get
			{
				return null;
			}
			[Address(RVA="0x14F4730", Offset="0x14F4730", VA="0x14F4730")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A2D4", Offset="0x108A2D4")]
			private set
			{
			}
		}

		public bool IsDone
		{
			[Address(RVA="0x14F46FC", Offset="0x14F46FC", VA="0x14F46FC", Slot="4")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A264", Offset="0x108A264")]
			get
			{
				return JustDecompileGenerated_get_IsDone();
			}
			[Address(RVA="0x14F4704", Offset="0x14F4704", VA="0x14F4704")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A274", Offset="0x108A274")]
			set
			{
				JustDecompileGenerated_set_IsDone(value);
			}
		}

		public bool JustDecompileGenerated_get_IsDone()
		{
			return new bool();
		}

		protected void JustDecompileGenerated_set_IsDone(bool value)
		{
		}

		public bool WasAborted
		{
			[Address(RVA="0x14F4470", Offset="0x14F4470", VA="0x14F4470")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A2A4", Offset="0x108A2A4")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x14F471C", Offset="0x14F471C", VA="0x14F471C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A2B4", Offset="0x108A2B4")]
			protected set
			{
			}
		}

		public bool WasError
		{
			[Address(RVA="0x14F4564", Offset="0x14F4564", VA="0x14F4564")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A284", Offset="0x108A284")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x14F4710", Offset="0x14F4710", VA="0x14F4710")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A294", Offset="0x108A294")]
			protected set
			{
			}
		}

		[Address(RVA="0x14F4784", Offset="0x14F4784", VA="0x14F4784")]
		protected AAsyncOperation()
		{
		}

		[Address(RVA="0x14F4750", Offset="0x14F4750", VA="0x14F4750", Slot="5")]
		public void Abort(Action aborted = // 
		// Current member / type: System.Void Glunies.AAsyncOperation::Abort(System.Action)
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


		protected abstract void OnAbort();

		protected abstract void OnUpdate();

		[Address(RVA="0x14F477C", Offset="0x14F477C", VA="0x14F477C", Slot="6")]
		public virtual void Shutdown()
		{
		}

		[Address(RVA="0x14F4738", Offset="0x14F4738", VA="0x14F4738")]
		public void TickUpdate()
		{
		}
	}
}