using UnityEngine;
using UnityEngine.UI;

using System;

using Vaneftec.Game.Common.Controller;

public class ScoreTextController : GameController {

	private Text text;
	private String defaultScoreText;

	void Start() {
		scoreManager.Register(UpdateDisplayedScore);
		gameContext.StartLevel();

		text = GetComponent<Text>();
		defaultScoreText = text.text;
		UpdateDisplayedScore(scoreManager.GetScore());
	}

	private void UpdateDisplayedScore(int score) {
		text.text = String.Format(defaultScoreText, score);
	}
}

