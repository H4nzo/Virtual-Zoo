using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HandlerScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject GamePanel;
    public GameObject infoText;
    public GameObject infoPanel;
    public GameObject camera;

    // Update is called once per frame
    private void Start() {
        Cursor.lockState = CursorLockMode.None;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            Quit();
        }
    }

    public void Play(){
        Player.SetActive(true);
        infoPanel.SetActive(true);
        infoText.SetActive(true);
        GamePanel.SetActive(false);
        camera.SetActive(false);

    }
    public void Quit(){
        Application.Quit();
    }
}
