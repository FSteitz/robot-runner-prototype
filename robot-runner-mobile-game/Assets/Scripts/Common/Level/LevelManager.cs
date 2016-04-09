using System;
using System.Collections.Generic;

// Copyright (c) Florian Steitz
namespace Vaneftec.Game.Common.Level {

	/// <summary>
	/// TODO
	/// </summary>
	public class LevelManager {

		private List<PlayableLevel> levels = new List<PlayableLevel>();

		/// <summary>
		/// TODO
		/// </summary>
		/// <param name="level">TODO</param>
		public void AddLevel(PlayableLevel level) {
			levels.Add(level);
		}

		/// <summary>
		/// TODO
		/// </summary>
		/// <returns>TODO</returns>
		public int CountLevels() {
			return levels.Count;
		}
	}
}

