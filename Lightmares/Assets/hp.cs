using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hp : MonoBehaviour
{

    public float health;
    public bool CanHarvest


    // Start is called before the first frame update
    void Start()
    {
        CanHarvest = false;
        health = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;

    if (timeLeft < 0)
    {
        Debug.Log("IM READY TO HARVEST");
        CanHarvest = true;    
    }   
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (CanHarvest && col.gameObject.tag == "Player")
     {
         health -= 1f;
     }
    }
}
