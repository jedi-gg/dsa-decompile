using Glunies;
using Google.Protobuf;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using UnityEngine;

namespace BattleLib
{
	public abstract class ABattle : ILoggable<LogCategory>
	{
		[FieldOffset(Offset="0x0")]
		public const int MAX_UNITS = 63;

		[FieldOffset(Offset="0x0")]
		public const int MAX_UNITS_PER_TEAM = 10;

		[FieldOffset(Offset="0x0")]
		private const int INITIAL_OUTGOING_BUFFER_SIZE = 1024;

		[Attribute(Name="InjectAttribute", RVA="0x1063D2C", Offset="0x1063D2C")]
		[FieldOffset(Offset="0x10")]
		protected DispatchSystem _dispatch;

		[Attribute(Name="InjectAttribute", RVA="0x1063D3C", Offset="0x1063D3C")]
		[FieldOffset(Offset="0x18")]
		private GamedataDomainController _gamedataDC;

		[Attribute(Name="InjectAttribute", RVA="0x1063D4C", Offset="0x1063D4C")]
		[FieldOffset(Offset="0x20")]
		private BattleConfig _battleConfig;

		[FieldOffset(Offset="0x28")]
		protected ByteString _battleDataBuffer;

		[FieldOffset(Offset="0x30")]
		protected BattleLib_Bootstrap _battleData;

		[FieldOffset(Offset="0x38")]
		protected byte _playerId;

		[FieldOffset(Offset="0x39")]
		protected byte _playerTeamId;

		[FieldOffset(Offset="0x3A")]
		protected bool _battleHasEnded;

		[FieldOffset(Offset="0x3B")]
		private bool _isBattleBusy;

		[FieldOffset(Offset="0x40")]
		private ABattleGameState.ATransitionContext _context;

		[FieldOffset(Offset="0x48")]
		private bool _isShutdown;

		[FieldOffset(Offset="0x50")]
		private byte[] _pendingResultsBuffer;

		[FieldOffset(Offset="0x58")]
		private int _pendingResultsBufferLength;

		[FieldOffset(Offset="0x60")]
		private BattleLib_UpdateResultList _updateResultList;

		[FieldOffset(Offset="0x68")]
		protected ABattle.OptionalValueLock<bool> _havePendingResults;

		[FieldOffset(Offset="0x70")]
		private int _updateResultNextIndex;

		[FieldOffset(Offset="0x78")]
		private BattleHandler _messageHandler;

		[FieldOffset(Offset="0x80")]
		private Queue<ABattle.DPlayerCast> _castQueue;

		[FieldOffset(Offset="0x88")]
		private ABattle.OptionalValueLock<bool> _autoBattleRequest;

		[FieldOffset(Offset="0x90")]
		private ABattle.OptionalValueLock<byte> _cinematicDoneRequest;

		[FieldOffset(Offset="0x98")]
		private ABattle.OptionalValueLock<uint> _encounterTransitionDoneRequest;

		[FieldOffset(Offset="0xA0")]
		private List<ABattle.DPendingAbility> _pendingAbilities;

		[FieldOffset(Offset="0xA8")]
		private int _inbetweenEncountersPriorIndex;

		[FieldOffset(Offset="0xB0")]
		private DBattleLibMetrics _lastMetrics;

		[FieldOffset(Offset="0xC8")]
		private bool _positionsReversed;

		[FieldOffset(Offset="0xC9")]
		private byte _preferredTargetId;

		[FieldOffset(Offset="0xD0")]
		private BattleLib_PlayerMessage _playerMessage;

		[FieldOffset(Offset="0xD8")]
		private byte[] _playerMessageBytes;

		[FieldOffset(Offset="0xE0")]
		private MemoryStream _playerMessageStream;

		[FieldOffset(Offset="0xE8")]
		private CodedOutputStream _playerMessageProtoStream;

		[FieldOffset(Offset="0xF0")]
		private bool _playerQuit;

