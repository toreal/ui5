using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

 public List<GameObject> targets;
 public TextMeshProUGUI scoreText;
  public TextMeshProUGUI gameOverText;


 private int score;
 public bool isActive = true;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawntarget());
        score =0;
        scoreText.text ="Score:"+score;
        //GameOver();

    }

    // Update is called once per frame
    void Update()
    {
        
    }



    IEnumerator Spawntarget(){
        while(isActive){

            yield return new WaitForSeconds(1f);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }


    }

public void GameOver(){

    gameOverText.gameObject.SetActive(true);

    isActive=false;
}


public void UpdateScore(int point){
    if ( isActive){
        score+= point;
scoreText.text= "Score:"+score;

    }


}

}
