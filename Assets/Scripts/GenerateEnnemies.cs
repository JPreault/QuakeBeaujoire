using System.Collections;
using System.Collections.Generic;
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
        while(ennemyCount < 30) {
            int changeXorY = Random.Range(0,1);
            if(changeXorY == 1) {
                xPos = Random.Range(-56, 56);
                zPos = 80 * choices[Random.Range(0, 1)];
            } else {
                xPos = 56 * choices[Random.Range(0, 1)];
                zPos = Random.Range(-80, 80);
            }
            Instantiate(theEnnemy, new Vector3(xPos, 0, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            ennemyCount += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
