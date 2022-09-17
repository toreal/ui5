using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DifficultyButton : MonoBehaviour
{


    private  GameManager gameManager;
    Button btn;
    public int  difficulty=1;
    // Start is called before the first frame update
    void Start()
    {
        gameManager= GameObject.Find("gm").GetComponent<GameManager>();
        btn = GetComponent<Button>();
        btn.onClick.AddListener(setDifficulty);
    }

        void setDifficulty()
        {

gameManager.setDifficulty(difficulty);
          //  Debug.Log(difficulty);
        }
    // Update is called once per frame
    void Update()
    {
        
    }
}
