using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public int HealthPoint;
    public int HungerPoint;
    double timer = 0;
    public Slider HP;
    public Slider Hunger;
    public GameObject gameover;
    void Start()
    {
        HealthPoint = 100;
        HungerPoint = 100;
        HP.value = 1;
        Hunger.value = 1;
        gameover.SetActive(false);
    }
    public void GameOver() 
    {
        Time.timeScale = 0;                  
        gameover.SetActive(true);                
    }
    public void Restart() 
    {
        SceneManager.LoadScene(0);       
        Time.timeScale = 1;                        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)) {
            HungerPoint -= 100;
            if(HungerPoint < 0) HungerPoint = 0;
            Debug.Log("Have Pressed P");
        }
        timer += Time.deltaTime;
        if(HealthPoint <= 0) {
        //  Destroy(gameObject);
            GameOver();
            if(Input.GetKeyDown(KeyCode.R)) {
                Restart();
            }
        }
        else {
            if(timer >= 1) {
                HungerPoint -= 2;
                if(HungerPoint < 0) HungerPoint = 0;
                if(HungerPoint <= 0 ) {
                    HealthPoint -= 2;
                    if(HealthPoint < 0) HealthPoint = 0;
                }
                timer = 0;
                HP.value = HealthPoint / 100f;
                Hunger.value = HungerPoint / 100f;
            }
            
        }
    }
}
