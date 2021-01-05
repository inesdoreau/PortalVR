using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class XRMenuSelect : MonoBehaviour
{
    [SerializeField]
    private GameObject menuPanel;

    [SerializeField]
    private GameObject creditPanel;

    [SerializeField]
    private Button playButton;

    [SerializeField]
    private Button settingsButton;

    [SerializeField]
    private Button creditsButton;

    [SerializeField]
    private Button backButton;


    // Start is called before the first frame update
    void Start()
    {
        creditsButton.onClick.AddListener(() =>
        {
            creditPanel.gameObject.SetActive(true);
            menuPanel.gameObject.SetActive(false);
        });

        backButton.onClick.AddListener(() =>
        {
            creditPanel.gameObject.SetActive(false);
            menuPanel.gameObject.SetActive(true);
        });

        playButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Level1");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
