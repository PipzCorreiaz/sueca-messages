using System;
using Thalamus;

namespace SuecaMessages
{
    public interface IStartEvents : Thalamus.IPerception
    {
        void Init(int id, int trump, int firstPlayer, int[] initialCards);
    }

    public interface ICardsEvents : Thalamus.IPerception
    {
        void PlayedCard(int playerId, int card);
        void Play();
    }
}
