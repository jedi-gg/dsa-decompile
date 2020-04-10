using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Multiplayer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace GooglePlayGames.Android
{
	internal class AndroidJavaConverter
	{
		[Address(RVA="0x162C3D0", Offset="0x162C3D0", VA="0x162C3D0")]
		public AndroidJavaConverter()
		{
		}

		[Address(RVA="0x162B75C", Offset="0x162B75C", VA="0x162B75C")]
		internal static Invitation.InvType FromInvitationType(int invitationTypeJava)
		{
			return new Invitation.InvType();
		}

		[Address(RVA="0x162B770", Offset="0x162B770", VA="0x162B770")]
		internal static Participant.ParticipantStatus FromParticipantStatus(int participantStatusJava)
		{
			return new Participant.ParticipantStatus();
		}

		[Address(RVA="0x16212A0", Offset="0x16212A0", VA="0x16212A0")]
		internal static DateTime ToDateTime(long milliseconds)
		{
			return new DateTime();
		}

		[Address(RVA="0x16251A0", Offset="0x16251A0", VA="0x16251A0")]
		internal static Invitation ToInvitation(AndroidJavaObject invitation)
		{
			return null;
		}

		[Address(RVA="0x162C22C", Offset="0x162C22C", VA="0x162C22C")]
		internal static AndroidJavaObject ToJavaStringList(List<string> list)
		{
			return null;
		}

		[Address(RVA="0x161FFC4", Offset="0x161FFC4", VA="0x161FFC4")]
		internal static int ToLeaderboardVariantCollection(LeaderboardCollection collection)
		{
			return new int();
		}

		[Address(RVA="0x161FF94", Offset="0x161FF94", VA="0x161FF94")]
		internal static int ToLeaderboardVariantTimeSpan(LeaderboardTimeSpan span)
		{
			return new int();
		}

		[Address(RVA="0x162C000", Offset="0x162C000", VA="0x162C000")]
		internal static TurnBasedMatch.MatchStatus ToMatchStatus(int matchStatus)
		{
			return new TurnBasedMatch.MatchStatus();
		}

		[Address(RVA="0x162C020", Offset="0x162C020", VA="0x162C020")]
		internal static TurnBasedMatch.MatchTurnStatus ToMatchTurnStatus(int matchTurnStatus)
		{
			return new TurnBasedMatch.MatchTurnStatus();
		}

		[Address(RVA="0x162049C", Offset="0x162049C", VA="0x162049C")]
		internal static int ToPageDirection(ScorePageDirection direction)
		{
			return new int();
		}

		[Address(RVA="0x162B780", Offset="0x162B780", VA="0x162B780")]
		internal static Participant ToParticipant(AndroidJavaObject participant)
		{
			return null;
		}

		[Address(RVA="0x162BAF0", Offset="0x162BAF0", VA="0x162BAF0")]
		internal static List<Participant> ToParticipantList(AndroidJavaObject turnBasedMatch)
		{
			return null;
		}

		[Address(RVA="0x1625094", Offset="0x1625094", VA="0x1625094")]
		internal static Player ToPlayer(AndroidJavaObject player)
		{
			return null;
		}

		[Address(RVA="0x162C040", Offset="0x162C040", VA="0x162C040")]
		internal static List<string> ToStringList(AndroidJavaObject stringList)
		{
			return null;
		}

		[Address(RVA="0x1625460", Offset="0x1625460", VA="0x1625460")]
		internal static TurnBasedMatch ToTurnBasedMatch(AndroidJavaObject turnBasedMatch)
		{
			return null;
		}
	}
}