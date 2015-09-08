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
        void NextPlayer(int id);
        void Play(int id, string card);
    }

    public interface ISuecaActions : IAction
    {
        void Play(int id, string card);
    }

    public interface IIAActions : IAction
    {
        void Decision(string card, string followingInfo);
        void Expectation(string successProbability, string failureProbability);
        void MoveDesirabilities(string desirability, string desirabilityForOther);
    }
}
