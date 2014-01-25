using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MainGameControlScript : MonoBehaviour {

	public Dictionary<int, string> levels = new Dictionary<int, string>();
	public int currentLevel;

	// Use this for initialization
	void Start () {
		// Define level: "SceneName" dictionary here.
		this.levels.Add (1, "theGrid");
		this.levels.Add (2, "Level2");
		// this.levels.Add (3, "<SCENE_NAME>");
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.R)) {
			// Reload the current level.
			if (this.currentLevel == 0) {
				this.currentLevel = 1;
			}
			string currentLevel;
			this.levels.TryGetValue(this.currentLevel, out currentLevel);
			Application.LoadLevel(currentLevel);
		}
		if (Input.GetKeyDown(KeyCode.N)) {
			// Load the next level or if max level reached.
			if (this.currentLevel <= 0) {
				this.currentLevel = 1;
			}
			this.currentLevel = this.currentLevel + 1;
			string nextLevel;
			this.levels.TryGetValue(this.currentLevel, out nextLevel);
			if (nextLevel == null) {
				this.currentLevel = 1;
				Application.LoadLevel("theGrid");
			} else {
				Application.LoadLevel(nextLevel);
			}
		}
	}

	void Awake() {
		// Persist the MainGameController(Clone) object while loading scenes.
		DontDestroyOnLoad(this.gameObject);
	}
}
