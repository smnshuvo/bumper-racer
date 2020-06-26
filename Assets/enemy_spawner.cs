using UnityEngine;
 using System.Collections;
// I have never coded in c#, i thought script name and class name would be different
public class enemy_spawner : MonoBehaviour
{
    // Array of enemies
    public GameObject[] enemies;
    // where to spawn
    public Vector3 spawnArea;
    // waiting times
    public float waitTime;
    public float maxWaitTime;
    public float minWaitTime;
    public int waitingTimeBeforeStart;
    // boolean values
    public bool shouldSpawn = true;
    // random enemy
    private int randomEnemy;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());
    }

    // Update is called once per frame
    void Update()
    {
        waitTime = Random.Range(minWaitTime, maxWaitTime);
    }

    IEnumerator Spawner(){
        yield return new WaitForSeconds(waitingTimeBeforeStart);
        while(shouldSpawn){
            randomEnemy = Random.Range(0, 2);
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnArea.x, spawnArea.x),1,Random.Range(-spawnArea.z, spawnArea.z));
            GameObject _enemy = enemies[randomEnemy];
            
            // rotation of the object
            Quaternion rot = Quaternion.Euler(-90, 180, 0);
            Instantiate (_enemy, spawnPosition + transform.TransformPoint(0,0,0), rot);
            yield return new WaitForSeconds(waitTime);
        }
    }
}
