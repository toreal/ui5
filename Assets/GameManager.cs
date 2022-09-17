using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

 public List<GameObject> targets;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawntarget());
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    IEnumerator Spawntarget(){
        while(true){

            yield return new WaitForSeconds(1f);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }


    }
}
