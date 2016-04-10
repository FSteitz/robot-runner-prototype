using System;

using UnityEngine;

// Copyright (c) Florian Steitz
namespace Vaneftec.Game.Common.Settings {

	/// <summary>
	/// TODO
	/// </summary>
	public class GameSettings : ScriptableObject {

		public float MovementVelocity { get; set; }
		public float JumpVelocity { get; set; }
		public float Gravity { get; set; }

		/// <summary>
		/// TODO
		/// </summary>
		public GameSettings() {
			MovementVelocity = 25.0f;
			JumpVelocity = 8.0f;
			Gravity = 9.8F;
		}
	}
}
