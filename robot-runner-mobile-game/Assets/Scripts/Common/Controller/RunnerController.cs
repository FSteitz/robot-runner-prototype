using System;

using UnityEngine;

using Vaneftec.Game.Common.Controller;
using Vaneftec.Game.Common.Settings;

// Copyright (c) Florian Steitz
namespace Vaneftec.Game.Common.Controller {

	/// <summary>
	/// TODO
	/// </summary>
	public class LanePositionController : GameController {

		/// <summary>
		/// TODO
		/// </summary>
		void Update() {
			Debug.Log("called");
			Debug.Log(gameSettings.MovementVelocity);
			transform.Translate(Vector3.forward * gameSettings.MovementVelocity * Time.deltaTime);
		}
	}
}

