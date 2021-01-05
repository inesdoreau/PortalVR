using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class PortalGun : MonoBehaviour
{
    private AudioSource portalSound;
    private AudioSource errorSound;

    public GameObject orangePortal;
    public GameObject bluePortal;
    public GameObject portalGun;

    public XRController controller = null;
    InputDevice device;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(controller.controllerNode);
        device = InputDevices.GetDeviceAtXRNode(controller.controllerNode);
        Debug.Log(device.characteristics);
    }

    // Update is called once per frame
    void Update()
    {
        if (device.TryGetFeatureValue(CommonUsages.primaryButton, out bool buttonValue) && buttonValue)
        {
            Debug.Log(" pressing a");
        }

        if (Input.GetButtonDown("Oculus_CrossPlatform_SecondaryIndexTrigger"))
        {
            FirePortal("orange");

        }else if (Input.GetButtonDown("Oculus_CrossPlatform_SecondaryHandTrigger"))
        {
            FirePortal("blue");
        }
    }

    void FirePortal(string type)
    {
        RaycastHit hit;
        
        if(Physics.Raycast(portalGun.transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            Debug.Log(hit.point);
            //portalSound.Play();
            GameObject portal = type == "orange" ? orangePortal : bluePortal;

            portal.transform.SetPositionAndRotation(hit.point, Quaternion.FromToRotation(Vector3.forward, hit.normal));
        }
        else
        {
            //errorSound.Play();
        }
    }

}
