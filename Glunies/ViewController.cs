using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using Zenject;

namespace Glunies
{
	public class ViewController : ILoggable<LogCategory>
	{
		[FieldOffset(Offset="0x0")]
		private const int VIEW_DEPTH_INNER_OFFSET = 100;

		[Attribute(Name="InjectAttribute", RVA="0x1064498", Offset="0x1064498")]
		[FieldOffset(Offset="0x10")]
		private InputSystem _inputSystem;

		[Attribute(Name="InjectAttribute", RVA="0x10644A8", Offset="0x10644A8")]
		[FieldOffset(Offset="0x18")]
		private SystemDialogManager _systemDialogManager;

		[Attribute(Name="InjectAttribute", RVA="0x10644B8", Offset="0x10644B8")]
		[FieldOffset(Offset="0x20")]
		private DispatchSystem _dispatch;

		[FieldOffset(Offset="0x28")]
		private DiContainer _localContainer;

		[FieldOffset(Offset="0x30")]
		private List<AView> _views;

		[FieldOffset(Offset="0x38")]
		private int _inputBlockingRefCount;

		public LogCategory LogCategory
		{
			[Address(RVA="0x16180C0", Offset="0x16180C0", VA="0x16180C0", Slot="4")]
			get
			{
				return new LogCategory();
			}
		}

		[Address(RVA="0x161872C", Offset="0x161872C", VA="0x161872C")]
		public ViewController()
		{
		}

		[Address(RVA="0x16185B0", Offset="0x16185B0", VA="0x16185B0")]
		public AView FindView(string viewTypeName, Func<AView, bool> condition = // 
		// Current member / type: Glunies.AView Glunies.ViewController::FindView(System.String,System.Func`2<Glunies.AView,System.Boolean>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: Glunies.AView FindView(System.String,System.Func<Glunies.AView,System.Boolean>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x16183D8", Offset="0x16183D8", VA="0x16183D8")]
		public void HandleBackButton()
		{
		}

		[Address(RVA="0x16180C8", Offset="0x16180C8", VA="0x16180C8")]
		public void Initialize(DiContainer container)
		{
		}

		[Address(RVA="0x1387F80", Offset="0x1387F80", VA="0x1387F80")]
		public void Load<T>(Action<T> viewLoaded, Func<bool> silence, bool startActive = true, DiContainer overrideContainer = // 
		// Current member / type: System.Void Glunies.ViewController::Load(System.Action`1<T>,System.Func`1<System.Boolean>,System.Boolean,Zenject.DiContainer)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void Load(System.Action<T>,System.Func<System.Boolean>,System.Boolean,Zenject.DiContainer)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x16180D8", Offset="0x16180D8", VA="0x16180D8")]
		public void Release(AView view)
		{
		}

		[Address(RVA="0x16180D0", Offset="0x16180D0", VA="0x16180D0")]
		public void Shutdown()
		{
		}

		[Address(RVA="0x16181AC", Offset="0x16181AC", VA="0x16181AC")]
		private void SortViewDepths()
		{
		}

		[Address(RVA="0x1618494", Offset="0x1618494", VA="0x1618494")]
		public void TickUpdate()
		{
		}

		[Address(RVA="0x16184CC", Offset="0x16184CC", VA="0x16184CC")]
		private void UpdateInputEnabled()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10510C8", Offset="0x10510C8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ViewController.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Comparison<AView> <>9__9_0;

			[Address(RVA="0x161879C", Offset="0x161879C", VA="0x161879C")]
			static <>c()
			{
			}

			[Address(RVA="0x1618800", Offset="0x1618800", VA="0x1618800")]
			public <>c()
			{
			}

			[Address(RVA="0x1618808", Offset="0x1618808", VA="0x1618808")]
			internal int <SortViewDepths>b__9_0(AView a, AView b)
			{
				return new int();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10510B8", Offset="0x10510B8")]
		private sealed class <>c__DisplayClass4_0<T>
		where T : AView, new()
		{
			[FieldOffset(Offset="0x0")]
			public Func<bool> silence;

			[FieldOffset(Offset="0x0")]
			public ViewController <>4__this;

			[FieldOffset(Offset="0x0")]
			public Action<T> viewLoaded;

			[FieldOffset(Offset="0x0")]
			public T view;

			[Address(RVA="0x1C02890", Offset="0x1C02890", VA="0x1C02890")]
			public <>c__DisplayClass4_0()
			{
			}

			[Address(RVA="0x1C028BC", Offset="0x1C028BC", VA="0x1C028BC")]
			internal void <Load>b__0()
			{
			}

			[Address(RVA="0x1C02A30", Offset="0x1C02A30", VA="0x1C02A30")]
			internal void <Load>b__1()
			{
			}
		}
	}
}