using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;


public class EnemyWave : MonoBehaviour
{
    public GameObject me;
    private bool waveFinished;
    private int childCount;
    // Start is called before the first frame update
    void Start()
    {
        childCount = transform.childCount;
        //hideWave();
    }

    // Update is called once per frame
    void Update()
    {
        childCount = transform.childCount;
        
    }

    public bool isFinished(){
        return childCount <= 0;
    }

    /*public void hideWave(){
        foreach (Transform child in transform){
            child.gameObject.SetActive(false);
        }
    }

    public void showWave(){
        foreach (Transform child in transform){
            child.gameObject.SetActive(true);
        }
    }*/
}
