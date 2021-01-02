using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class XRExplicationSelection : MonoBehaviour
{
    [SerializeField]
    private GameObject explication1;

    [SerializeField]
    private GameObject explication2;

    [SerializeField]
    private GameObject explication3;

    [SerializeField]
    private Button next1;

    [SerializeField]
    private Button next2;

    [SerializeField]
    private Button next3;

    [SerializeField]
    private Button finish;

    [SerializeField]
    private GameObject startButton;


    // Start is called before the first frame update
    void Start()
    {
        startButton.gameObject.SetActive(false);

        next1.onClick.AddListener(() =>
        {
            explication1.gameObject.SetActive(false);
            explication2.gameObject.SetActive(true);
            explication3.gameObject.SetActive(false);
        });

        next2.onClick.AddListener(() =>
        {
            explication1.gameObject.SetActive(false);
            explication2.gameObject.SetActive(false);
            explication3.gameObject.SetActive(true);
        });

        next3.onClick.AddListener(() =>
        {
            explication1.gameObject.SetActive(false);
            explication2.gameObject.SetActive(false);
            explication3.gameObject.SetActive(false);
            startButton.gameObject.SetActive(true);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
