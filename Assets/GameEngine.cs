using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEngine : MonoBehaviour
{
    public GameObject PrefabGood;
    public GameObject PrefabBad;
    public Vector3 center;
    public Vector3 size;
    
   
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnCubeGood();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void SpawnCubeGood()
   {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), 0, Random.Range(-size.x / 2, size.x / 2));
        Instantiate(PrefabGood, pos, Quaternion.identity);

    }
    public void SpawnCubeBad()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), 0, Random.Range(-size.x / 2, size.x / 2));
        Instantiate(PrefabBad, pos, Quaternion.identity);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);
    }

  

}
