﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objet_Lance : MonoBehaviour {

	public int veloX;
	public int veloY;
	public double coeffDegats;
	public int resistance;

	private GameObject ally;
	private GameObject enemy;
	private bool inversed;
	private SpriteRenderer render;

	void OnEnable () {
		render = GetComponent<SpriteRenderer>();
	}
	
	public void SetConfig(bool first, bool inversed, float coeff) {
		if (first) {
			ally = GameObject.FindGameObjectWithTag ("J1");
			enemy = GameObject.FindGameObjectWithTag ("J2");
		} else {
			ally = GameObject.FindGameObjectWithTag ("J2");
			enemy = GameObject.FindGameObjectWithTag ("J1");
		}
		if (inversed) {
			render.flipX = true;
			Vector3 velocity = new Vector3 (coeff * -veloX * Mathf.Sign (transform.forward.x), coeff * veloY * Mathf.Sign (transform.forward.y), 0);
			this.GetComponent<Rigidbody> ().velocity = velocity;
		} else {
			Vector3 velocity = new Vector3 (coeff * veloX * Mathf.Sign (transform.forward.x), coeff * veloY * Mathf.Sign (transform.forward.y), 0);
			this.GetComponent<Rigidbody> ().velocity = velocity;
		}
		Physics.IgnoreCollision(this.GetComponent<Collider>(), ally.transform.root.GetComponent<Collider>());
	}

	void OnTriggerEnter(Collider objetInfo) {
		if (objetInfo.gameObject == enemy) {
			Perso_Stats_RK stats = enemy.GetComponent<Perso_Stats_RK> ();
			stats.SetDamage (stats.GetDamage (coeffDegats), resistance);
			DestroyObject (this.gameObject);
		}
	}

	void OnCollisionEnter(Collision objetInfo) {
		if (objetInfo.gameObject == enemy) {
			Perso_Stats_RK stats = enemy.GetComponent<Perso_Stats_RK> ();
			stats.SetDamage (stats.GetDamage (coeffDegats), resistance);
			DestroyObject (this.gameObject);
		}
	}
}
