using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using Zenject;

public class SquadSelectGameState : AGameState
{
	[Attribute(Name="InjectAttribute", RVA="0x105C980", Offset="0x105C980")]
	[FieldOffset(Offset="0x30")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105C990", Offset="0x105C990")]
	[FieldOffset(Offset="0x38")]
	private DispatchSystem _dispatch;

	[Attribute(Name="InjectAttribute", RVA="0x105C9A0", Offset="0x105C9A0")]
	[FieldOffset(Offset="0x40")]
	private DiContainer _diContainer;

	[FieldOffset(Offset="0x48")]
	private PvpLobbyController _pvpLobbyController;

	public override bool ShowGlobalBackdrop
	{
		[Address(RVA="0x1220F70", Offset="0x1220F70", VA="0x1220F70", Slot="10")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x122162C", Offset="0x122162C", VA="0x122162C")]
	public SquadSelectGameState()
	{
	}

	[Address(RVA="0x1220F78", Offset="0x1220F78", VA="0x1220F78", Slot="4")]
	public override void Entering(ITransitionContext context)
	{
	}

	[Address(RVA="0x12215B8", Offset="0x12215B8", VA="0x12215B8", Slot="5")]
	public override void Exiting()
	{
	}

	[Address(RVA="0x12215F0", Offset="0x12215F0", VA="0x12215F0", Slot="11")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CC1C", Offset="0x104CC1C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public SquadSelectGameState <>4__this;

		[FieldOffset(Offset="0x18")]
		public ITransitionContext context;

		[Address(RVA="0x1221468", Offset="0x1221468", VA="0x1221468")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x1221634", Offset="0x1221634", VA="0x1221634")]
		internal void <Entering>b__0(Action complete)
		{
		}

		[Address(RVA="0x122167C", Offset="0x122167C", VA="0x122167C")]
		internal void <Entering>b__1(Action complete)
		{
		}

		[Address(RVA="0x12217E0", Offset="0x12217E0", VA="0x12217E0")]
		internal void <Entering>b__2()
		{
		}
	}

	public abstract class AContext : GameStateTransitionContext
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106BC34", Offset="0x106BC34")]
		[FieldOffset(Offset="0x20")]
		private PersistedPlayerBattleUnits <UnitsBattleInfo>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106BC44", Offset="0x106BC44")]
		[FieldOffset(Offset="0x28")]
		private Gamedata.GameMode <GameMode>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106BC54", Offset="0x106BC54")]
		[FieldOffset(Offset="0x2C")]
		private SquadSelectView.ActionMode <ActionMode>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106BC64", Offset="0x106BC64")]
		[FieldOffset(Offset="0x30")]
		private List<ulong> <ExcludedUnits>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106BC74", Offset="0x106BC74")]
		[FieldOffset(Offset="0x38")]
		private string <ExcludedUnitsAlertKey>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106BC84", Offset="0x106BC84")]
		[FieldOffset(Offset="0x40")]
		private List<ulong> <ExcludedSpells>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106BC94", Offset="0x106BC94")]
		[FieldOffset(Offset="0x48")]
		private string <ExcludedSpellsAlertKey>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106BCA4", Offset="0x106BCA4")]
		[FieldOffset(Offset="0x50")]
		private ulong <BattleRestrictionId>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106BCB4", Offset="0x106BCB4")]
		[FieldOffset(Offset="0x58")]
		private ulong <UnitBonusRestrictionId>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106BCC4", Offset="0x106BCC4")]
		[FieldOffset(Offset="0x60")]
		private BattleNodeOverrideDescriptor <NodeOverrideDescriptor>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106BCD4", Offset="0x106BCD4")]
		[FieldOffset(Offset="0x68")]
		private string <LogMetadataBattle>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106BCE4", Offset="0x106BCE4")]
		[FieldOffset(Offset="0x70")]
		private int <MaxUnitCount>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106BCF4", Offset="0x106BCF4")]
		[FieldOffset(Offset="0x74")]
		private int <CurrentUnitCount>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106BD04", Offset="0x106BD04")]
		[FieldOffset(Offset="0x78")]
		private string <RestrictUnitCountLocKey>k__BackingField;

		[FieldOffset(Offset="0x80")]
		private List<ulong> _squadUnitIds;

		[FieldOffset(Offset="0x88")]
		private List<ulong> _squadSpellIds;

		[FieldOffset(Offset="0x90")]
		private ulong _squadLeaderUnitId;

		[FieldOffset(Offset="0x98")]
		private ulong _squadSelectSlot;

		[FieldOffset(Offset="0xA0")]
		private ulong? _overrideSquadSelectSlot;

		public SquadSelectView.ActionMode ActionMode
		{
			[Address(RVA="0x12208A4", Offset="0x12208A4", VA="0x12208A4")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B71C", Offset="0x108B71C")]
			get
			{
				return new SquadSelectView.ActionMode();
			}
			[Address(RVA="0x1221924", Offset="0x1221924", VA="0x1221924")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B72C", Offset="0x108B72C")]
			protected set
			{
			}
		}

		public ulong BattleRestrictionId
		{
			[Address(RVA="0x122196C", Offset="0x122196C", VA="0x122196C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B7BC", Offset="0x108B7BC")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1221974", Offset="0x1221974", VA="0x1221974")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B7CC", Offset="0x108B7CC")]
			protected set
			{
			}
		}

		public int CurrentUnitCount
		{
			[Address(RVA="0x12219B4", Offset="0x12219B4", VA="0x12219B4")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B85C", Offset="0x108B85C")]
			get
			{
				return new int();
			}
			[Address(RVA="0x12219BC", Offset="0x12219BC", VA="0x12219BC")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B86C", Offset="0x108B86C")]
			protected set
			{
			}
		}

		public List<ulong> ExcludedSpells
		{
			[Address(RVA="0x122194C", Offset="0x122194C", VA="0x122194C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B77C", Offset="0x108B77C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1221954", Offset="0x1221954", VA="0x1221954")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B78C", Offset="0x108B78C")]
			protected set
			{
			}
		}

		public string ExcludedSpellsAlertKey
		{
			[Address(RVA="0x122195C", Offset="0x122195C", VA="0x122195C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B79C", Offset="0x108B79C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1221964", Offset="0x1221964", VA="0x1221964")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B7AC", Offset="0x108B7AC")]
			protected set
			{
			}
		}

		public List<ulong> ExcludedUnits
		{
			[Address(RVA="0x122192C", Offset="0x122192C", VA="0x122192C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B73C", Offset="0x108B73C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1221934", Offset="0x1221934", VA="0x1221934")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B74C", Offset="0x108B74C")]
			protected set
			{
			}
		}

		public string ExcludedUnitsAlertKey
		{
			[Address(RVA="0x122193C", Offset="0x122193C", VA="0x122193C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B75C", Offset="0x108B75C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1221944", Offset="0x1221944", VA="0x1221944")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B76C", Offset="0x108B76C")]
			protected set
			{
			}
		}

		public Gamedata.GameMode GameMode
		{
			[Address(RVA="0x121AC64", Offset="0x121AC64", VA="0x121AC64")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B6FC", Offset="0x108B6FC")]
			get
			{
				return new Gamedata.GameMode();
			}
			[Address(RVA="0x122191C", Offset="0x122191C", VA="0x122191C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B70C", Offset="0x108B70C")]
			private set
			{
			}
		}

		public string LogMetadataBattle
		{
			[Address(RVA="0x1221470", Offset="0x1221470", VA="0x1221470")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B81C", Offset="0x108B81C")]
			get
			{
				return null;
			}
			[Address(RVA="0x122199C", Offset="0x122199C", VA="0x122199C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B82C", Offset="0x108B82C")]
			protected set
			{
			}
		}

		public int MaxUnitCount
		{
			[Address(RVA="0x12219A4", Offset="0x12219A4", VA="0x12219A4")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B83C", Offset="0x108B83C")]
			get
			{
				return new int();
			}
			[Address(RVA="0x12219AC", Offset="0x12219AC", VA="0x12219AC")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B84C", Offset="0x108B84C")]
			protected set
			{
			}
		}

		public BattleNodeOverrideDescriptor NodeOverrideDescriptor
		{
			[Address(RVA="0x122198C", Offset="0x122198C", VA="0x122198C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B7FC", Offset="0x108B7FC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1221994", Offset="0x1221994", VA="0x1221994")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B80C", Offset="0x108B80C")]
			protected set
			{
			}
		}

		public virtual bool RequireFullSquadSize
		{
			[Address(RVA="0x12218F4", Offset="0x12218F4", VA="0x12218F4", Slot="4")]
			get
			{
				return new bool();
			}
		}

		public virtual bool RestrictUnitCount
		{
			[Address(RVA="0x12218FC", Offset="0x12218FC", VA="0x12218FC", Slot="5")]
			get
			{
				return new bool();
			}
		}

		public string RestrictUnitCountLocKey
		{
			[Address(RVA="0x12219C4", Offset="0x12219C4", VA="0x12219C4")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B87C", Offset="0x108B87C")]
			get
			{
				return null;
			}
			[Address(RVA="0x12219CC", Offset="0x12219CC", VA="0x12219CC")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B88C", Offset="0x108B88C")]
			protected set
			{
			}
		}

		public ulong SquadLeaderUnitId
		{
			[Address(RVA="0x1221904", Offset="0x1221904", VA="0x1221904")]
			get
			{
				return new ulong();
			}
		}

		public ulong SquadSelectSlot
		{
			[Address(RVA="0x121AC6C", Offset="0x121AC6C", VA="0x121AC6C")]
			get
			{
				return new ulong();
			}
		}

		public IReadOnlyList<ulong> SquadSpellIds
		{
			[Address(RVA="0x1221480", Offset="0x1221480", VA="0x1221480")]
			get
			{
				return null;
			}
		}

		public IReadOnlyList<ulong> SquadUnitIds
		{
			[Address(RVA="0x1221478", Offset="0x1221478", VA="0x1221478")]
			get
			{
				return null;
			}
		}

		public ulong UnitBonusRestrictionId
		{
			[Address(RVA="0x122197C", Offset="0x122197C", VA="0x122197C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B7DC", Offset="0x108B7DC")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1221984", Offset="0x1221984", VA="0x1221984")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B7EC", Offset="0x108B7EC")]
			protected set
			{
			}
		}

		public PersistedPlayerBattleUnits UnitsBattleInfo
		{
			[Address(RVA="0x122190C", Offset="0x122190C", VA="0x122190C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B6DC", Offset="0x108B6DC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1221914", Offset="0x1221914", VA="0x1221914")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B6EC", Offset="0x108B6EC")]
			protected set
			{
			}
		}

		[Address(RVA="0x12219D4", Offset="0x12219D4", VA="0x12219D4")]
		protected AContext(Gamedata.GameMode gameMode, ulong squadSelectSlot = 0L, ulong? overrideSquadSelectSlot = // 
		// Current member / type: System.Void SquadSelectGameState/AContext::.ctor(Gamedata.GameMode,System.UInt64,System.Nullable`1<System.UInt64>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void .ctor(Gamedata.GameMode,System.UInt64,System.Nullable<System.UInt64>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x12215B0", Offset="0x12215B0", VA="0x12215B0")]
		public void UpdateLeader(ulong leaderUnitId)
		{
		}

		[Address(RVA="0x122151C", Offset="0x122151C", VA="0x122151C")]
		public void UpdateSpells(IEnumerable<ulong> squadSpellIds)
		{
		}

		[Address(RVA="0x1221488", Offset="0x1221488", VA="0x1221488")]
		public void UpdateUnits(IEnumerable<ulong> squadUnitIds)
		{
		}
	}

	public class CampaignContext : SquadSelectGameState.AContext
	{
		[FieldOffset(Offset="0xB0")]
		public readonly CampaignIdentifier CampaignIdentifier;

		[Address(RVA="0x1221AC4", Offset="0x1221AC4", VA="0x1221AC4")]
		public CampaignContext(CampaignIdentifier campaignIdentifier, Serverproto.BattleNode battleNode, Gamedata.GameMode gameMode, ulong? otherDifficultyCampaignId, BattleNodeOverrideDescriptor nodeOverrideDescriptor)
		{
		}
	}

	public class ClubDungeonContext : SquadSelectGameState.AContext
	{
		[FieldOffset(Offset="0xB0")]
		public readonly string DungeonId;

		[FieldOffset(Offset="0xB8")]
		public readonly int MapIndex;

		[FieldOffset(Offset="0xBC")]
		public readonly int NodeIndex;

		[Address(RVA="0x1221BDC", Offset="0x1221BDC", VA="0x1221BDC")]
		public ClubDungeonContext(string dungeonId, int mapIndex, int nodeIndex, Serverproto.BattleNode battleNode, BattleNodeOverrideDescriptor nodeOverrideDescriptor)
		{
		}
	}

	public class ClubWarContext : SquadSelectGameState.AContext
	{
		[FieldOffset(Offset="0xB0")]
		public readonly string GdNodeId;

		[FieldOffset(Offset="0xB8")]
		public readonly string DefenseId;

		[FieldOffset(Offset="0xC0")]
		public readonly ClubWarSquad OpponentSquad;

		[FieldOffset(Offset="0xC8")]
		public readonly DClubWarTelemetryInfo TelemetryInfo;

		[FieldOffset(Offset="0xF8")]
		public readonly string OpponentClubWarTelemetryId;

		public override bool RequireFullSquadSize
		{
			[Address(RVA="0x1221CC0", Offset="0x1221CC0", VA="0x1221CC0", Slot="4")]
			get
			{
				return new bool();
			}
		}

		public override bool RestrictUnitCount
		{
			[Address(RVA="0x1221CC8", Offset="0x1221CC8", VA="0x1221CC8", Slot="5")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x1221CD0", Offset="0x1221CD0", VA="0x1221CD0")]
		public ClubWarContext(string gdNodeId, string defenseId, IReadOnlyList<ulong> usedUnitIds, IReadOnlyList<ulong> usedSpellIds, int maxNumUnits, ClubWarSquad opponentSquad, DClubWarTelemetryInfo telemetryInfo, string opponentClubWarTelemetryId)
		{
		}
	}

	public class ClubWarDefenseContext : SquadSelectGameState.AContext
	{
		[FieldOffset(Offset="0xB0")]
		public readonly string GdNodeId;

		[FieldOffset(Offset="0xB8")]
		public readonly string SquadId;

		[FieldOffset(Offset="0xC0")]
		public readonly bool ImmediateSet;

		[FieldOffset(Offset="0xC8")]
		public readonly DClubWarTelemetryInfo TelemetryInfo;

		[FieldOffset(Offset="0xF8")]
		public int NumDefensesOnNode;

		public override bool RequireFullSquadSize
		{
			[Address(RVA="0x1221EC8", Offset="0x1221EC8", VA="0x1221EC8", Slot="4")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x1221ED0", Offset="0x1221ED0", VA="0x1221ED0")]
		public ClubWarDefenseContext(DClubWarTelemetryInfo telemetryInfo, string gdNodeId = "", string squadId = "", bool immediateSet = false, IReadOnlyList<ulong> unitIds = // 
		// Current member / type: System.Void SquadSelectGameState/ClubWarDefenseContext::.ctor(DClubWarTelemetryInfo,System.String,System.String,System.Boolean,System.Collections.Generic.IReadOnlyList`1<System.UInt64>,System.Collections.Generic.IReadOnlyList`1<System.UInt64>,System.UInt64,System.Collections.Generic.IReadOnlyList`1<System.UInt64>,System.Collections.Generic.IReadOnlyList`1<System.UInt64>,System.Int32)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void .ctor(DClubWarTelemetryInfo,System.String,System.String,System.Boolean,System.Collections.Generic.IReadOnlyList<System.UInt64>,System.Collections.Generic.IReadOnlyList<System.UInt64>,System.UInt64,System.Collections.Generic.IReadOnlyList<System.UInt64>,System.Collections.Generic.IReadOnlyList<System.UInt64>,System.Int32)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com

	}

	public class EventContext : SquadSelectGameState.AContext
	{
		[FieldOffset(Offset="0xB0")]
		public readonly EventIdentifier EventId;

		[FieldOffset(Offset="0xB8")]
		public readonly ulong EntryCostItemId;

		[FieldOffset(Offset="0xC0")]
		public readonly ulong EntryCostCount;

		[FieldOffset(Offset="0xC8")]
		public readonly EventGameStateContext.EventType EventType;

		[FieldOffset(Offset="0xCC")]
		public readonly bool IsLastTier;

		[FieldOffset(Offset="0xD0")]
		public readonly uint Ruleset;

		[Address(RVA="0x12220C0", Offset="0x12220C0", VA="0x12220C0")]
		public EventContext(EventIdentifier eventId, Serverproto.BattleNode battleNode, EventGameStateContext.EventType eventType, bool isLastTier, uint ruleset)
		{
		}
	}

	public class KothContext : SquadSelectGameState.AContext
	{
		[FieldOffset(Offset="0xB0")]
		public readonly KothLobbyOpponent Opponent;

		[FieldOffset(Offset="0xB8")]
		public readonly ulong PlayerRank;

		[Address(RVA="0x1222234", Offset="0x1222234", VA="0x1222234")]
		public KothContext(ulong playerRank, KothLobbyOpponent opponent)
		{
		}
	}

	public class KothDefenseContext : SquadSelectGameState.AContext
	{
		[Address(RVA="0x12222B0", Offset="0x12222B0", VA="0x12222B0")]
		public KothDefenseContext()
		{
		}
	}

	public class PvpContext : SquadSelectGameState.AContext
	{
		[Address(RVA="0x12222E8", Offset="0x12222E8", VA="0x12222E8")]
		public PvpContext()
		{
		}
	}

	public class TowerContext : SquadSelectGameState.AContext
	{
		[FieldOffset(Offset="0xB0")]
		public readonly TowerIdentifier TowerId;

		[FieldOffset(Offset="0xB8")]
		public readonly int NodeIndex;

		public override bool RequireFullSquadSize
		{
			[Address(RVA="0x1222350", Offset="0x1222350", VA="0x1222350", Slot="4")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x1222358", Offset="0x1222358", VA="0x1222358")]
		public TowerContext(PersistedPlayerBattleUnits unitsBattleInfo, TowerIdentifier towerId, int nodeIndex, ulong battleRestrictionId)
		{
		}
	}
}