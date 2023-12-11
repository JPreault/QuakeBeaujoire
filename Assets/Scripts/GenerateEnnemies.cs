using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GenerateEnnemies : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject theEnnemy;
    public int xPos;
    public int zPos;
    public int ennemyCount;
    void Start()
    {
        StartCoroutine(EnnemyDrop());
    }

    IEnumerator EnnemyDrop()
    {
        int[] choices = {-1, 1};
        Scene currentScene = SceneManager.GetActiveScene ();
        if(currentScene.name == "SampleScene") {
            while(true) {
                int changeXorY = choices[Random.Range(0, 2)];
                if(changeXorY == 1) {
                    xPos = Random.Range(-56, 56);
                    zPos = 80 * choices[Random.Range(0, 2)];
                } else {
                    xPos = 56 * choices[Random.Range(0, 2)];
                    zPos = Random.Range(-80, 80);
                }
                Instantiate(theEnnemy, new Vector3(xPos, 0, zPos), Quaternion.identity);
                GameObject[] go = GameObject.FindGameObjectsWithTag("Soccer");
                int timer = Random.Range(5, 7) - (6 - go.Length);
                yield return new WaitForSeconds(timer);
            }
        }
        
    }
}
