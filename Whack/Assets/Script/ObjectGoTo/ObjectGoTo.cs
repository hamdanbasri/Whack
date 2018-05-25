/*
* Copyright (c) Hamdan Basri
* https://www.hamdanbasri.com/
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGoTo : MonoBehaviour {

    #region Variables
    public Vector3 target1;
    public Vector3 target2;
    public Transform ObjectMove;
    public float PositionZPos;
    public float PositionZNeg;
    public float smooth = 2;
    public int RandomStart;
    public int RandomSmooth;
    public bool Move;
    private ObjectGoTo isPressed;
    #endregion

    // Use this for initialization
    void Start () {
        isPressed = GetComponent<ObjectGoTo>();
        //ObjectMove.transform.position = GetComponent<Vector3>();
        target1 = new Vector3(ObjectMove.transform.position.x, ObjectMove.transform.position.y, ObjectMove.transform.position.z);
        target2 = new Vector3(ObjectMove.transform.position.x, ObjectMove.transform.position.y, ObjectMove.transform.position.z);
        //GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

        RandomSmooth = Random.Range(1, 8);
        isPressed.smooth = RandomSmooth;

        RandomStart = Random.Range(0, 2);
        if (RandomStart == 0)
        {
            Move = true;
        }

        if (RandomStart == 1)
        {
            Move = false;
        }
        //target1 = ObjectMove.transform.position;
        //target2 = ObjectMove.transform.position;

    }
	
	// Update is called once per frame
	void Update () {        

        if (Move == true)
        {
            target1.z = PositionZPos;
            ObjectMove.transform.position = Vector3.Lerp(transform.position, target1, Time.deltaTime * smooth);

            if(ObjectMove.transform.position == target1)
            {
                Move = false;
            }
        }

        if (Move == false)
        {
            target2.z = PositionZNeg;
            ObjectMove.transform.position = Vector3.Lerp(transform.position, target2, Time.deltaTime * smooth);

            if (ObjectMove.transform.position == target2)
            {
                Move = true;
            }
        }
    }

    public void Pressed()
    {
        isPressed.enabled = false;
    }
}
