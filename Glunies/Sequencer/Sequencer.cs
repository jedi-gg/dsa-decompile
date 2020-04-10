using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Sequencer
{
	public abstract class Sequencer : MonoBehaviour, ILoggable<LogCategory>
	{
		[FieldOffset(Offset="0x18")]
		[SerializeField]
		private Sequence _sequence;

		[FieldOffset(Offset="0x20")]
		[SerializeField]
		protected List<Binding> _bindings;

		[FieldOffset(Offset="0x28")]
		[SerializeField]
		protected float _exitDuration;

		[FieldOffset(Offset="0x30")]
		private List<ASequenceAction> _actions;

		[FieldOffset(Offset="0x38")]
		private bool _isInitialized;

		[FieldOffset(Offset="0x39")]
		private bool _isPlaying;

		[FieldOffset(Offset="0x3C")]
		private int _nextActionIndex;

		[FieldOffset(Offset="0x40")]
		private bool _isExiting;

		[FieldOffset(Offset="0x44")]
		protected float _playTime;

		[FieldOffset(Offset="0x48")]
		protected float _duration;

		public List<Binding> Bindings
		{
			[Address(RVA="0x1533414", Offset="0x1533414", VA="0x1533414")]
			get
			{
				return null;
			}
		}

		public float ExitDurationS
		{
			[Address(RVA="0x1533428", Offset="0x1533428", VA="0x1533428")]
			get
			{
				return new float();
			}
		}

		public bool IsExiting
		{
			[Address(RVA="0x1533430", Offset="0x1533430", VA="0x1533430")]
			get
			{
				return new bool();
			}
		}

		public bool IsPlaying
		{
			[Address(RVA="0x1522DD0", Offset="0x1522DD0", VA="0x1522DD0")]
			get
			{
				return new bool();
			}
		}

		public LogCategory LogCategory
		{
			[Address(RVA="0x153340C", Offset="0x153340C", VA="0x153340C", Slot="4")]
			get
			{
				return new LogCategory();
			}
		}

		public float RemainingTime
		{
			[Address(RVA="0x153341C", Offset="0x153341C", VA="0x153341C")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0x153491C", Offset="0x153491C", VA="0x153491C")]
		protected Sequencer()
		{
		}

		[Address(RVA="0x15341C0", Offset="0x15341C0", VA="0x15341C0")]
		protected void _Play(float duration)
		{
		}

		[Address(RVA="0x15344E0", Offset="0x15344E0", VA="0x15344E0")]
		protected void _TickUpdate(float deltaTime)
		{
		}

		[Address(RVA="0x1534678", Offset="0x1534678", VA="0x1534678")]
		private void BeginExiting()
		{
		}

		[Address(RVA="0x1534020", Offset="0x1534020", VA="0x1534020")]
		public float CalculateTotalDuration()
		{
			return new float();
		}

		[Address(RVA="0x15348F8", Offset="0x15348F8", VA="0x15348F8")]
		private int GetPlayModeOrder(ASequenceAction.PlayMode playMode)
		{
			return new int();
		}

		[Address(RVA="0x1533458", Offset="0x1533458", VA="0x1533458", Slot="5")]
		public virtual void Initialize(Action<ASequenceAction> actionPreInitializeCallback = // 
		// Current member / type: System.Void Glunies.Sequencer.Sequencer::Initialize(System.Action`1<Glunies.Sequencer.ASequenceAction>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void Initialize(System.Action<Glunies.Sequencer.ASequenceAction>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15335D0", Offset="0x15335D0", VA="0x15335D0")]
		private void InitializeActions(Action<ASequenceAction> actionPreInitializeCallback)
		{
		}

		[Address(RVA="0x153348C", Offset="0x153348C", VA="0x153348C")]
		private void InitializeBindings()
		{
		}

		[Address(RVA="0x1533970", Offset="0x1533970", VA="0x1533970")]
		public void InvalidateGameObject(GameObject go)
		{
		}

		[Address(RVA="0x1534808", Offset="0x1534808", VA="0x1534808")]
		private int OrderByExecutionOrder(ASequenceAction a, ASequenceAction b)
		{
			return new int();
		}

		[Address(RVA="0x153472C", Offset="0x153472C", VA="0x153472C", Slot="6")]
		protected virtual void PlayAction(ASequenceAction action)
		{
		}

		[Address(RVA="0x15343B0", Offset="0x15343B0", VA="0x15343B0")]
		private void PlayActions(ASequenceAction.PlayMode playMode, float currentTime = float.MaxValue)
		{
		}

		[Address(RVA="0x1534624", Offset="0x1534624", VA="0x1534624")]
		private void PlayEndOfSequenceActions()
		{
		}

		[Address(RVA="0x1533C94", Offset="0x1533C94", VA="0x1533C94")]
		public void Rebind(GameObject originalGo, GameObject newGo)
		{
		}

		[Address(RVA="0x15343A0", Offset="0x15343A0", VA="0x15343A0")]
		private void ResetForPlay()
		{
		}

		[Address(RVA="0x1522BA0", Offset="0x1522BA0", VA="0x1522BA0")]
		public void Shutdown()
		{
		}

		[Address(RVA="0x1522AC8", Offset="0x1522AC8", VA="0x1522AC8")]
		public void Stop()
		{
		}
	}
}