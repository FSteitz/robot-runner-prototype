using System;

using UnityEngine;

using Vaneftec.Game.Common.Settings;

// Copyright (c) Florian Steitz
namespace Vaneftec.Game.Common.Controller {

	/// <summary>
	/// TODO
	/// </summary>
	public abstract class RunnerController : GameController {

		/// <summary>
		/// TODO
		/// </summary>
		void Update() {
			Move(Vector3.forward);
		}

		/// <summary>
		/// TODO
		/// </summary>
		/// <returns>TODO</returns>
		/// <param name="position">TODO</param>
		protected Vector3 applyMoveDelta(Vector3 direction) {
			return direction * gameSettings.MovementVelocity * Time.deltaTime;
		}

		/// <summary>
		/// TODO
		/// </summary>
		/// <param name="position">TODO</param>
		protected abstract void Move(Vector3 direction);
	}
}
