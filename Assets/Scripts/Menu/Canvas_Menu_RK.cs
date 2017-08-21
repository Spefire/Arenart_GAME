﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Canvas_Menu_RK : MonoBehaviour {

	public bool isFrench;
	public bool hasMusic;
	public int position;
	public GameObject panelMenuPrincipal;
	public GameObject panelSelectPerso1;
	public GameObject panelSelectPerso2;
	public GameObject panelSelectArene;
	public GameObject panelSelectResume;
	public GameObject panelAidesPresentation;
	public GameObject panelAidesTouches;
	public GameObject panelAidesPerso01;
	public GameObject panelAidesPerso02;
	public GameObject panelAidesPerso03;
	public GameObject panelAidesPerso04;
	public GameObject panelAidesPerso05;
	public GameObject panelCredits;
	public Sprite son_off;
	public Sprite son_on;
	public Image son_music;
	public AudioClip son_menu;
	public AudioSource audCamera;
	public AudioClip son_validation;
	private AudioSource aud;

	void OnEnable () {
		position = 0;
		isFrench = true;
		hasMusic = true;
		Cursor.visible = false;
		aud = GetComponent<AudioSource>();
		audCamera.PlayOneShot(son_menu);
	}

	//------------------------------------------------------------------------------------------------------
	//------------------------------------------------------------------------------------------------------

	public void Click_Button_Jouer() {
		position = 1;
		print ("Selection Perso 1");
		aud.PlayOneShot (son_validation);
		panelMenuPrincipal.SetActive (false);
		panelSelectPerso1.SetActive (true);
	}

	public void Click_Button_Perso1() {
		position = 2;
		print ("Selection Perso 2");
		aud.PlayOneShot (son_validation);
		panelSelectPerso1.SetActive (false);
		panelSelectPerso2.SetActive (true);
	}

	public void Click_Button_Perso2() {
		position = 3;
		print ("Selection Arene");
		aud.PlayOneShot (son_validation);
		panelSelectPerso2.SetActive (false);
		panelSelectArene.SetActive (true);
	}

	public void Click_Button_Arene() {
		position = 4;
		print ("Selection Resume");
		aud.PlayOneShot (son_validation);
		panelSelectArene.SetActive (false);
		panelSelectResume.SetActive (true);
	}

	public void Click_Button_Launch() {
		print ("Lancement de la partie...");
		var gameObjects = GameObject.FindGameObjectsWithTag("LevelManager");
		foreach (var gameObj in gameObjects) {
			DontDestroyOnLoad(gameObj);
		}
		if (Selection_Arene_RK.select_arene == 1) {
			SceneManager.LoadScene ("Scene_Jeu_01");
		} else if (Selection_Arene_RK.select_arene == 2) {
			SceneManager.LoadScene ("Scene_Jeu_02");
		} else if (Selection_Arene_RK.select_arene == 3) {
			SceneManager.LoadScene ("Scene_Jeu_03");
		}
	}

	//------------------------------------------------------------------------------------------------------
	//------------------------------------------------------------------------------------------------------

	public void Click_Button_Aides() {
		position = 10;
		print ("Aides : Presentation");
		aud.PlayOneShot (son_validation);
		panelMenuPrincipal.SetActive (false);
		panelAidesPresentation.SetActive (true);
	}

	//------ Aides (10)

	public void Click_Button_Retour_Menu() {
		position = 0;
		print ("Menu Principal");
		aud.PlayOneShot (son_validation);
		panelAidesPresentation.SetActive (false);
		panelMenuPrincipal.SetActive (true);
	}

	public void Click_Button_Touches() {
		position = 11;
		print ("Aides : Touches");
		aud.PlayOneShot (son_validation);
		panelAidesPresentation.SetActive (false);
		panelAidesTouches.SetActive (true);
	}

	//------ Touches (11)

	public void Click_Button_Retour_Aides() {
		position = 10;
		print ("Aides : Présentation");
		aud.PlayOneShot (son_validation);
		panelAidesTouches.SetActive (false);
		panelAidesPresentation.SetActive (true);
	}

	public void Click_Button_Perso01() {
		position = 12;
		print ("Aides : Perso 01");
		aud.PlayOneShot (son_validation);
		panelAidesTouches.SetActive (false);
		panelAidesPerso01.SetActive (true);
	}

	//------ Perso 01 (12)

	public void Click_Button_Retour_Touches() {
		position = 11;
		print ("Aides : Touches");
		aud.PlayOneShot (son_validation);
		panelAidesPerso01.SetActive (false);
		panelAidesTouches.SetActive (true);
	}

	public void Click_Button_Perso02() {
		position = 13;
		print ("Aides : Perso 02");
		aud.PlayOneShot (son_validation);
		panelAidesPerso01.SetActive (false);
		panelAidesPerso02.SetActive (true);
	}

	//------ Perso 02 (13)

	public void Click_Button_Retour_Perso01() {
		position = 12;
		print ("Aides : Perso 01");
		aud.PlayOneShot (son_validation);
		panelAidesPerso02.SetActive (false);
		panelAidesPerso01.SetActive (true);
	}

	public void Click_Button_Perso03() {
		position = 14;
		print ("Aides : Perso 03");
		aud.PlayOneShot (son_validation);
		panelAidesPerso02.SetActive (false);
		panelAidesPerso03.SetActive (true);
	}

	//------ Perso 03 (14)

	public void Click_Button_Retour_Perso02() {
		position = 13;
		print ("Aides : Perso 02");
		aud.PlayOneShot (son_validation);
		panelAidesPerso03.SetActive (false);
		panelAidesPerso02.SetActive (true);
	}

	public void Click_Button_Perso04() {
		position = 15;
		print ("Aides : Perso 04");
		aud.PlayOneShot (son_validation);
		panelAidesPerso03.SetActive (false);
		panelAidesPerso04.SetActive (true);
	}

	//------ Perso 04 (15)

	public void Click_Button_Retour_Perso03() {
		position = 14;
		print ("Aides : Perso 03");
		aud.PlayOneShot (son_validation);
		panelAidesPerso04.SetActive (false);
		panelAidesPerso03.SetActive (true);
	}

	public void Click_Button_Perso05() {
		position = 16;
		print ("Aides : Perso 05");
		aud.PlayOneShot (son_validation);
		panelAidesPerso04.SetActive (false);
		panelAidesPerso05.SetActive (true);
	}

	//------ Perso 05 (16)

	public void Click_Button_Retour_Perso04() {
		position = 15;
		print ("Aides : Perso 04");
		aud.PlayOneShot (son_validation);
		panelAidesPerso05.SetActive (false);
		panelAidesPerso04.SetActive (true);
	}

	public void Click_Button_Retour_Final() {
		position = 11;
		print ("Aides : Touches");
		aud.PlayOneShot (son_validation);
		panelAidesPerso05.SetActive (false);
		panelAidesTouches.SetActive (true);
	}

	//------------------------------------------------------------------------------------------------------
	//------------------------------------------------------------------------------------------------------

	public void Click_Button_Credits() {
		position = 20;
		print ("Crédits");
		aud.PlayOneShot (son_validation);
		panelMenuPrincipal.SetActive (false);
		panelCredits.SetActive (true);
	}

	public void Click_Button_Retour_Credits() {
		position = 0;
		print ("Menu Principal");
		aud.PlayOneShot (son_validation);
		panelCredits.SetActive (false);
		panelMenuPrincipal.SetActive (true);
	}

	public void Click_Button_Langage() {
		print ("Langage");
		isFrench = !isFrench;
	}

	public void Click_Button_Musique() {
		print ("Musique");
		hasMusic = !hasMusic;
		if (!audCamera.isPlaying && audCamera.loop && hasMusic) {
			audCamera.PlayOneShot(son_menu);
			son_music.sprite = son_on;
		} else if (!hasMusic) {
			audCamera.Stop ();
			son_music.sprite = son_off;
		}
	}

	public void Click_Button_Quitter() {
		print ("Quitter");
		aud.PlayOneShot (son_validation);
		Application.Quit();
	}

	//------------------------------------------------------------------------------------------------------
	//------------------------------------------------------------------------------------------------------

	public void Choose_Return() {
		switch (position) {
		case 1:
			position = 0;
			print ("Menu Principal");
			aud.PlayOneShot (son_validation);
			panelSelectPerso1.SetActive (false);
			panelMenuPrincipal.SetActive (true);
			break;
		case 2:
			position = 1;
			print ("Selection Perso 1");
			aud.PlayOneShot (son_validation);
			panelSelectPerso2.SetActive (false);
			panelSelectPerso1.SetActive (true);
			break;
		case 3:
			position = 2;
			print ("Selection Perso 2");
			aud.PlayOneShot (son_validation);
			panelSelectArene.SetActive (false);
			panelSelectPerso2.SetActive (true);
			break;
		case 4:
			position = 3;
			print ("Selection Arene");
			aud.PlayOneShot (son_validation);
			panelSelectResume.SetActive (false);
			panelSelectArene.SetActive (true);
			break;
		case 10:
			position = 0;
			print ("Menu Principal");
			aud.PlayOneShot (son_validation);
			panelAidesPresentation.SetActive (false);
			panelMenuPrincipal.SetActive (true);
			break;
		case 11:
			position = 10;
			print ("Aides : Présentation");
			aud.PlayOneShot (son_validation);
			panelAidesTouches.SetActive (false);
			panelAidesPresentation.SetActive (true);
			break;
		case 12:
		case 13:
		case 14:
		case 15:
		case 16:
			position = 11;
			print ("Aides : Touches");
			aud.PlayOneShot (son_validation);
			panelAidesPerso01.SetActive (false);
			panelAidesPerso02.SetActive (false);
			panelAidesPerso03.SetActive (false);
			panelAidesPerso04.SetActive (false);
			panelAidesPerso05.SetActive (false);
			panelAidesTouches.SetActive (true);
			break;
		case 20:
			position = 0;
			print ("Menu Principal");
			aud.PlayOneShot (son_validation);
			panelCredits.SetActive (false);
			panelMenuPrincipal.SetActive (true);
			break;
		}
	}

	void Update () {
		if (Game_Inputs.J1_PouvoirSpe || Game_Inputs.J2_PouvoirSpe) {
			Choose_Return();
		}
		if (!audCamera.isPlaying && audCamera.loop && hasMusic) {
			audCamera.PlayOneShot (son_menu);
		}
		if (EventSystem.current.currentSelectedGameObject == null) {
			EventSystem.current.SetSelectedGameObject (EventSystem.current.firstSelectedGameObject);
		}
	}
}