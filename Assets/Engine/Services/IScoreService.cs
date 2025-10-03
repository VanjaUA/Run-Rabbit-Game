#region

using System;

#endregion

namespace RabbitGame.Services
{
    public interface IScoreService
    {
        event Action<int, int> OnScoreChanged;
        event Action OnLevelCompleted;

        int CurrentRoundScore { get; }
        int TotalScore { get; }

        void AddScore(int amount);
        void ResetRoundScore();
    }
}