		public virtual bool AllowCatchupTimeScale
		{
			[Address(RVA="0x1101BA0", Offset="0x1101BA0", VA="0x1101BA0", Slot="6")]
			get
			{
				return new bool();
			}
		}

		public BattleLib_Bootstrap.Types.Map BattleMap
		{
			[Address(RVA="0x1101AD8", Offset="0x1101AD8", VA="0x1101AD8")]
			get
			{
				return null;
			}
		}

		public IList<BattleLib_Bootstrap.Types.SpawnPoint> BattleSpawnPoints
		{
			[Address(RVA="0x1101B20", Offset="0x1101B20", VA="0x1101B20")]
			get
			{
				return null;
			}
		}

		public virtual bool DetectBadConnection
		{
			[Address(RVA="0x1101AAC", Offset="0x1101AAC", VA="0x1101AAC", Slot="5")]
			get
			{
				return new bool();
			}
		}

		public string IntroCinematicOverride
		{
			[Address(RVA="0x1101B60", Offset="0x1101B60", VA="0x1101B60")]
			get
			{
				return null;
			}
		}

		public bool IsBattleBusy
		{
			[Address(RVA="0x1101B90", Offset="0x1101B90", VA="0x1101B90")]
			get
			{
				return new bool();
			}
		}

		public LogCategory LogCategory
		{
			[Address(RVA="0x1101AA4", Offset="0x1101AA4", VA="0x1101AA4", Slot="4")]
			get
			{
				return new LogCategory();
			}
		}

		public byte PlayerId
		{
			[Address(RVA="0x1101AB4", Offset="0x1101AB4", VA="0x1101AB4")]
			get
			{
				return new byte();
			}
		}

		public byte PlayerTeamId
		{
			[Address(RVA="0x1101ABC", Offset="0x1101ABC", VA="0x1101ABC")]
			get
			{
				return new byte();
			}
		}

		public int PlayerTravelDirection
		{
			[Address(RVA="0x1101AC4", Offset="0x1101AC4", VA="0x1101AC4")]
			get
			{
				return new int();
			}
		}

