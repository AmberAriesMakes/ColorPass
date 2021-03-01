using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManagement : MonoBehaviour
{
    bool ispaused;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MenuClick()
    {
        SceneManager.LoadScene(0);
    }
    public void GameClick()
    {
        SceneManager.LoadScene(1);
    }
    public void Credits()
    {
        SceneManager.LoadScene(4);
    }

    public void Unpause()
    {
        if (ispaused == false)
        {
            Time.timeScale = 0f;
            ispaused = true;
        }
        else
        {
            Time.timeScale = 1f;
            ispaused = false;
        }
        
    }
    public void HowToPress()
    {
        SceneManager.LoadScene(3);
    }



}
