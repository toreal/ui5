using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

 public List<GameObject> targets;
 public TextMeshProUGUI scoreText;


 private int score;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawntarget());
        score =0;
        scoreText.text ="Score:"+score;

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



public void UpdateScore(int point){
score+= point;
scoreText.text= "Score:"+score;

}

}
