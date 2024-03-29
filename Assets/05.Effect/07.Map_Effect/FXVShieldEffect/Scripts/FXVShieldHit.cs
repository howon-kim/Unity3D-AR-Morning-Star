﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXVShieldHit : MonoBehaviour
{
    private float lifeTime = 0.5f;
    private float lifeStart = 0.5f;

    private MeshRenderer myRenderer;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        lifeTime -= Time.deltaTime;

        Color c = myRenderer.material.color;
        c.a = Mathf.Max(0.0f, lifeTime / lifeStart);
        myRenderer.material.color = c;

        if (lifeTime <= 0.0f)
        {
            DestroyObject(gameObject);
        }
    }

    public void StartHitFX(float time)
    {
        lifeTime = lifeStart = time;

        myRenderer = GetComponent<MeshRenderer>();
        Color c = myRenderer.material.color;
        c.a = 1.0f;
        myRenderer.material.color = c;
    }
}
