using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBox : MonoBehaviour
{
    public Transform spawnPoint;
    public Transform box;


    public void AddBox()
    {
        Destroy(GameObject.FindGameObjectWithTag("PortalBox"));
        Instantiate(box, spawnPoint.position, Quaternion.identity);
    }



}
