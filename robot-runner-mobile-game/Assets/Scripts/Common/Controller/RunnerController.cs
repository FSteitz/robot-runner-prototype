using System;

using UnityEngine;

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
