using System.Collections;
using System.Collections.Generic;

using Vaneftec.Game.Common.Level;
using Vaneftec.Game.Common.Score;
using Vaneftec.Game.Common.Settings;

/// Copyright 2016 Florian Steitz
///
/// Licensed under the Apache License, Version 2.0 (the "License");
/// you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at
///
///   http://www.apache.org/licenses/LICENSE-2.0
///
/// Unless required by applicable law or agreed to in writing, software
/// distributed under the License is distributed on an "AS IS" BASIS,
/// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
/// See the License for the specific language governing permissions and
/// limitations under the License.
namespace Vaneftec.Game.Common.Context {

	/// <summary>
	///
	/// </summary>
	public class GameContext {

		public LevelManager LevelManager { get; set; }
		public ScoreManager ScoreManager { get; set; }
		public GameSettings GameSettings { get; set; }

		private static GameContext instance;

		/// <summary>
		///
		/// </summary>
		public GameContext() {
			LevelManager = new LevelManager();
			ScoreManager = new ScoreManager();
			GameSettings = GameSettings.CreateInstance<GameSettings> ();
		}

		/// <summary>
		///
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
		///
		/// </summary>
		public static GameContext get() {
			if (instance == null) {
				instance = new GameContext();
			}

			return instance;
		}
	}
}