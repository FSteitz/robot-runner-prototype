using System;

using UnityEngine;

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
namespace Vaneftec.Game.Common.Settings {

	/// <summary>
	///
	/// </summary>
	public class GameSettings : ScriptableObject {

		public float MovementVelocity { get; set; }
		public float JumpVelocity { get; set; }
		public float Gravity { get; set; }

		/// <summary>
		///
		/// </summary>
		public GameSettings() {
			MovementVelocity = 25.0f;
			JumpVelocity = 8.0f;
			Gravity = 9.8F;
		}
	}
}
