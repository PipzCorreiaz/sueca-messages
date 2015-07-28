using System;
using Thalamus;

namespace SuecaMessages
{
    public interface ISuecaPerceptions : Thalamus.IPerception
    {
        void GameStart(int id, int teamId, string trump, string[] cards);
        void GameEnd(int team0Score, int team1Score);
        void NextPlayer(int id);
        void Play(int id, string card);
    }

    public interface ISuecaActions : Thalamus.IAction
    {
        void Play(int id, string card);
    }

    public interface IIAActions : Thalamus.IAction
    {
        void Decision(string card);
        void ExpectedScore(int team0Score, int team1Score);
    }
}
