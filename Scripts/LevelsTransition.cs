using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelsTransition : MonoBehaviour

{
   private float time = 1f;
   public void nextLevel()
   {
      Invoke("LoadNextScene",time);
   }
   public void RestartGame()
   {
     Invoke("LoadIntro",time);
   }

   public void LoadFirstLevel()
   {
      Invoke("LoadLevelOne",1f);
   }

   public void LoadLevelOne()
   {
      SceneManager.LoadScene("Level01");
   }
   public void LoadIntro()
   {
      PlayerPrefs.SetInt("TIMES",3);
      SceneManager.LoadScene("Intro");
   }

   public void LoadNextScene()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
   
}
