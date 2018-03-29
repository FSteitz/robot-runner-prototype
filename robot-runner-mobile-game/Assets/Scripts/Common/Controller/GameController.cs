using System;

using UnityEngine;

using Vaneftec.Game.Common.Context;
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
namespace Vaneftec.Game.Common.Controller {

	/// <summary>
	///
	/// </summary>
	public abstract class GameController : MonoBehaviour {
		protected static GameContext gameContext;

		protected LevelManager levelManager;
		protected ScoreManager scoreManager;
		protected GameSettings gameSettings;

		void Awake() {
			gameContext = GameContext.get();

			levelManager = gameContext.LevelManager;
			scoreManager = gameContext.ScoreManager;
			gameSettings = gameContext.GameSettings;
		}
	}
}
