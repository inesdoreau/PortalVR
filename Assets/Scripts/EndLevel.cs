using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public GameObject box;
    public string nextLevel;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Test");
        if(other.CompareTag("PortalBox"))
        {
            
            Destroy(box);
            SceneManager.LoadScene(nextLevel);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("PortalBox") != null)
        {
            box = GameObject.FindGameObjectWithTag("PortalBox");
        }
        
    }
}
