using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSpawring : MonoBehaviour
{
    [Header("Enemy setup")]
    public GameObject Enemy;
    public float Delay= 1f;


    [Header("Scene setup")] 
    public Transform StartPoint;
    public Transform EnemiesHolder;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawning());  
    }

  IEnumerator   Spawning()
    {
        yield return new WaitForSeconds(2f);

        while (true)
        {
            SpawnOneEnemy();
            yield return new WaitForSeconds(Delay);

            
        } 

    }


    void SpawnOneEnemy()

    {
        Instantiate(Enemy, StartPoint.position, Quaternion.identity, EnemiesHolder);



    }


}

