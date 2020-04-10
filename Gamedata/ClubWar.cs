using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ClubWar : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public int AdditionalPointsForBasesControlled
		{
			[Address(RVA="0xF43C70", Offset="0xF43C70", VA="0xF43C70")]
			get
			{
				return new int();
			}
		}

		public int BasesControlledThresholdForAdditionalPoints
		{
			[Address(RVA="0xF43C68", Offset="0xF43C68", VA="0xF43C68")]
			get
			{
				return new int();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF43B84", Offset="0xF43B84", VA="0xF43B84", Slot="5")]
			get
			{
				return null;
			}
		}

		public int EdgesLength
		{
			[Address(RVA="0xF43BE8", Offset="0xF43BE8", VA="0xF43BE8")]
			get
			{
				return new int();
			}
		}

		public int FinalPhaseDurationM
		{
			[Address(RVA="0xF43BC8", Offset="0xF43BC8", VA="0xF43BC8")]
			get
			{
				return new int();
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF43BB0", Offset="0xF43BB0", VA="0xF43BB0")]
			get
			{
				return new ulong();
			}
		}

		public uint InBattleTimeoutSeconds
		{
			[Address(RVA="0xF43C48", Offset="0xF43C48", VA="0xF43C48")]
			get
			{
				return new uint();
			}
		}

		public string MapScene
		{
			[Address(RVA="0xF43C10", Offset="0xF43C10", VA="0xF43C10")]
			get
			{
				return null;
			}
		}

		public int MaxAttackUnits
		{
			[Address(RVA="0xF43C58", Offset="0xF43C58", VA="0xF43C58")]
			get
			{
				return new int();
			}
		}

		public int MaxDefensesCommitted
		{
			[Address(RVA="0xF43C28", Offset="0xF43C28", VA="0xF43C28")]
			get
			{
				return new int();
			}
		}

		public int MinClubMembers
		{
			[Address(RVA="0xF43BF8", Offset="0xF43BF8", VA="0xF43BF8")]
			get
			{
				return new int();
			}
		}

		public int NodeRebuildDurationS
		{
			[Address(RVA="0xF43C50", Offset="0xF43C50", VA="0xF43C50")]
			get
			{
				return new int();
			}
		}

		public int NodesLength
		{
			[Address(RVA="0xF43BD8", Offset="0xF43BD8", VA="0xF43BD8")]
			get
			{
				return new int();
			}
		}

		public int OccasionRefsLength
		{
			[Address(RVA="0xF43C08", Offset="0xF43C08", VA="0xF43C08")]
			get
			{
				return new int();
			}
		}

		public int PhasesLength
		{
			[Address(RVA="0xF43BC0", Offset="0xF43BC0", VA="0xF43BC0")]
			get
			{
				return new int();
			}
		}

		public int PointsForSuccessfulAttack
		{
			[Address(RVA="0xF43C78", Offset="0xF43C78", VA="0xF43C78")]
			get
			{
				return new int();
			}
		}

		public int PointsForSuccessfulDefense
		{
			[Address(RVA="0xF43C80", Offset="0xF43C80", VA="0xF43C80")]
			get
			{
				return new int();
			}
		}

		public int PointsPerBasePerTimeUnit
		{
			[Address(RVA="0xF43C60", Offset="0xF43C60", VA="0xF43C60")]
			get
			{
				return new int();
			}
		}

		public int PointTickFrequencyS
		{
			[Address(RVA="0xF43BF0", Offset="0xF43BF0", VA="0xF43BF0")]
			get
			{
				return new int();
			}
		}

		public ulong RewardsFirstPlace
		{
			[Address(RVA="0xF43C30", Offset="0xF43C30", VA="0xF43C30")]
			get
			{
				return new ulong();
			}
		}

		public ulong RewardsInboxMessageFirstPlace
		{
			[Address(RVA="0xF43C90", Offset="0xF43C90", VA="0xF43C90")]
			get
			{
				return new ulong();
			}
		}

		public ulong RewardsInboxMessageSecondPlace
		{
			[Address(RVA="0xF43C98", Offset="0xF43C98", VA="0xF43C98")]
			get
			{
				return new ulong();
			}
		}

		public ulong RewardsInboxMessageThirdPlace
		{
			[Address(RVA="0xF43CA0", Offset="0xF43CA0", VA="0xF43CA0")]
			get
			{
				return new ulong();
			}
		}

		public ulong RewardsSecondPlace
		{
			[Address(RVA="0xF43C38", Offset="0xF43C38", VA="0xF43C38")]
			get
			{
				return new ulong();
			}
		}

		public ulong RewardsThirdPlace
		{
			[Address(RVA="0xF43C40", Offset="0xF43C40", VA="0xF43C40")]
			get
			{
				return new ulong();
			}
		}

		public int WinConditionPointThreshold
		{
			[Address(RVA="0xF43C88", Offset="0xF43C88", VA="0xF43C88")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF43B98", Offset="0xF43B98", VA="0xF43B98")]
		public ClubWar __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ClubWar();
		}

		[Address(RVA="0xF43B8C", Offset="0xF43B8C", VA="0xF43B8C", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x23249C8", Offset="0x23249C8", VA="0x23249C8")]
		public static void AddAdditionalPointsForBasesControlled(FlatBufferBuilder builder, int additionalPointsForBasesControlled)
		{
		}

		[Address(RVA="0x2324A04", Offset="0x2324A04", VA="0x2324A04")]
		public static void AddBasesControlledThresholdForAdditionalPoints(FlatBufferBuilder builder, int basesControlledThresholdForAdditionalPoints)
		{
		}

		[Address(RVA="0x2324C5C", Offset="0x2324C5C", VA="0x2324C5C")]
		public static void AddEdges(FlatBufferBuilder builder, VectorOffset edgesOffset)
		{
		}

		[Address(RVA="0x2324CD4", Offset="0x2324CD4", VA="0x2324CD4")]
		public static void AddFinalPhaseDurationM(FlatBufferBuilder builder, int finalPhaseDurationM)
		{
		}

		[Address(RVA="0x23248D8", Offset="0x23248D8", VA="0x23248D8")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x2324AF4", Offset="0x2324AF4", VA="0x2324AF4")]
		public static void AddInBattleTimeoutSeconds(FlatBufferBuilder builder, uint inBattleTimeoutSeconds)
		{
		}

		[Address(RVA="0x2324B6C", Offset="0x2324B6C", VA="0x2324B6C")]
		public static void AddMapScene(FlatBufferBuilder builder, StringOffset mapSceneOffset)
		{
		}

		[Address(RVA="0x2324A7C", Offset="0x2324A7C", VA="0x2324A7C")]
		public static void AddMaxAttackUnits(FlatBufferBuilder builder, int maxAttackUnits)
		{
		}

		[Address(RVA="0x2324B30", Offset="0x2324B30", VA="0x2324B30")]
		public static void AddMaxDefensesCommitted(FlatBufferBuilder builder, int maxDefensesCommitted)
		{
		}

		[Address(RVA="0x2324BE4", Offset="0x2324BE4", VA="0x2324BE4")]
		public static void AddMinClubMembers(FlatBufferBuilder builder, int minClubMembers)
		{
		}

		[Address(RVA="0x2324AB8", Offset="0x2324AB8", VA="0x2324AB8")]
		public static void AddNodeRebuildDurationS(FlatBufferBuilder builder, int nodeRebuildDurationS)
		{
		}

		[Address(RVA="0x2324C98", Offset="0x2324C98", VA="0x2324C98")]
		public static void AddNodes(FlatBufferBuilder builder, VectorOffset nodesOffset)
		{
		}

		[Address(RVA="0x2324BA8", Offset="0x2324BA8", VA="0x2324BA8")]
		public static void AddOccasionRefs(FlatBufferBuilder builder, VectorOffset occasionRefsOffset)
		{
		}

		[Address(RVA="0x2324D10", Offset="0x2324D10", VA="0x2324D10")]
		public static void AddPhases(FlatBufferBuilder builder, VectorOffset phasesOffset)
		{
		}

		[Address(RVA="0x232498C", Offset="0x232498C", VA="0x232498C")]
		public static void AddPointsForSuccessfulAttack(FlatBufferBuilder builder, int pointsForSuccessfulAttack)
		{
		}

		[Address(RVA="0x2324950", Offset="0x2324950", VA="0x2324950")]
		public static void AddPointsForSuccessfulDefense(FlatBufferBuilder builder, int pointsForSuccessfulDefense)
		{
		}

		[Address(RVA="0x2324A40", Offset="0x2324A40", VA="0x2324A40")]
		public static void AddPointsPerBasePerTimeUnit(FlatBufferBuilder builder, int pointsPerBasePerTimeUnit)
		{
		}

		[Address(RVA="0x2324C20", Offset="0x2324C20", VA="0x2324C20")]
		public static void AddPointTickFrequencyS(FlatBufferBuilder builder, int pointTickFrequencyS)
		{
		}

		[Address(RVA="0x232489C", Offset="0x232489C", VA="0x232489C")]
		public static void AddRewardsFirstPlace(FlatBufferBuilder builder, ulong rewardsFirstPlace)
		{
		}

		[Address(RVA="0x23247E8", Offset="0x23247E8", VA="0x23247E8")]
		public static void AddRewardsInboxMessageFirstPlace(FlatBufferBuilder builder, ulong rewardsInboxMessageFirstPlace)
		{
		}

		[Address(RVA="0x23247AC", Offset="0x23247AC", VA="0x23247AC")]
		public static void AddRewardsInboxMessageSecondPlace(FlatBufferBuilder builder, ulong rewardsInboxMessageSecondPlace)
		{
		}

		[Address(RVA="0x2324770", Offset="0x2324770", VA="0x2324770")]
		public static void AddRewardsInboxMessageThirdPlace(FlatBufferBuilder builder, ulong rewardsInboxMessageThirdPlace)
		{
		}

		[Address(RVA="0x2324860", Offset="0x2324860", VA="0x2324860")]
		public static void AddRewardsSecondPlace(FlatBufferBuilder builder, ulong rewardsSecondPlace)
		{
		}

		[Address(RVA="0x2324824", Offset="0x2324824", VA="0x2324824")]
		public static void AddRewardsThirdPlace(FlatBufferBuilder builder, ulong rewardsThirdPlace)
		{
		}

		[Address(RVA="0x2324914", Offset="0x2324914", VA="0x2324914")]
		public static void AddWinConditionPointThreshold(FlatBufferBuilder builder, int winConditionPointThreshold)
		{
		}

		[Address(RVA="0x232454C", Offset="0x232454C", VA="0x232454C")]
		public static Offset<ClubWar> CreateClubWar(FlatBufferBuilder builder, ulong id = 0L, VectorOffset phasesOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.ClubWar> Gamedata.ClubWar::CreateClubWar(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset,System.Int32,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,System.Int32,System.Int32,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,System.Int32,System.UInt64,System.UInt64,System.UInt64,System.UInt32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.UInt64,System.UInt64,System.UInt64)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.ClubWar> CreateClubWar(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset,System.Int32,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,System.Int32,System.Int32,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,System.Int32,System.UInt64,System.UInt64,System.UInt64,System.UInt32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.UInt64,System.UInt64,System.UInt64)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2325064", Offset="0x2325064", VA="0x2325064")]
		public static VectorOffset CreateEdgesVector(FlatBufferBuilder builder, Offset<ClubWarEdge>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x2324F30", Offset="0x2324F30", VA="0x2324F30")]
		public static VectorOffset CreateNodesVector(FlatBufferBuilder builder, Offset<ClubWarNode>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x2325198", Offset="0x2325198", VA="0x2325198")]
		public static VectorOffset CreateOccasionRefsVector(FlatBufferBuilder builder, Offset<OccasionRef>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x2324DFC", Offset="0x2324DFC", VA="0x2324DFC")]
		public static VectorOffset CreatePhasesVector(FlatBufferBuilder builder, Offset<ClubWarPhase>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0xF43BE0", Offset="0xF43BE0", VA="0xF43BE0")]
		public ClubWarEdge? Edges(int j)
		{
			return null;
		}

		[Address(RVA="0x2324D4C", Offset="0x2324D4C", VA="0x2324D4C")]
		public static Offset<ClubWar> EndClubWar(FlatBufferBuilder builder)
		{
			return new Offset<ClubWar>();
		}

		[Address(RVA="0x23252CC", Offset="0x23252CC", VA="0x23252CC")]
		public static void FinishClubWarBuffer(FlatBufferBuilder builder, Offset<ClubWar> offset)
		{
		}

		[Address(RVA="0xF43C18", Offset="0xF43C18", VA="0xF43C18")]
		public ArraySegment<byte>? GetMapSceneBytes()
		{
			return null;
		}

		[Address(RVA="0x2323758", Offset="0x2323758", VA="0x2323758")]
		public static ClubWar GetRootAsClubWar(FlatBuffers.ByteBuffer _bb)
		{
			return new ClubWar();
		}

		[Address(RVA="0x2323764", Offset="0x2323764", VA="0x2323764")]
		public static ClubWar GetRootAsClubWar(FlatBuffers.ByteBuffer _bb, ClubWar obj)
		{
			return new ClubWar();
		}

		[Address(RVA="0xF43BD0", Offset="0xF43BD0", VA="0xF43BD0")]
		public ClubWarNode? Nodes(int j)
		{
			return null;
		}

		[Address(RVA="0xF43C00", Offset="0xF43C00", VA="0xF43C00")]
		public OccasionRef? OccasionRefs(int j)
		{
			return null;
		}

		[Address(RVA="0xF43BB8", Offset="0xF43BB8", VA="0xF43BB8")]
		public ClubWarPhase? Phases(int j)
		{
			return null;
		}

		[Address(RVA="0x2324DCC", Offset="0x2324DCC", VA="0x2324DCC")]
		public static void StartClubWar(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x232515C", Offset="0x232515C", VA="0x232515C")]
		public static void StartEdgesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x2325028", Offset="0x2325028", VA="0x2325028")]
		public static void StartNodesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x2325290", Offset="0x2325290", VA="0x2325290")]
		public static void StartOccasionRefsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x2324EF4", Offset="0x2324EF4", VA="0x2324EF4")]
		public static void StartPhasesVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}