using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wavecontrol : MonoBehaviour {

    //確認用にpublicにしてあるが実際はprivateに変える
    public float RAM_hatyou = 4 ,A_sinnpuku = 2, T_syuuki = 2; 

    //-------------------------------//
    public void set_A (float A){
        A_sinnpuku = A;
    }

    public float get_A (){
        return A_sinnpuku;
    }

    //----------------------------------//
    public void set_T (float T){
        T_syuuki = T;
    }

    public float get_T (){
        return T_syuuki;
    }
    //------------------------------------//
    public void set_RAM (float RAM){

        RAM_hatyou = RAM;
    }

    public float get_RAM (){
        return RAM_hatyou;
    }


}
