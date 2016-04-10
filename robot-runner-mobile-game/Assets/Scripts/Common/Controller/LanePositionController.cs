using System;

using UnityEngine;

// Copyright (c) Florian Steitz
namespace Vaneftec.Game.Common.Controller {

	/// <summary>
	/// TODO
	/// </summary>
	public class LanePositionController : RunnerController {

		/// <summary>
		/// TODO
		/// </summary>
		/// <param name="position">TODO</param>
		protected override void Move(Vector3 direction) {
			transform.Translate(applyMoveDelta(direction));
		}
	}
}