		public bool PositionsReversed
		{
			[Address(RVA="0x1101B98", Offset="0x1101B98", VA="0x1101B98")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x1101BA8", Offset="0x1101BA8", VA="0x1101BA8")]
		public ABattle(byte localPlayerId, ByteString battleDataBuffer)
		{
		}

		public abstract void Begin();

		[Address(RVA="0x1109824", Offset="0x1109824", VA="0x1109824")]
		protected MemoryStream BuildPlayerMessageBuffer()
		{
			return null;
		}

		[Address(RVA="0x110A188", Offset="0x110A188", VA="0x110A188")]
		private void ClearPlayerMessage()
		{
		}

		[Address(RVA="0x110AB54", Offset="0x110AB54", VA="0x110AB54")]
		private void ClearUpdateResult()
		{
		}

		[Address(RVA="0x1109768", Offset="0x1109768", VA="0x1109768")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1089EE4", Offset="0x1089EE4")]
		private IEnumerable<BattleLib_Bootstrap.Types.Unit> GetAddUnits(BattleLib_Bootstrap.Types.Unit unit)
		{
			return null;
		}

		[Address(RVA="0x1107EC4", Offset="0x1107EC4", VA="0x1107EC4")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1089CF0", Offset="0x1089CF0")]
		public IEnumerable<BattleLib_Bootstrap.Types.Player> GetAllPlayers()
		{
			return null;
		}

		[Address(RVA="0x1107824", Offset="0x1107824", VA="0x1107824")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1089DB8", Offset="0x1089DB8")]
		protected IEnumerable<BattleLib_Bootstrap.Types.Spell> GetAllSpells(byte? playerId = // 
		// Current member / type: System.Collections.Generic.IEnumerable`1<Serverproto.BattleLib_Bootstrap/Types/Spell> BattleLib.ABattle::GetAllSpells(System.Nullable`1<System.Byte>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Collections.Generic.IEnumerable<Serverproto.BattleLib_Bootstrap/Types/Spell> GetAllSpells(System.Nullable<System.Byte>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x1109650", Offset="0x1109650", VA="0x1109650")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1089E1C", Offset="0x1089E1C")]
		protected IEnumerable<BattleLib_Bootstrap.Types.Squad> GetAllSquads(byte? playerId = // 
		// Current member / type: System.Collections.Generic.IEnumerable`1<Serverproto.BattleLib_Bootstrap/Types/Squad> BattleLib.ABattle::GetAllSquads(System.Nullable`1<System.Byte>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Collections.Generic.IEnumerable<Serverproto.BattleLib_Bootstrap/Types/Squad> GetAllSquads(System.Nullable<System.Byte>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x1106AA0", Offset="0x1106AA0", VA="0x1106AA0")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1089E80", Offset="0x1089E80")]
		protected IEnumerable<BattleLib_Bootstrap.Types.Unit> GetAllUnits(byte? playerId = // 
		// Current member / type: System.Collections.Generic.IEnumerable`1<Serverproto.BattleLib_Bootstrap/Types/Unit> BattleLib.ABattle::GetAllUnits(System.Nullable`1<System.Byte>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Collections.Generic.IEnumerable<Serverproto.BattleLib_Bootstrap/Types/Unit> GetAllUnits(System.Nullable<System.Byte>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x1108FFC", Offset="0x1108FFC", VA="0x1108FFC")]
		public string[] GetCinematicAssets()
		{
			return null;
		}

		[Address(RVA="0x1109374", Offset="0x1109374", VA="0x1109374")]
		public string GetCinematicForEncounter(int encounterIndex)
		{
			return null;
		}

		[Address(RVA="0x1106B48", Offset="0x1106B48", VA="0x1106B48")]
		public HashSet<ulong> GetEffectVisualIds()
		{
			return null;
		}

		[Address(RVA="0x1108608", Offset="0x1108608", VA="0x1108608")]
		public BattleLib_Bootstrap.Types.Encounter GetEncounter(int i)
		{
			return null;
		}

		[Address(RVA="0x1108344", Offset="0x1108344", VA="0x1108344")]
		public string[] GetEnvironmentAssets()
		{
			return null;
		}

		[Address(RVA="0x1108744", Offset="0x1108744", VA="0x1108744")]
		public int? GetFirstEncounterIndex()
		{
			return null;
		}

		[Address(RVA="0x1108280", Offset="0x1108280", VA="0x1108280")]
		public BattleLib_Bootstrap.Types.Player GetLocalPlayer()
		{
			return null;
		}

		[Address(RVA="0x1108288", Offset="0x1108288", VA="0x1108288")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1089D54", Offset="0x1089D54")]
		public IEnumerable<BattleLib_Bootstrap.Types.Ability> GetLocalPlayerAbilities()
		{
			return null;
		}

		[Address(RVA="0x1107BF0", Offset="0x1107BF0", VA="0x1107BF0")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1089C8C", Offset="0x1089C8C")]
		public IEnumerable<BattleLib_Bootstrap.Types.Unit> GetLocalPlayerUnits()
		{
			return null;
		}

		[Address(RVA="0x1109560", Offset="0x1109560", VA="0x1109560", Slot="13")]
		protected virtual DBattleLibMetrics GetMetrics(int payloadSize)
		{
			return new DBattleLibMetrics();
		}

		[Address(RVA="0x1107F80", Offset="0x1107F80", VA="0x1107F80")]
		public BattleLib_Bootstrap.Types.Player GetPlayer(byte playerId)
		{
			return null;
		}

		[Address(RVA="0x1105FEC", Offset="0x1105FEC", VA="0x1105FEC")]
		public Vector3 GetSpawnPos(uint teamId, int spawnIndex)
		{
			return new Vector3();
		}

		[Address(RVA="0x1106464", Offset="0x1106464", VA="0x1106464")]
		public string[] GetUnitAssets()
		{
			return null;
		}

		[Address(RVA="0x11078CC", Offset="0x11078CC", VA="0x11078CC")]
		public BattleLib_Bootstrap.Types.Unit GetUnitData(ulong contentId, byte playerId)
		{
			return null;
		}

		[Address(RVA="0x110A1E8", Offset="0x110A1E8", VA="0x110A1E8")]
		protected void HandleResultBuffer(byte[] result, int resultLength)
		{
		}

		[Address(RVA="0x1101D80", Offset="0x1101D80", VA="0x1101D80")]
		public void Initialize(ABattleGameState.ATransitionContext context, Action<bool> finished)
		{
		}

		[Address(RVA="0x1109470", Offset="0x1109470", VA="0x1109470", Slot="12")]
		protected virtual void InternalInit(Action<bool> finished)
		{
		}

		[Address(RVA="0x1101D6C", Offset="0x1101D6C", VA="0x1101D6C")]
		public bool IsShutdown()
		{
			return new bool();
		}

		[Address(RVA="0x1105C50", Offset="0x1105C50", VA="0x1105C50")]
		public void PlayerAutoBattle(bool enabled)
		{
		}

		[Address(RVA="0x1105ACC", Offset="0x1105ACC", VA="0x1105ACC")]
		public void PlayerCast(AbilitySourceType sourceType, byte sourceId, byte abilityId, byte target, byte spawnIndex, byte manaCost)
		{
		}

		[Address(RVA="0x1105D28", Offset="0x1105D28", VA="0x1105D28")]
		public void PlayerCinematicDone(byte encounterIndex)
		{
		}

		[Address(RVA="0x1105F6C", Offset="0x1105F6C", VA="0x1105F6C", Slot="10")]
		public virtual void PlayerEmote(ulong emoteId)
		{
		}

		[Address(RVA="0x1105E44", Offset="0x1105E44", VA="0x1105E44")]
		public void PlayerEncounterTransitionDone()
		{
		}

		[Address(RVA="0x1105AC0", Offset="0x1105AC0", VA="0x1105AC0")]
		public void PlayerQuit()
		{
		}

		[Address(RVA="0x1101EE4", Offset="0x1101EE4", VA="0x1101EE4")]
		protected void ProcessResults()
		{
		}

		[Address(RVA="0x1107DC8", Offset="0x1107DC8", VA="0x1107DC8")]
		public bool RemovePendingAbilities(byte unitId)
		{
			return new bool();
		}

		[Address(RVA="0x1107CAC", Offset="0x1107CAC", VA="0x1107CAC")]
		public bool RemovePendingAbility(AbilitySourceType sourceType, byte sourceId, byte abilityId)
		{
			return new bool();
		}

		[Address(RVA="0x1101D98", Offset="0x1101D98", VA="0x1101D98")]
		public void SetBattleMessageHandler(BattleHandler handler)
		{
		}

		[Address(RVA="0x1105FE8", Offset="0x1105FE8", VA="0x1105FE8", Slot="11")]
		public virtual void SetBattleSpeed(float speed)
		{
		}

		[Address(RVA="0x1105C3C", Offset="0x1105C3C", VA="0x1105C3C")]
		public void SetPreferredTargetId(byte preferredTargetId)
		{
		}

		[Address(RVA="0x1101D74", Offset="0x1101D74", VA="0x1101D74", Slot="8")]
		public virtual void Shutdown()
		{
		}

		[Address(RVA="0x1101DA0", Offset="0x1101DA0", VA="0x1101DA0", Slot="9")]
		public virtual void Update()
		{
		}

		[Address(RVA="0x110A304", Offset="0x110A304", VA="0x110A304")]
		private void UpdateResultListFromBuffer()
		{
		}

		[Address(RVA="0x110AB28", Offset="0x110AB28", VA="0x110AB28")]
		protected bool WaitingToProcessResults()
		{
			return new bool();
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050D38", Offset="0x1050D38")]
		private sealed class <GetAddUnits>d__60 : IEnumerable<BattleLib_Bootstrap.Types.Unit>, IEnumerable, IEnumerator<BattleLib_Bootstrap.Types.Unit>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private BattleLib_Bootstrap.Types.Unit <>2__current;

			[FieldOffset(Offset="0x20")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x28")]
			private BattleLib_Bootstrap.Types.Unit unit;

			[FieldOffset(Offset="0x30")]
			public BattleLib_Bootstrap.Types.Unit <>3__unit;

			[FieldOffset(Offset="0x38")]
			private IEnumerator<BattleLib_Bootstrap.Types.Ability> <>7__wrap1;

			private BattleLib_Bootstrap.Types.Unit System.Collections.Generic.IEnumerator<Serverproto.BattleLib_Bootstrap.Types.Unit>.Current
			{
				[Address(RVA="0x110B024", Offset="0x110B024", VA="0x110B024", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x110B094", Offset="0x110B094", VA="0x110B094", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x11097EC", Offset="0x11097EC", VA="0x11097EC")]
			[DebuggerHidden]
			public <GetAddUnits>d__60(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x110ACF0", Offset="0x110ACF0", VA="0x110ACF0")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x110ADB0", Offset="0x110ADB0", VA="0x110ADB0", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x110B09C", Offset="0x110B09C", VA="0x110B09C", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<BattleLib_Bootstrap.Types.Unit> System.Collections.Generic.IEnumerable<Serverproto.BattleLib_Bootstrap.Types.Unit>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x110B14C", Offset="0x110B14C", VA="0x110B14C", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x110B02C", Offset="0x110B02C", VA="0x110B02C", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x110ACD4", Offset="0x110ACD4", VA="0x110ACD4", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050CE8", Offset="0x1050CE8")]
		private sealed class <GetAllPlayers>d__46 : IEnumerable<BattleLib_Bootstrap.Types.Player>, IEnumerable, IEnumerator<BattleLib_Bootstrap.Types.Player>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private BattleLib_Bootstrap.Types.Player <>2__current;

			[FieldOffset(Offset="0x20")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x28")]
			public ABattle <>4__this;

			[FieldOffset(Offset="0x30")]
			private IEnumerator<BattleLib_Bootstrap.Types.Player> <>7__wrap1;

			private BattleLib_Bootstrap.Types.Player System.Collections.Generic.IEnumerator<Serverproto.BattleLib_Bootstrap.Types.Player>.Current
			{
				[Address(RVA="0x110B470", Offset="0x110B470", VA="0x110B470", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x110B4E0", Offset="0x110B4E0", VA="0x110B4E0", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1107F48", Offset="0x1107F48", VA="0x1107F48")]
			[DebuggerHidden]
			public <GetAllPlayers>d__46(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x110B16C", Offset="0x110B16C", VA="0x110B16C")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x110B22C", Offset="0x110B22C", VA="0x110B22C", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x110B4E8", Offset="0x110B4E8", VA="0x110B4E8", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<BattleLib_Bootstrap.Types.Player> System.Collections.Generic.IEnumerable<Serverproto.BattleLib_Bootstrap.Types.Player>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x110B598", Offset="0x110B598", VA="0x110B598", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x110B478", Offset="0x110B478", VA="0x110B478", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x110B150", Offset="0x110B150", VA="0x110B150", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050D08", Offset="0x1050D08")]
		private sealed class <GetAllSpells>d__57 : IEnumerable<BattleLib_Bootstrap.Types.Spell>, IEnumerable, IEnumerator<BattleLib_Bootstrap.Types.Spell>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private BattleLib_Bootstrap.Types.Spell <>2__current;

			[FieldOffset(Offset="0x20")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x28")]
			public ABattle <>4__this;

			[FieldOffset(Offset="0x30")]
			private byte? playerId;

			[FieldOffset(Offset="0x32")]
			public byte? <>3__playerId;

			[FieldOffset(Offset="0x38")]
			private IEnumerator<BattleLib_Bootstrap.Types.Player> <>7__wrap1;

			[FieldOffset(Offset="0x40")]
			private IEnumerator<BattleLib_Bootstrap.Types.Spell> <>7__wrap2;

			private BattleLib_Bootstrap.Types.Spell System.Collections.Generic.IEnumerator<Serverproto.BattleLib_Bootstrap.Types.Spell>.Current
			{
				[Address(RVA="0x110BBE4", Offset="0x110BBE4", VA="0x110BBE4", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x110BC54", Offset="0x110BC54", VA="0x110BC54", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1109618", Offset="0x1109618", VA="0x1109618")]
			[DebuggerHidden]
			public <GetAllSpells>d__57(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x110B6D4", Offset="0x110B6D4", VA="0x110B6D4")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x110B614", Offset="0x110B614", VA="0x110B614")]
			private void <>m__Finally2()
			{
			}

			[Address(RVA="0x110B794", Offset="0x110B794", VA="0x110B794", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x110BC5C", Offset="0x110BC5C", VA="0x110BC5C", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<BattleLib_Bootstrap.Types.Spell> System.Collections.Generic.IEnumerable<Serverproto.BattleLib_Bootstrap.Types.Spell>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x110BD1C", Offset="0x110BD1C", VA="0x110BD1C", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x110BBEC", Offset="0x110BBEC", VA="0x110BBEC", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x110B59C", Offset="0x110B59C", VA="0x110B59C", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050D18", Offset="0x1050D18")]
		private sealed class <GetAllSquads>d__58 : IEnumerable<BattleLib_Bootstrap.Types.Squad>, IEnumerable, IEnumerator<BattleLib_Bootstrap.Types.Squad>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private BattleLib_Bootstrap.Types.Squad <>2__current;

			[FieldOffset(Offset="0x20")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x28")]
			public ABattle <>4__this;

			[FieldOffset(Offset="0x30")]
			private byte? playerId;

			[FieldOffset(Offset="0x32")]
			public byte? <>3__playerId;

			[FieldOffset(Offset="0x38")]
			private IEnumerator<BattleLib_Bootstrap.Types.Player> <>7__wrap1;

			[FieldOffset(Offset="0x40")]
			private IEnumerator<BattleLib_Bootstrap.Types.Squad> <>7__wrap2;

			private BattleLib_Bootstrap.Types.Squad System.Collections.Generic.IEnumerator<Serverproto.BattleLib_Bootstrap.Types.Squad>.Current
			{
				[Address(RVA="0x110C368", Offset="0x110C368", VA="0x110C368", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x110C3D8", Offset="0x110C3D8", VA="0x110C3D8", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x11096F8", Offset="0x11096F8", VA="0x11096F8")]
			[DebuggerHidden]
			public <GetAllSquads>d__58(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x110BE58", Offset="0x110BE58", VA="0x110BE58")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x110BD98", Offset="0x110BD98", VA="0x110BD98")]
			private void <>m__Finally2()
			{
			}

			[Address(RVA="0x110BF18", Offset="0x110BF18", VA="0x110BF18", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x110C3E0", Offset="0x110C3E0", VA="0x110C3E0", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<BattleLib_Bootstrap.Types.Squad> System.Collections.Generic.IEnumerable<Serverproto.BattleLib_Bootstrap.Types.Squad>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x110C4A0", Offset="0x110C4A0", VA="0x110C4A0", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x110C370", Offset="0x110C370", VA="0x110C370", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x110BD20", Offset="0x110BD20", VA="0x110BD20", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050D28", Offset="0x1050D28")]
		private sealed class <GetAllUnits>d__59 : IEnumerable<BattleLib_Bootstrap.Types.Unit>, IEnumerable, IEnumerator<BattleLib_Bootstrap.Types.Unit>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private BattleLib_Bootstrap.Types.Unit <>2__current;

			[FieldOffset(Offset="0x20")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x28")]
			public ABattle <>4__this;

			[FieldOffset(Offset="0x30")]
			private byte? playerId;

			[FieldOffset(Offset="0x32")]
			public byte? <>3__playerId;

			[FieldOffset(Offset="0x38")]
			private IEnumerator<BattleLib_Bootstrap.Types.Squad> <>7__wrap1;

			[FieldOffset(Offset="0x40")]
			private IEnumerator<BattleLib_Bootstrap.Types.Unit> <>7__wrap2;

			[FieldOffset(Offset="0x48")]
			private BattleLib_Bootstrap.Types.Unit <unit>5__4;

			[FieldOffset(Offset="0x50")]
			private IEnumerator<BattleLib_Bootstrap.Types.Unit> <>7__wrap4;

			[FieldOffset(Offset="0x58")]
			private IEnumerator<BattleLib_Bootstrap.Types.Spell> <>7__wrap5;

			[FieldOffset(Offset="0x60")]
			private BattleLib_Bootstrap.Types.Ability <spellAbility>5__7;

			private BattleLib_Bootstrap.Types.Unit System.Collections.Generic.IEnumerator<Serverproto.BattleLib_Bootstrap.Types.Unit>.Current
			{
				[Address(RVA="0x110D32C", Offset="0x110D32C", VA="0x110D32C", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x110D39C", Offset="0x110D39C", VA="0x110D39C", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1109730", Offset="0x1109730", VA="0x1109730")]
			[DebuggerHidden]
			public <GetAllUnits>d__59(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x110C6DC", Offset="0x110C6DC", VA="0x110C6DC")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x110C61C", Offset="0x110C61C", VA="0x110C61C")]
			private void <>m__Finally2()
			{
			}

			[Address(RVA="0x110C55C", Offset="0x110C55C", VA="0x110C55C")]
			private void <>m__Finally3()
			{
			}

			[Address(RVA="0x110C85C", Offset="0x110C85C", VA="0x110C85C")]
			private void <>m__Finally4()
			{
			}

			[Address(RVA="0x110C79C", Offset="0x110C79C", VA="0x110C79C")]
			private void <>m__Finally5()
			{
			}

			[Address(RVA="0x110C91C", Offset="0x110C91C", VA="0x110C91C", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x110D3A4", Offset="0x110D3A4", VA="0x110D3A4", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<BattleLib_Bootstrap.Types.Unit> System.Collections.Generic.IEnumerable<Serverproto.BattleLib_Bootstrap.Types.Unit>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x110D464", Offset="0x110D464", VA="0x110D464", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x110D334", Offset="0x110D334", VA="0x110D334", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x110C4A4", Offset="0x110C4A4", VA="0x110C4A4", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050CF8", Offset="0x1050CF8")]
		private sealed class <GetLocalPlayerAbilities>d__49 : IEnumerable<BattleLib_Bootstrap.Types.Ability>, IEnumerable, IEnumerator<BattleLib_Bootstrap.Types.Ability>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private BattleLib_Bootstrap.Types.Ability <>2__current;

			[FieldOffset(Offset="0x20")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x28")]
			public ABattle <>4__this;

			[FieldOffset(Offset="0x30")]
			private IEnumerator<BattleLib_Bootstrap.Types.Unit> <>7__wrap1;

			[FieldOffset(Offset="0x38")]
			private IEnumerator<BattleLib_Bootstrap.Types.Ability> <>7__wrap2;

			[FieldOffset(Offset="0x40")]
			private IEnumerator<BattleLib_Bootstrap.Types.Spell> <>7__wrap3;

			private BattleLib_Bootstrap.Types.Ability System.Collections.Generic.IEnumerator<Serverproto.BattleLib_Bootstrap.Types.Ability>.Current
			{
				[Address(RVA="0x110DD4C", Offset="0x110DD4C", VA="0x110DD4C", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x110DDBC", Offset="0x110DDBC", VA="0x110DDBC", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x110830C", Offset="0x110830C", VA="0x110830C")]
			[DebuggerHidden]
			public <GetLocalPlayerAbilities>d__49(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x110D5A8", Offset="0x110D5A8", VA="0x110D5A8")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x110D4E8", Offset="0x110D4E8", VA="0x110D4E8")]
			private void <>m__Finally2()
			{
			}

			[Address(RVA="0x110D668", Offset="0x110D668", VA="0x110D668")]
			private void <>m__Finally3()
			{
			}

			[Address(RVA="0x110D728", Offset="0x110D728", VA="0x110D728", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x110DDC4", Offset="0x110DDC4", VA="0x110DDC4", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<BattleLib_Bootstrap.Types.Ability> System.Collections.Generic.IEnumerable<Serverproto.BattleLib_Bootstrap.Types.Ability>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x110DE74", Offset="0x110DE74", VA="0x110DE74", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x110DD54", Offset="0x110DD54", VA="0x110DD54", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x110D468", Offset="0x110D468", VA="0x110D468", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050CD8", Offset="0x1050CD8")]
		private sealed class <GetLocalPlayerUnits>d__43 : IEnumerable<BattleLib_Bootstrap.Types.Unit>, IEnumerable, IEnumerator<BattleLib_Bootstrap.Types.Unit>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private BattleLib_Bootstrap.Types.Unit <>2__current;

			[FieldOffset(Offset="0x20")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x28")]
			public ABattle <>4__this;

			[FieldOffset(Offset="0x30")]
			private IEnumerator<BattleLib_Bootstrap.Types.Unit> <>7__wrap1;

			private BattleLib_Bootstrap.Types.Unit System.Collections.Generic.IEnumerator<Serverproto.BattleLib_Bootstrap.Types.Unit>.Current
			{
				[Address(RVA="0x110E1F8", Offset="0x110E1F8", VA="0x110E1F8", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x110E268", Offset="0x110E268", VA="0x110E268", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1107C74", Offset="0x1107C74", VA="0x1107C74")]
			[DebuggerHidden]
			public <GetLocalPlayerUnits>d__43(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x110DE94", Offset="0x110DE94", VA="0x110DE94")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x110DF54", Offset="0x110DF54", VA="0x110DF54", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x110E270", Offset="0x110E270", VA="0x110E270", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<BattleLib_Bootstrap.Types.Unit> System.Collections.Generic.IEnumerable<Serverproto.BattleLib_Bootstrap.Types.Unit>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x110E320", Offset="0x110E320", VA="0x110E320", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x110E200", Offset="0x110E200", VA="0x110E200", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x110DE78", Offset="0x110DE78", VA="0x110DE78", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		private struct DPendingAbility
		{
			[FieldOffset(Offset="0x0")]
			public byte ReservedMana;

			[FieldOffset(Offset="0x4")]
			public AbilitySourceType SourceType;

			[FieldOffset(Offset="0x8")]
			public byte SourceId;

			[FieldOffset(Offset="0x9")]
			public byte AbilityId;
		}

		private struct DPlayerCast
		{
			[FieldOffset(Offset="0x0")]
			public AbilitySourceType SourceType;

			[FieldOffset(Offset="0x4")]
			public byte SourceId;

			[FieldOffset(Offset="0x5")]
			public byte AbilityId;

			[FieldOffset(Offset="0x6")]
			public byte Target;

			[FieldOffset(Offset="0x7")]
			public byte SpawnIndex;
		}

		protected class OptionalValueLock<T>
		{
			[FieldOffset(Offset="0x0")]
			public bool IsSet;

			[FieldOffset(Offset="0x0")]
			public T Value;

			[Address(RVA="0x211F674", Offset="0x211F674", VA="0x211F674")]
			public OptionalValueLock()
			{
			}
		}
	}
}