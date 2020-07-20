using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    //When using static this can be removed
    //private Score _score;


    // Start is called before the first frame update
    void Start()
    {
        //When using static this can be removed
        //_score = GameObject.Find("Score Keeper").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {

            //add 10 to score
            //When using static this can be removed
            //_score.score += 10;

            Score.score += 10;
            Debug.Log("Score: " + Score.score);
        }
    }
}