using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDetector : MonoBehaviour
{

    public Player player;
    

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
        //transform.localScale
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Car")
        {
            var car = other.GetComponent<Car>();
            if ((car.isCarDirectionLeft && transform.position.x < other.transform.position.x) 
                || (!car.isCarDirectionLeft && transform.position.x > other.transform.position.x))
            {
                player.gameDirector.audioManager.PlayCarSound();

            }
        }
    }
}
