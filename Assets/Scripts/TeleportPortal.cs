using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPortal : MonoBehaviour
{
    public Transform spawnPoint;



    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = spawnPoint.position;
    }

}