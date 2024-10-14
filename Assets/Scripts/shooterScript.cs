﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class shooterScript : MonoBehaviour
{
    
	public GameObject bullet;
	public Transform spawnPosition;
	private float bulletSpeed = 10;
	
	
	// Start is called before the first frame update
    void Start()
    {
	    XRGrabInteractable theGunGrabable = GetComponent<XRGrabInteractable>();
	    theGunGrabable.activated.AddListener(bangBang);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
	public void bangBang(ActivateEventArgs arg)
	{
		GameObject newBullet = Instantiate(bullet);
		newBullet.transform.position = spawnPosition.position;
		newBullet.GetComponent<Rigidbody>().velocity = spawnPosition.forward;


	}
}
