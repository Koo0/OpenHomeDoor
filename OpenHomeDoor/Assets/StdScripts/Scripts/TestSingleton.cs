﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSingleton : SingletonMonoBehaviour<TestSingleton> {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	protected override void Awake () {
		base.Awake ();

	}
}