﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigRock : RockScript {


    // Use this for initialization
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        if (this.pv <= 0) {
            Destroy(gameObject);
        }
       
    }
}
