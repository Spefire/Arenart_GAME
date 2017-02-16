﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Camera_Menu: MonoBehaviour {

	private float posx;
	private float posy;
	private float tex;
	private float tey;
	private float coef;
	public static int pos;
	public static int choice;
	public static bool isFrench;
	public static bool hasMusic;
	public Texture texture_choice_0;
	public Texture texture_choice_1;
	public Texture texture_choice_2;
	public Texture texture_choice_3;
	public Texture texture_choice_4;
	public Texture texture_choice_5;
	public AudioClip son_validation;
	private Renderer render;
	private AudioSource aud;


	void Start () {
		render = GetComponent<Renderer>();
		aud = GetComponent<AudioSource>();
		posx = transform.position.x;
		posy = transform.position.y;
		pos = 0;
		choice = 0;
		isFrench = true;
		hasMusic = true;
		float TARGET_WIDTH = 1366.0f;
		float TARGET_HEIGHT = 768.0f;
		int PIXELS_TO_UNITS = 30; // 1:1 ratio of pixels to units
		float desiredRatio = TARGET_WIDTH / TARGET_HEIGHT;
		float currentRatio = (float)Screen.width/(float)Screen.height;
		if (currentRatio >= desiredRatio) {
			GetComponent<Camera>().orthographicSize = TARGET_HEIGHT / 4 / PIXELS_TO_UNITS;
		} else {
			float differenceInSize = desiredRatio / currentRatio;
			GetComponent<Camera>().orthographicSize = TARGET_HEIGHT / 4 / PIXELS_TO_UNITS * differenceInSize;
		}
	}


	void Update () {
		tex = (float)Screen.width/1366;
		tey = (float)Screen.height/768;

		//Menu Principal
		if (pos == 0) {
			if (choice < 5 && Input.GetKeyUp (KeyCode.Z)) {
				choice++;
				switch (choice) {
				case 1: //Aides
					render.material.mainTexture = texture_choice_1;
					break;
				case 2: //Credits
					render.material.mainTexture = texture_choice_2;
					break;
				case 3: //Musique
					render.material.mainTexture = texture_choice_3;
					break;
				case 4: //Langage
					render.material.mainTexture = texture_choice_4;
					break;
				case 5: //Quitter
					render.material.mainTexture = texture_choice_5;
					break;
				}
			}
			if (choice > 0 && Input.GetKeyUp (KeyCode.S)) {
				choice--;
				switch (choice) {
				case 0: //Jouer
					render.material.mainTexture = texture_choice_0;
					break;
				case 1: //Aides
					render.material.mainTexture = texture_choice_1;
					break;
				case 2: //Credits
					render.material.mainTexture = texture_choice_2;
					break;
				case 3: //Musique
					render.material.mainTexture = texture_choice_3;
					break;
				case 4: //Langage
					render.material.mainTexture = texture_choice_4;
					break;
				}
			}
			if (Input.GetKeyUp (KeyCode.Return)) {
				switch (choice) {
				case 0: //Jouer
					print ("Jouer");
					transform.position = new Vector3 (posx + 35, posy, 0);
					posx = transform.position.x;
					posy = transform.position.y;
					pos = 1;
					aud.PlayOneShot (son_validation);
					break;
				case 1: //Aides
					print ("Aides");
					transform.position = new Vector3 (posx, posy -15, 0);
					posx = transform.position.x;
					posy = transform.position.y;
					pos = 5;
					aud.PlayOneShot (son_validation);
					break;
				case 2: //Credits
					print ("Credits");
					transform.position = new Vector3 (posx, posy -30, 0);
					posx = transform.position.x;
					posy = transform.position.y;
					pos = 6;
					aud.PlayOneShot (son_validation);
					break;
				case 3: //Musique
					print ("Musique");
					hasMusic = !hasMusic;
					break;
				case 4: //Langage
					print ("Langage");
					isFrench = !isFrench;
					break;
				case 5: //Quitter
					print ("Quitter");
					aud.PlayOneShot (son_validation);
					Application.Quit();
					break;
				}
				choice = 0;
			}
		}

		//Selection_P1
		else if (pos == 1) {
			if (Input.GetKeyUp (KeyCode.Escape)) {
				print ("Retour_Menu");
				transform.position = new Vector3 (posx - 35, posy, 0);
				posx = transform.position.x;
				posy = transform.position.y;
				pos = 0;
				aud.PlayOneShot (son_validation);
			}
			if(Input.GetKeyUp (KeyCode.Return)){
				print ("Selection_P2");
				transform.position = new Vector3 (posx + 35, posy, 0);
				posx = transform.position.x;
				posy = transform.position.y;
				pos = 2;
				aud.PlayOneShot (son_validation);
			}
		}

		//Selection_P2
		else if (pos == 2) {
			if (Input.GetKeyUp (KeyCode.Escape)) {
				print ("Retour_Selection_P1");
				transform.position = new Vector3 (posx - 35, posy, 0);
				posx = transform.position.x;
				posy = transform.position.y;
				pos = 1;
				aud.PlayOneShot (son_validation);
			}
			if (Input.GetKeyUp (KeyCode.Return)) {
				print ("Selection_Arene");
				transform.position = new Vector3 (posx + 35, posy, 0);
				posx = transform.position.x;
				posy = transform.position.y;
				pos = 3;
				aud.PlayOneShot (son_validation);
			}
		}

		//Selection_Arene
		else if (pos == 3) {
			if (Input.GetKeyUp (KeyCode.Escape)) {
				print ("Retour_Selection_P2");
				transform.position = new Vector3 (posx - 35, posy, 0);
				posx = transform.position.x;
				posy = transform.position.y;
				pos = 2;
				aud.PlayOneShot (son_validation);
			}
			if (Input.GetKeyUp (KeyCode.Return)) {
				print ("Select_Resume");
				transform.position = new Vector3 (posx + 35, posy, 0);
				posx = transform.position.x;
				posy = transform.position.y;
				pos = 4;
				aud.PlayOneShot (son_validation);
			}
		}

		//Selection_Resume
		else if (pos == 4) {
			if (Input.GetKeyUp (KeyCode.Escape)) {
				print ("Retour_Select_Arene");
				transform.position = new Vector3 (posx - 35, posy, 0);
				posx = transform.position.x;
				posy = transform.position.y;
				pos = 3;
				aud.PlayOneShot (son_validation);
			}
			if (Input.GetKeyUp (KeyCode.Return)) {
				aud.PlayOneShot (son_validation);
				var gameObjects = GameObject.FindGameObjectsWithTag("LevelManager");
				foreach (var gameObj in gameObjects) {
					DontDestroyOnLoad(gameObj);
				}
				if (Selection_Arene.select_arene == 1) {
					SceneManager.LoadScene ("Scene_Jeu_01");
				}else if (Selection_Arene.select_arene == 2) {
					SceneManager.LoadScene ("Scene_Jeu_02");
				}else if (Selection_Arene.select_arene == 3) {
					SceneManager.LoadScene ("Scene_Jeu_03");
				}
			}
		}

		//Aides TODO
		else if (pos == 5) {
			if (Input.GetKeyUp (KeyCode.Escape)) {
				print ("Retour_Menu");
				transform.position = new Vector3 (posx, posy + 15, 0);
				posx = transform.position.x;
				posy = transform.position.y;
				pos = 0;
				aud.PlayOneShot (son_validation);
			}
		}

		//Crédits
		else if (pos == 6) {
			if (Input.GetKeyUp (KeyCode.Escape)) {
				print ("Retour_Menu");
				transform.position = new Vector3 (posx, posy + 30, 0);
				posx = transform.position.x;
				posy = transform.position.y;
				pos = 0;
				aud.PlayOneShot (son_validation);
			}
		}
	}
}