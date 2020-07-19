using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    private float time = 1.0f;
   

    void Update()
    {
        

        if (time >= 0)
        {

            time -= Time.deltaTime;
            return ;
           
        }
        else
        {
            Vector3 enemyPosition = new Vector3(Random.Range(-2.0f, 2.0f), 4.0f, 0);
            ObjectPooler.instance.SpawnFromPool("Enemy", enemyPosition, Quaternion.identity);
            time = 3.0f;
        }
        
    }
   
       
    
    
   

   
}
