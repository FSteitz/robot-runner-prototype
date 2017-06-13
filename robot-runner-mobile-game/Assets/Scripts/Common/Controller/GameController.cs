using System;

using UnityEngine;

using Vaneftec.Game.Common.Context;
using Vaneftec.Game.Common.Level;
using Vaneftec.Game.Common.Score;
using Vaneftec.Game.Common.Settings;

// Copyright (c) Florian Steitz
namespace Vaneftec.Game.Common.Controller {

	/// <summary>
	/// TODO
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
