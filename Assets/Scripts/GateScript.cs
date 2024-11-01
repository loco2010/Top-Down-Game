using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateScript : MonoBehaviour
{
    public EnemyWave wave1;
    public EnemyWave wave2;
    public GameObject self;
    private int waveNum;
    // Start is called before the first frame update
    void Start()
    {
        waveNum = 1;
        //wave2.hideWave();
    }

    // Update is called once per frame
    void Update()
    {
        if (wave1.isFinished() && wave2.isFinished()){
            Destroy(self);
            /*nextWave();
            if (wave2.isFinished()){
                Destroy(self);
            }*/
        }


    }

    /*private void nextWave(){
        if (waveNum == 1){
            wave1.hideWave();
            waveNum = 2;
            wave2.showWave();
        } else if (waveNum == 2){
            wave2.hideWave();
        }
        
    }*/
}
