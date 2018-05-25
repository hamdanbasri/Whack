// © VLIXN Ventures 2018
// Author | Hamdan Basri

using System.Collections;
using System.Collections.Generic;
using Vuforia;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject Object;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Open()
    {
        Object.SetActive(true);
    }

    public void Close()
    {
        Object.SetActive(false);
    }
}
