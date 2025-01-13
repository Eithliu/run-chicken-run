using UnityEngine;
using System.Collections.Generic;

public class GarbageManager : MonoBehaviour
{
    public GameObject GoodGarbage;
    public GameObject BadGarbage;

    float timePassed = 0;

    Vector3 spawnPosition;
   
   public void generateGoodGarbage()
   {
        spawnPosition = new Vector3(Random.Range(-9.36f, 9.31f), 6.2f, 0);
        timePassed += Time.deltaTime;
        if (timePassed >= 2f)
        {
            Instantiate(GoodGarbage, spawnPosition, Quaternion.identity);
            timePassed = 0;
        }
   }

   public void generateBadGarbage()
   {
        spawnPosition = new Vector3(Random.Range(-9.36f, 9.31f), 6.2f, 0);
        timePassed += Time.deltaTime;
        if (timePassed >= 2f)
        {
            Instantiate(BadGarbage, spawnPosition, Quaternion.identity);
            timePassed = 0;
        }
   }
}
