using Thalamus;

namespace SuecaMessages
{
    public interface ISuecaPerceptions : IPerception
    {
        void SessionStart(int numGames, int[] agentsIds, int talkingRobot);
        void GameStart(int gameId, int playerId, int teamId, string trumpCard, int trumpCardPlayer, string[] cards, int talkingRobot);
        void GameEnd(int team0Score, int team1Score, int talkingRobot);
        void SessionEnd(int team0Score, int team1Score, int talkingRobot);
        void Shuffle(int playerId, int talkingRobot);
        void Cut(int playerId, int talkingRobot);
        void Deal(int playerId, int talkingRobot);
        void TrumpCard(string trumpCard, int trumpCardPlayer, int talkingRobot);
        void ReceiveRobotCards(int playerId, int talkingRobot);
        void TrickEnd(int winnerId, int trickPoints, int talkingRobot);
        void NextPlayer(int id, int talkingRobot);
        void Play(int id, string card, int talkingRobot);
        void Renounce(int playerId, int talkingRobot);
        void ResetTrick(int talkingRobot);
    }

    public interface ISuecaActions : IAction
    {
        void Play(int id, string card);
    }

    public interface IRobotPerceptions : IAction
    {
        void StartedUtterance(int playerId, string category, string subcategory);
        void FinishedUtterance(int playerId);
    }

    public interface IIAActions : IAction
    {
        void Decision(string card, string rank, string suit, string followingInfo);
        void MoveExpectations(int playerId, string desirability, string desirabilityForOther, string successProbability, string failureProbability);

        void ForwardSessionStart(int numGames, int talkingRobot);
        void ForwardGameStart(int gameId, int playerId, int teamId, string trumpCard, int trumpCardPlayer, string[] cards, int talkingRobot);
        void ForwardGameEnd(int team0Score, int team1Score, int talkingRobot);
        void ForwardSessionEnd(int team0Score, int team1Score, int talkingRobot);
        void ForwardShuffle(int playerId, int talkingRobot);
        void ForwardCut(int playerId, int talkingRobot);
        void ForwardDeal(int playerId, int talkingRobot);
        void ForwardTrumpCard(string trumpCard, int trumpCardPlayer, int talkingRobot);
        void ForwardReceiveRobotCards(int playerId, int talkingRobot);
        void ForwardTrickEnd(int winnerId, int trickPoints, int talkingRobot);
        void ForwardNextPlayer(int id, int talkingRobot);
        void ForwardRenounce(int playerId, int talkingRobot);
        void ForwardResetTrick(int talkingRobot);
    }
}
