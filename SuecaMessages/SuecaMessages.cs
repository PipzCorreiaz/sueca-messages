using Thalamus;

namespace SuecaMessages
{
    public interface ISuecaPerceptions : IPerception
    {
        void SessionStart(int numGames);
        void GameStart(int gameId, int playerId, int teamId, string trump, string[] cards);
        void GameEnd(int team0Score, int team1Score);
        void SessionEnd(int team0Score, int team1Score);
        void Shuffle(int playerId);
        void Cut(int playerId);
        void Deal(int playerId);
        void ReceiveRobotCards();
        void TrickEnd(int winnerId, int trickPoints);
        void NextPlayer(int id);
        void Play(int id, string card);
        void Renounce(int playerId);
    }

    public interface ISuecaActions : IAction
    {
        void Play(int id, string card);
    }

    public interface IIAActions : IAction
    {
        void Decision(string card, string rank, string suit, string followingInfo);
        void MoveExpectations(int playerId, string desirability, string desirabilityForOther, string successProbability, string failureProbability);

        void ForwardSessionStart(int numGames);
        void ForwardGameStart(int gameId, int playerId, int teamId, string trump, string[] cards);
        void ForwardGameEnd(int team0Score, int team1Score);
        void ForwardSessionEnd(int team0Score, int team1Score);
        void ForwardShuffle(int playerId);
        void ForwardCut(int playerId);
        void ForwardDeal(int playerId);
        void ForwardReceiveRobotCards();
        void ForwardTrickEnd(int winnerId, int trickPoints);
        void ForwardNextPlayer(int id);
        void ForwardRenounce(int playerId);
    }
}
