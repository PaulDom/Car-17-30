using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoutePoint : MonoBehaviour
{
    public RoutePoint nextPoint;
    public GameObject model;
    public bool isActiveForPlayer;

    private void OnTriggerEnter(Collider other)
    {
        if (isActiveForPlayer)
        {
            if (other.tag == "Players")
            {
                model.SetActive(false);
                isActiveForPlayer = false;

                nextPoint.model.SetActive(true);
                nextPoint.isActiveForPlayer = true;
            }
        }     
    }
}
