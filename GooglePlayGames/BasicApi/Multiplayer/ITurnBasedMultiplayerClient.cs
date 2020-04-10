using GooglePlayGames.BasicApi;
using System;

namespace GooglePlayGames.BasicApi.Multiplayer
{
	public interface ITurnBasedMultiplayerClient
	{
		void AcceptFromInbox(Action<bool, TurnBasedMatch> callback);

		void AcceptInvitation(string invitationId, Action<bool, TurnBasedMatch> callback);

		void AcknowledgeFinished(TurnBasedMatch match, Action<bool> callback);

		void Cancel(TurnBasedMatch match, Action<bool> callback);

		void CreateQuickMatch(uint minOpponents, uint maxOpponents, uint variant, Action<bool, TurnBasedMatch> callback);

		void CreateQuickMatch(uint minOpponents, uint maxOpponents, uint variant, ulong exclusiveBitmask, Action<bool, TurnBasedMatch> callback);

		void CreateWithInvitationScreen(uint minOpponents, uint maxOpponents, uint variant, Action<bool, TurnBasedMatch> callback);

		void CreateWithInvitationScreen(uint minOpponents, uint maxOpponents, uint variant, Action<UIStatus, TurnBasedMatch> callback);

		void DeclineInvitation(string invitationId);

		void Dismiss(TurnBasedMatch match);

		void Finish(TurnBasedMatch match, byte[] data, MatchOutcome outcome, Action<bool> callback);

		void GetAllInvitations(Action<Invitation[]> callback);

		void GetAllMatches(Action<TurnBasedMatch[]> callback);

		void GetMatch(string matchId, Action<bool, TurnBasedMatch> callback);

		int GetMaxMatchDataSize();

		void Leave(TurnBasedMatch match, Action<bool> callback);

		void LeaveDuringTurn(TurnBasedMatch match, string pendingParticipantId, Action<bool> callback);

		void RegisterMatchDelegate(MatchDelegate del);

		void Rematch(TurnBasedMatch match, Action<bool, TurnBasedMatch> callback);

		void TakeTurn(TurnBasedMatch match, byte[] data, string pendingParticipantId, Action<bool> callback);
	}
}