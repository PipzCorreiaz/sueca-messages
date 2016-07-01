using Thalamus;

namespace SuecaMessages
{
    public interface ISuecaPerceptions : IPerception
    {
        void SessionStart(int sessionId, int numGames, int[] agentsIds, int shouldGreet);
        void GameStart(int gameId, int playerId, int teamId, string trumpCard, int trumpCardPlayer, string[] cards);
        void GameEnd(int team0Score, int team1Score);
        void SessionEnd(int sessionId, int team0Score, int team1Score);
        void Shuffle(int playerId);
        void Cut(int playerId);
        void Deal(int playerId);
        void TrumpCard(string trumpCard, int trumpCardPlayer);
        void ReceiveRobotCards(int playerId);
        void TrickEnd(int winnerId, int trickPoints);
        void NextPlayer(int id);
        void Play(int id, string card);
        void Renounce(int playerId);
        void ResetTrick();
    }

    public interface ISuecaActions : IAction
    {
        void Play(int id, string card);
    }

    public interface IRobotPerceptions : IAction
    {
        void RequestUtterance(int playerId, string category, string subcategory);
        void OKUtterance(int playerId);
        void NOUtterance(int playerId);
        void StartedUtterance(int playerId, string category, string subcategory);
        void FinishedUtterance(int playerId);
    }

    public interface IIAActions : IAction
    {
        void Decision(string card, string rank, string suit, string followingInfo);
        void MoveExpectations(int playerId, string desirability, string desirabilityForOther, string successProbability, string failureProbability, string additionalInfo);

        void ForwardSessionStart(int sessionId, int numGames, int numRobots, int playerId, int shouldGreet);
        void ForwardGameStart(int gameId, int playerId, int teamId, string trumpCard, int trumpCardPlayer, string[] cards);
        void ForwardGameEnd(int team0Score, int team1Score);
        void ForwardSessionEnd(int sessionId, int team0Score, int team1Score);
        void ForwardShuffle(int playerId);
        void ForwardCut(int playerId);
        void ForwardDeal(int playerId);
        void ForwardTrumpCard(string trumpCard, int trumpCardPlayer);
        void ForwardReceiveRobotCards(int playerId);
        void ForwardTrickEnd(int winnerId, int trickPoints);
        void ForwardNextPlayer(int id);
        void ForwardRenounce(int playerId);
        void ForwardResetTrick();
    }
}
