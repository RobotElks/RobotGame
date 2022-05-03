﻿using UnityEngine;
using System.Collections;

public class CannonBehavior : MonoBehaviour {

	public Transform muzzle;
	public GameObject shotPrefab;
	public GameObject shot_spawn;
	public float power;

	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			shoot();
		}
	}

	public void setPowerZero(){
		power = 0f;
	}

	public void shoot(){
		//m_shotPrefab.GetComponent<Light>().color = new Color.yellow;
		GameObject go = GameObject.Instantiate(shotPrefab, shot_spawn.transform.position, muzzle.rotation) as GameObject;
		Physics.IgnoreCollision(go.GetComponent<Collider>(), this.GetComponent<Collider>());
		//GameObject.Destroy(go, power);
	}
}
