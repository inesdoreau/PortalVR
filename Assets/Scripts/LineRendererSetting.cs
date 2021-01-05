using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineRendererSetting : MonoBehaviour
{
    //Declare a LineRenderer to store the component attached to the GameObject. 
    [SerializeField] LineRenderer rend;


    //Settings for the LineRenderer are stored as a Vector3 array of points. Set up a V3 array to //initialize in Start. 
    Vector3[] points;
    
    public LayerMask layerMask;

    public GameObject panel;
    public Image img;
    public Button btn;

    //Start is called before the first frame update
    void Start()
    {
        //get the LineRenderer attached to the gameobject. 
        rend = gameObject.GetComponent<LineRenderer>();

        img = panel.GetComponent<Image>();
    }
    
    public bool AlignLineRenderer(LineRenderer rend)
    {
        bool hitBtn = false;
        Ray ray;
        ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, layerMask))
        {
            points[1] = transform.forward + new Vector3(0, 0, hit.distance);
            rend.startColor = Color.red;
            rend.endColor = Color.red;
            btn = hit.collider.gameObject.GetComponent<Button>();
            hitBtn = true;
        }
        else
        {
            points[1] = transform.forward + new Vector3(0, 0, 20);
            rend.startColor = Color.green;
            rend.endColor = Color.green;
            hitBtn = false;
        }

        rend.SetPositions(points);
        rend.material.color = rend.startColor;
        return hitBtn;
    }

    public void ColorChangeOnClick()
    {
        if (btn != null)
        {
            if (btn.name == "RedButton")
            {
                img.color = Color.red;
            }
            else if (btn.name == "BlueButton")
            {
                img.color = Color.blue;
            }
            else if (btn.name == "GreenButton")
            {
                img.color = Color.green;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
         AlignLineRenderer(rend);

        if(AlignLineRenderer(rend) && Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0)
        {
            btn.onClick.Invoke();
        }
    }
}
