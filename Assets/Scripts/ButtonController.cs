﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class ButtonController : VRTK_InteractableObject
{
	private float totalMonedero;
	public float totalCobrar;
	public bool cobrar;

	void Start(){
		totalMonedero = 100;
        cobrar = false;
	}

    public override void StartUsing(VRTK_InteractUse usingObject)
    {
        base.StartUsing(usingObject);
        transform.localScale += new Vector3(0, -0.04F, 0);
        Debug.Log("Has chocado el botón");
        gameObject.GetComponent<ExtraController>().runThingy();

        float totalFinal = totalMonedero - totalCobrar;
    }

    public override void StopUsing(VRTK_InteractUse previousUsingObject = null)
    {
        base.StopUsing(previousUsingObject);
        transform.localScale += new Vector3(0, 0.04F, 0);
        Debug.Log("Has dejado de chocar el botón");
    }

}