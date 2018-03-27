using Thalamus;

namespace SuecaMessages
{
    public interface ISuecaPerceptions : IPerception
    {
        void SessionStart(int sessionId, int numGames, int[] agentsIds, int floorId);
        void GameStart(int gameId, int playerId, int teamId, string trumpCard, int trumpCardPlayer, string[] cards, string partnerName, int floorId);
        void GameEnd(int team0Score, int team1Score, int floorId);
        void SessionEnd(int sessionId, int team0Score, int team1Score, int floorId);
        void Shuffle(int playerId, int floorId);
        void Cut(int playerId, int floorId);
        void Deal(int playerId, int floorId);
        void TrumpCard(string trumpCard, int trumpCardPlayer, int floorId);
        void ReceiveRobotCards(int playerId, int floorId);
        void TrickEnd(int winnerId, int trickPoints, int floorId);
        void NextPlayer(int id, int floorId);
        void Play(int id, string card, string playInfo, int floorId);
        void Renounce(int playerId, int floorId);
    }

    public interface ISuecaActions : IAction
    {
        void Play(int id, string card, string playInfo);
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
