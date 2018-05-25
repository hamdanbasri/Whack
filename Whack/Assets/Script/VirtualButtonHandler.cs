// © VLIXN Ventures 2018
// Author | Hamdan Basri

using UnityEngine;
using Vuforia;

public class VirtualButtonHandler : MonoBehaviour, IVirtualButtonEventHandler {

    public GameObject Object;

	// Use this for initialization
	void Start () {
        GameObject virtualButtonObject = GameObject.Find("VirtualButtonOpen");
        virtualButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Object.SetActive(false);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Object.SetActive(true);
    }
}
