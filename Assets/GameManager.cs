using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

 public List<GameObject> targets;
 public TextMeshProUGUI scoreText;
  public TextMeshProUGUI gameOverText;

  public Button restartBtn;



 private int score;
 public bool isActive = true;


public void restart(){

    SceneManager.LoadScene(SceneManager.GetActiveScene().name);

}


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
    restartBtn.gameObject.SetActive(true);

    isActive=false;
}


public void UpdateScore(int point){
    if ( isActive){
        score+= point;
scoreText.text= "Score:"+score;

    }


}

}
