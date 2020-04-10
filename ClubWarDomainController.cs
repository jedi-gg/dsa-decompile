using Gamedata;
using Glunies;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class ClubWarDomainController : ILoggable<LogCategory>, IDispatchHandler<DClubWarNodeTargetChangedAction>, IDispatchHandler
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1056D68", Offset="0x1056D68")]
	[FieldOffset(Offset="0x10")]
	private Gamedata.ClubWar? <Definition>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1056D78", Offset="0x1056D78")]
	[FieldOffset(Offset="0x28")]
	private bool <UsedDefenseUnitsPopulated>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1056D88", Offset="0x1056D88")]
	[FieldOffset(Offset="0x30")]
	private DClubWarTelemetryInfo <TelemetryInfo>k__BackingField;

	[FieldOffset(Offset="0x0")]
	private const float MIN_REFRESH_WAR_RATE_S = 60f;

	[Attribute(Name="InjectAttribute", RVA="0x1056D98", Offset="0x1056D98")]
	[FieldOffset(Offset="0x60")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x1056DA8", Offset="0x1056DA8")]
	[FieldOffset(Offset="0x68")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x1056DB8", Offset="0x1056DB8")]
	[FieldOffset(Offset="0x70")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x78")]
	private Serverproto.ClubWar _war;

	[FieldOffset(Offset="0x80")]
	private ClubWarTeam _localPlayerTeam;

	[FieldOffset(Offset="0x88")]
	private Dictionary<string, Serverproto.ClubWar.Types.NodeSummary> _nodeSummaryMap;

	[FieldOffset(Offset="0x90")]
	private Dictionary<string, ClubWarTeam> _clubWarTeamMapping;

	[FieldOffset(Offset="0x98")]
	private List<ulong> _usedDefenseUnitIds;

	[FieldOffset(Offset="0xA0")]
	private List<ulong> _usedDefenseSpellIds;

	public Gamedata.ClubWar? Definition
	{
		[Address(RVA="0x14CBB50", Offset="0x14CBB50", VA="0x14CBB50")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F194", Offset="0x106F194")]
		get
		{
			return null;
		}
		[Address(RVA="0x14CBB64", Offset="0x14CBB64", VA="0x14CBB64")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F1A4", Offset="0x106F1A4")]
		private set
		{
		}
	}

	public bool IsPlayerParticipating
	{
		[Address(RVA="0x14CBB78", Offset="0x14CBB78", VA="0x14CBB78")]
		get
		{
			return new bool();
		}
	}

	public ClubWarTeam LocalPlayerTeam
	{
		[Address(RVA="0x14CBD0C", Offset="0x14CBD0C", VA="0x14CBD0C")]
		get
		{
			return new ClubWarTeam();
		}
	}

	public LogCategory LogCategory
	{
		[Address(RVA="0x14CBB48", Offset="0x14CBB48", VA="0x14CBB48", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	public ClubWarPlayerState PlayerState
	{
		[Address(RVA="0x14CBBA0", Offset="0x14CBBA0", VA="0x14CBBA0")]
		get
		{
			return null;
		}
	}

	public float RefreshWarRateS
	{
		[Address(RVA="0x14CBBD8", Offset="0x14CBBD8", VA="0x14CBBD8")]
		get
		{
			return new float();
		}
	}

	public DClubWarTelemetryInfo TelemetryInfo
	{
		[Address(RVA="0x14CBD14", Offset="0x14CBD14", VA="0x14CBD14")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F1D4", Offset="0x106F1D4")]
		get
		{
			return new DClubWarTelemetryInfo();
		}
		[Address(RVA="0x14CBD30", Offset="0x14CBD30", VA="0x14CBD30")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F1E4", Offset="0x106F1E4")]
		private set
		{
		}
	}

	public List<ulong> UsedDefenseSpellIds
	{
		[Address(RVA="0x14CBBD0", Offset="0x14CBBD0", VA="0x14CBBD0")]
		get
		{
			return null;
		}
	}

	public List<ulong> UsedDefenseUnitIds
	{
		[Address(RVA="0x14CBBC8", Offset="0x14CBBC8", VA="0x14CBBC8")]
		get
		{
			return null;
		}
	}

	public bool UsedDefenseUnitsPopulated
	{
		[Address(RVA="0x14CBBB4", Offset="0x14CBBB4", VA="0x14CBBB4")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F1B4", Offset="0x106F1B4")]
		get
		{
			return new bool();
		}
		[Address(RVA="0x14CBBBC", Offset="0x14CBBBC", VA="0x14CBBBC")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F1C4", Offset="0x106F1C4")]
		private set
		{
		}
	}

	public ulong WarStartTime
	{
		[Address(RVA="0x14CAA3C", Offset="0x14CAA3C", VA="0x14CAA3C")]
		get
		{
			return new ulong();
		}
	}

	[Address(RVA="0x14CEF78", Offset="0x14CEF78", VA="0x14CEF78")]
	public ClubWarDomainController()
	{
	}

	[Address(RVA="0x14CAA50", Offset="0x14CAA50", VA="0x14CAA50")]
	public void AddRegisteredPlayer(string playerId)
	{
	}

	[Address(RVA="0x14CC4E8", Offset="0x14CC4E8", VA="0x14CC4E8")]
	public bool AllowViewAllClubSquads()
	{
		return new bool();
	}

	[Address(RVA="0x14CBE48", Offset="0x14CBE48", VA="0x14CBE48")]
	private void BuildTelemetryInfo(TelemetryTranslator telemetryTranslator)
	{
	}

	[Address(RVA="0x14CCD08", Offset="0x14CCD08", VA="0x14CCD08")]
	public bool CanAttack(out string errorLocKey, string nodeId, ClubWarNodeDetailResponse nodeDetail, string squadId = // 
	// Current member / type: System.Boolean ClubWarDomainController::CanAttack(System.String&,System.String,Serverproto.ClubWarNodeDetailResponse,System.String)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Boolean CanAttack(System.String&,System.String,Serverproto.ClubWarNodeDetailResponse,System.String)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x14CD50C", Offset="0x14CD50C", VA="0x14CD50C")]
	public bool CanCapture(string nodeId, ClubWarNodeDetailResponse nodeDetail)
	{
		return new bool();
	}

	[Address(RVA="0x14CE044", Offset="0x14CE044", VA="0x14CE044")]
	public bool CanMoveSquad(ClubWarSquad squad)
	{
		return new bool();
	}

	[Address(RVA="0x14CD5F4", Offset="0x14CD5F4", VA="0x14CD5F4")]
	public bool CanTarget(ClubWarNodeDetailResponse nodeDetail)
	{
		return new bool();
	}

	[Address(RVA="0x14CD95C", Offset="0x14CD95C", VA="0x14CD95C")]
	public void ConnectedNodesOwnedByTeam(string nodeId, ClubWarTeam teamId, ref HashSet<string> connectedNodes)
	{
	}

	[Address(RVA="0x14CC120", Offset="0x14CC120", VA="0x14CC120")]
	public ClubWarPhase? CurrentPhase()
	{
		return null;
	}

	[Address(RVA="0x14CC418", Offset="0x14CC418", VA="0x14CC418")]
	public DateTime CurrentPhaseEndTime()
	{
		return new DateTime();
	}

	[Address(RVA="0x14CC364", Offset="0x14CC364", VA="0x14CC364")]
	public ClubWarPhaseType CurrentPhaseType()
	{
		return new ClubWarPhaseType();
	}

	[Address(RVA="0x14CC8A8", Offset="0x14CC8A8", VA="0x14CC8A8")]
	public ClubWarClub GetClubForTeam(ClubWarTeam team)
	{
		return null;
	}

	[Address(RVA="0x14CCB6C", Offset="0x14CCB6C", VA="0x14CCB6C")]
	public string GetClubIdForTeam(ClubWarTeam team)
	{
		return null;
	}

	[Address(RVA="0x14CC700", Offset="0x14CC700", VA="0x14CC700")]
	public ClubWarNode? GetNodeDefinition(string nodeId)
	{
		return null;
	}

	[Address(RVA="0x14CE9C8", Offset="0x14CE9C8", VA="0x14CE9C8")]
	public int GetNodeSortOrder(string nodeId)
	{
		return new int();
	}

	[Address(RVA="0x14CC508", Offset="0x14CC508", VA="0x14CC508")]
	public Serverproto.ClubWar.Types.NodeSummary GetNodeSummary(string nodeId)
	{
		return null;
	}

	[Address(RVA="0x14CDFB0", Offset="0x14CDFB0", VA="0x14CDFB0")]
	public string GetNodeTarget()
	{
		return null;
	}

	[Address(RVA="0x14CDECC", Offset="0x14CDECC", VA="0x14CDECC")]
	public RepeatedField<string> GetRegisteredPlayers()
	{
		return null;
	}

	[Address(RVA="0x14CBDB4", Offset="0x14CBDB4", VA="0x14CBDB4")]
	public ClubWarTeam GetTeamFromClubId(string clubId)
	{
		return new ClubWarTeam();
	}

	[Address(RVA="0x14CE934", Offset="0x14CE934", VA="0x14CE934", Slot="5")]
	public void HandleDispatchAction(DClubWarNodeTargetChangedAction action)
	{
	}

	[Address(RVA="0x14CBD44", Offset="0x14CBD44", VA="0x14CBD44")]
	public void Initialize()
	{
	}

	[Address(RVA="0x14CE1C0", Offset="0x14CE1C0", VA="0x14CE1C0")]
	public bool IsFogEnabled()
	{
		return new bool();
	}

	[Address(RVA="0x14CCBD0", Offset="0x14CCBD0", VA="0x14CCBD0")]
	public bool IsNodeOwnedByClub(string nodeId, string clubId)
	{
		return new bool();
	}

	[Address(RVA="0x14CEB58", Offset="0x14CEB58", VA="0x14CEB58")]
	public bool IsNodeOwnedByValidTeam(ClubWarNodeDetailResponse nodeDetail)
	{
		return new bool();
	}

	[Address(RVA="0x14CCC24", Offset="0x14CCC24", VA="0x14CCC24")]
	public bool IsNodeRebuilding(string nodeId)
	{
		return new bool();
	}

	[Address(RVA="0x14CEC2C", Offset="0x14CEC2C", VA="0x14CEC2C")]
	public void LocallyModifyNodeSummary(Serverproto.ClubWar.Types.NodeSummary nodeSummary)
	{
	}

	[Address(RVA="0x14CED64", Offset="0x14CED64", VA="0x14CED64")]
	public void LocallyModifyNodeSummaryFromNodeDetail(string nodeId, ClubWarNodeDetailResponse nodeDetail)
	{
	}

	[Address(RVA="0x14CDEFC", Offset="0x14CDEFC", VA="0x14CDEFC")]
	public int MaxDefenseCommited()
	{
		return new int();
	}

	[Address(RVA="0x14CC23C", Offset="0x14CC23C", VA="0x14CC23C")]
	public ClubWarPhase? NextPhase()
	{
		return null;
	}

	[Address(RVA="0x14CD640", Offset="0x14CD640", VA="0x14CD640")]
	public int NumNodesOwnedByTeam(ClubWarTeam teamId)
	{
		return new int();
	}

	[Address(RVA="0x14CDBE0", Offset="0x14CDBE0", VA="0x14CDBE0")]
	public float PointsPerSecond(ClubWarTeam teamId, out bool bonusEnabled)
	{
		bonusEnabled = false;
		return new float();
	}

	[Address(RVA="0x14CE1E4", Offset="0x14CE1E4", VA="0x14CE1E4")]
	public void PopulateUsedDefenseUnits(List<ClubWarSquad> allClubSquads)
	{
	}

	[Address(RVA="0x14CC034", Offset="0x14CC034", VA="0x14CC034")]
	public void ReleaseWarData()
	{
	}

	[Address(RVA="0x14CEBA4", Offset="0x14CEBA4", VA="0x14CEBA4")]
	public void RemoveRegisteredPlayer(string playerId)
	{
	}

	[Address(RVA="0x14CB40C", Offset="0x14CB40C", VA="0x14CB40C")]
	public void SetWar(Serverproto.ClubWar war, TelemetryTranslator telemetryTranslator)
	{
	}

	[Address(RVA="0x14CBD7C", Offset="0x14CBD7C", VA="0x14CBD7C")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x14CD2E4", Offset="0x14CD2E4", VA="0x14CD2E4")]
	public bool TeamOwnsAdjacentNode(ClubWarTeam team, string nodeId)
	{
		return new bool();
	}
}