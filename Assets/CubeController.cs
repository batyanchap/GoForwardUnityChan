﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	//キューブの移動速度
	private float speed = -0.2f;

	//消滅位置
	private float deadLine = -10;

	//音源取得
	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
				audioSource = gameObject.GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {

				//キューブを移動させる
				transform.Translate(this.speed,0,0);

				//画面外に出たら破棄する
				if(transform.position.x < this.deadLine){
							Destroy(gameObject);
				}
	}

	void OnCollisionEnter2D(Collision2D other){
				if(other.gameObject.tag == "GroundTag" || other.gameObject.tag == "CubeTag"){
							audioSource.Play();
				}
	}
}
