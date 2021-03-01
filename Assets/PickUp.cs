using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class PickUp : MonoBehaviour
{
    public GameEngine gameengine;
    public GameObject prefabGood;
    public GameObject prefabbad;
    int i;

    private void Start()
    {
        
    }
    private void Awake()
    {
       
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player" &&(this.gameObject.tag == "Good"))
        {
            gameengine.SpawnCubeGood();
            for (i = 0; i <= 5; i++)
            {
                gameengine.SpawnCubeBad();
            }

                
            Destroy(this.gameObject);
            
           
        }
        if (collider.gameObject.tag == "Player" && (this.gameObject.tag == "Bad"))
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(2);

        }

    }
    private void OnDestroy()
    {
       
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
