using System.Collections;
using System.Collections.Generic;

using Vaneftec.Game.Common.Singleton;
using Vaneftec.Game.Common.Level;
using Vaneftec.Game.Common.Score;

// Copyright (c) Florian Steitz
namespace Vaneftec.Game.Common.Context {

	/// <summary>
	/// TODO
	/// </summary>
	public class GameContext {

		public LevelManager LevelManager { get; set; }
		public ScoreManager ScoreManager { get; set; }

		private static GameContext instance;

		/// <summary>
		/// TODO
		/// </summary>
		public GameContext() {
			LevelManager = new LevelManager();
			ScoreManager = new ScoreManager();
		}

		/// <summary>
		/// TODO
		/// </summary>
		public void StartLevel() {
			if (LevelManager.CountLevels() == 0) {
				PlayableLevel level = new PlayableLevel();
				level.Name = "firstLevel";
				level.CurrentScore = ScoreManager.DEFAULT_SCORE;
				level.LastScore = ScoreManager.DEFAULT_SCORE;
				level.HighestScore = ScoreManager.DEFAULT_SCORE;

				LevelManager.AddLevel(level);
				ScoreManager.CurrentLevel = level;
			}
		}

		/// <summary>
		/// TODO
		/// </summary>
		public static GameContext get() {
			if (instance == null) {
				instance = new GameContext();
			}

			return instance;
		}
	}
}
