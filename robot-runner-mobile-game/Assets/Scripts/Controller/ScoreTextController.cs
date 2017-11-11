using UnityEngine;
using UnityEngine.UI;

using System;

using Vaneftec.Game.Common.Controller;

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
///
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

