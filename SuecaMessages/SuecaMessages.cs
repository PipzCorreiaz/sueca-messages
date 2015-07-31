using Thalamus;

namespace SuecaMessages
{
    public interface ISuecaPerceptions : IPerception
    {
        void GameStart(int id, int teamId, string trump, string[] cards);
        void GameEnd(int team0Score, int team1Score);
        void NextPlayer(int id);
        void Play(int id, string card);
    }

    public interface ISuecaActions : IAction
    {
        void Play(int id, string card);
    }

    public interface IIAActions : IAction
    {
        void Decision(string card);
        void ExpectedScores(int team0Score, int team1Score);
    }
}
