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
		
		protected static GameContext gameContext = GameContext.get();

		protected LevelManager levelManager = gameContext.LevelManager;
		protected ScoreManager scoreManager = gameContext.ScoreManager;
		protected GameSettings gameSettings = gameContext.GameSettings;
	}
}
