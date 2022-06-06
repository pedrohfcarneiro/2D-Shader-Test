﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissolve : MonoBehaviour
{
    Material material;

    bool isDissolving = false;
    float fade = 1f;


    void Start()
    {
        material = GetComponent<SpriteRenderer>().material;    
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            isDissolving = true;
        }

        if(isDissolving)
        {
            fade -= Time.deltaTime;

            if(fade <= 0f)
            {
                fade = 0;
                isDissolving = false;
            }
        }

        // Set the property
        material.SetFloat("_Fade", fade);
    }
}
