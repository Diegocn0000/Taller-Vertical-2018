﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruta : MonoBehaviour {

	//recibo

	public int precio;
	public int A;
	public int B;
	public string tipoFruta;

	//local
	public int peso;


	private int pesoRandom(int A, int B){
		System.Random rnd = new System.Random();
		int nRandom = rnd.Next(A, B);
		return nRandom;
	}

	void Start () {
		peso= pesoRandom (A,B);
	}

	void Update () {

	}
}