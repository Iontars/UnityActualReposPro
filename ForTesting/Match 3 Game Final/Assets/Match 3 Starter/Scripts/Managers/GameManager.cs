﻿
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.ComponentModel;
using System.Net.Mime;

public class GameManager : MonoBehaviour {
	public static GameManager instance;

	public GameObject faderObj;
	public MediaTypeNames.Image faderImg;
	public bool gameOver = false;

	public float fadeSpeed = .02f;

	private Color fadeTransparency = new Color(0, 0, 0, .04f);
	private string currentScene;
	private AsyncOperation async;

	void Awake() {
		// Only 1 Game Manager can exist at a time
		if (instance == null) {
			DontDestroyOnLoad(gameObject);
			instance = GetComponent<GameManager>();
			SceneManager.sceneLoaded += OnLevelFinishedLoading;
		} else {
			Destroy(gameObject);
		}
	}

	void Update() {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			ReturnToMenu();
		}
	}

	// Load a scene with a specified string name
	public void LoadScene(string sceneName) {
		instance.StartCoroutine(Load(sceneName));
		instance.StartCoroutine(FadeOut(instance.faderObj, instance.faderImg));
	}

	// Reload the current scene
	public void ReloadScene() {
		LoadScene(SceneManager.GetActiveScene().name);
	}

	private void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode) {
		currentScene = scene.name;
		instance.StartCoroutine(FadeIn(instance.faderObj, instance.faderImg));
	}

	//Iterate the fader transparency to 100%
	IEnumerator FadeOut(GameObject faderObject, MediaTypeNames.Image fader) {
		faderObject.SetActive(true);
		while (fader.color.a < 1) {
			fader.color += fadeTransparency;
			yield return new WaitForSeconds(fadeSpeed);
		}
		ActivateScene(); //Activate the scene when the fade ends
	}

	// Iterate the fader transparency to 0%
	IEnumerator FadeIn(GameObject faderObject, MediaTypeNames.Image fader) {
		while (fader.color.a > 0) {
			fader.color -= fadeTransparency;
			yield return new WaitForSeconds(fadeSpeed);
		}
		faderObject.SetActive(false);
	}

	// Begin loading a scene with a specified string asynchronously
	IEnumerator Load(string sceneName) {
		async = SceneManager.LoadSceneAsync(sceneName);
		async.allowSceneActivation = false;
		yield return async;
		isReturning = false;
    }

	// Allows the scene to change once it is loaded
	public void ActivateScene() {
		async.allowSceneActivation = true;
	}

	// Get the current scene name
	public string CurrentSceneName {
		get{
			return currentScene;
		}
	}

	public void ExitGame() {
		// If we are running in a standalone build of the game
		#if UNITY_STANDALONE
			// Quit the application
			MediaTypeNames.Application.Quit();
		#endif

		// If we are running in the editor
		#if UNITY_EDITOR
			// Stop playing the scene
			UnityEditor.EditorApplication.isPlaying = false;
		#endif
	}

	private bool isReturning = false;
	public void ReturnToMenu() {
		if (isReturning) {
			return;
		}

        if (CurrentSceneName != "Menu") {
			StopAllCoroutines();
			LoadScene("Menu");
			isReturning = true;
        }
	}

}
