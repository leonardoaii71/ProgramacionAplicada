using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource essenceHit;
    public AudioSource SpikeHit;
    public AudioSource music;
    public AudioSource boatExploded;
   
   public void PlayEssenceHit(){
       essenceHit.Play();
   }

    public void PlaySpikeHit(){
       SpikeHit.Play();
   }

   public void PlayMusic(){
       music.Play();
   }

   public void PlayboatExploded(){
       boatExploded.Play();
   }

}
