﻿using UnityEngine;
using System.Collections;

//WARNING: YOU MUST PUT THE PARTICLE SYSTEM THIS SCRIPT IS ATTACHED TO IN CARDBOARDMAIN -> HEAD -> MAIN CAMERA
//OTHERWISE THE STARFIELD WILL NOT SHOW UP CORRECTLY. THIS IS EASY TO FORGET IF YOU HAVE REMOVED CARDBOARDMAIN AND
//ADDED IT AGAIN!

public class InfiniteStarfield : MonoBehaviour {

	private Transform tx;
	private ParticleSystem.Particle[] points;

	public int starsMax = 1000;
	public float starSize = 0.4f;
	public float starDistance = 80; //this must be set to a value lower than the camera clip distance or the starfield may get clipped when viewed on certain angles
	public float starClipDistance = 0;
	private float starDistanceSqr;
	private float starClipDistanceSqr;


	// Use this for initialization
	void Start () {
		tx = transform;
		starDistanceSqr = starDistance * starDistance;
		starClipDistanceSqr = starClipDistance * starClipDistance;
	}


	private void CreateStars() {
		points = new ParticleSystem.Particle[starsMax];

		for (int i = 0; i < starsMax; i++) {
			points[i].position = Random.insideUnitSphere * starDistance + tx.position;
			points[i].startColor = new Color(1,1,1, 1);
			points[i].startSize = starSize;
		}
	}


	// Update is called once per frame
	void Update () {
		if ( points == null ) CreateStars();

		for (int i = 0; i < starsMax; i++) {

			if ((points[i].position - tx.position).sqrMagnitude > starDistanceSqr) {
				points[i].position = Random.insideUnitSphere.normalized * starDistance + tx.position;
			}

			if ((points[i].position - tx.position).sqrMagnitude <= starClipDistanceSqr) {
				float percent = (points[i].position - tx.position).sqrMagnitude / starClipDistanceSqr;
				points[i].startColor = new Color(1,1,1, percent);
				points[i].startSize = percent * starSize;
			}


		}




		GetComponent<ParticleSystem> ().SetParticles (points, points.Length);

	}
}
