using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHolder : MonoBehaviour
{
    public Transform player;

    Vector3 velocity;

    Vector3 velocity2;

    public float smoothTime;

    public bool isCameraFollowingBackwards;

    private Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
    }

    private void Update()
    {
        /*Kamera Ayarý düzeltilmeli*/
        isCameraFollowingBackwards = true;

        if (player.position.z < transform.position.z)
        {
            isCameraFollowingBackwards = false;
            if ( player.position.x < 25 ||  player.position.x > 5) {
                isCameraFollowingBackwards = true;
            }

            
        }

        if(player.position.x > 25 || player.position.x < 5)
        {
            isCameraFollowingBackwards = false;
        }

        if (isCameraFollowingBackwards)
        {
            var targetPos = player.position;
            targetPos.y = 0;

            transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);
        }
    }

    public void ResetCameraHolder()
    {
        transform.position = initialPosition;
    }
}
