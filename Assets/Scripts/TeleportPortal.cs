using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPortal : MonoBehaviour
{
    public Transform linkedPortal;

    private bool portalActive = true;

    private void OnTriggerEnter(Collider other)
    {
        if (portalActive)
        {
            linkedPortal.GetComponent<TeleportPortal>().Toggle();

            float xRot = other.transform.rotation.x;
            float zRot = other.transform.rotation.y;

            other.transform.SetPositionAndRotation(linkedPortal.transform.position, Quaternion.identity);
            other.transform.rotation = linkedPortal.transform.parent.transform.rotation;

            float yRot = other.transform.eulerAngles.y;

            other.transform.eulerAngles = new Vector3(xRot, yRot, zRot);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        Toggle();
    }

    public void Toggle()
    {
        portalActive = !portalActive;
    }
}