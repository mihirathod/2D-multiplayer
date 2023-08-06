using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerscript : MonoBehaviour
{
    public GameObject[] gunsPrefabs;
    [SerializeField] private float timer =8;
    public Transform[] spawningtransform;
    private GameObject Thsgun;
    void Start()
    {
        StartCoroutine(gunspawn());
    }

     public void guns_spawner()
    {
         Thsgun = Instantiate(gunsPrefabs[Random.Range(0, gunsPrefabs.Length)],spawningtransform[Random.Range(0,spawningtransform.Length)].position , Quaternion.identity) as GameObject; 
       
    }
    IEnumerator gunspawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(timer);
            guns_spawner();
        }

    }
  
    
    

}
