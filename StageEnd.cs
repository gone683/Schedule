using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageEnd : MonoBehaviour
{
    public bool fastPlay;
    public bool fastOn;
    public int[] stageClear;
    public int ClearStar;
    public int ClearStarSample;
    public int StageNo;
    public float Vic_curTime;
    public bool Vic_cur;
    


    [Header("# Bonus")]
    public int[] Bonus_Enagy;
    public float[] Bonus_Gold;
    public float[] Bonus_Exp;
    public int Accpet_Enagy;
    public int Accpet_Gold;
    public float Accpet_Exp;

    [Header("# Clear Score")]
    public float clearHp1;
    public float clearHp2;
    public float clearHp3;
    public float clearScore1;
    public float clearScore2;
    public float clearScore3;


    [Header("# Object")]
    public GameObject gameStop;
    public GameObject gameClear;
    public GameObject Bonus_EangyObj;
    public GameObject Bonus_GoldObj;
    public GameObject Bonus_ExpObj;
    public GameObject gameLose;
    public GameObject normalSpeed;
    public GameObject fastSpeed;
    public GameObject fastSpeedWindow;
    public GameObject reCircle1;
    public GameObject reCircle2;
    public GameObject gameExit;
    public GameObject Victory;
    public GameObject victoryOnbtn;
    public GameObject VictoryOffbtn;
    public GameObject Sk1_x;
    public GameObject Sk2_x;
    public GameObject Sk3_x;
    public GameObject Sk4_x;
    public GameObject Sk5_x;
    public GameObject guide;

    [Header("# Clear StarObj")]
    public GameObject[] clearStarobj;
    

    public float curGuideTime;




    void Start()   
    {
        GameManager.instance.gameCount = PlayerPrefs.GetInt("GameCount");
        StageNo = SceneManager.GetActiveScene().buildIndex;        
        fastPlay = false;
        fastOn = false;
        if (SceneManager.GetActiveScene().name != "Lobby")
        {
            Victory.SetActive(true);
            Vic_cur = true;
            clearHp3 = 60 + (GameManager.instance.StageValue18 * 20);
            clearHp2 = Mathf.Round((clearHp3 / 2) / 10) * 10;
            clearHp1 = 0;
            if (GameManager.instance.StageValue6 == 1) clearScore3 = 3000;
            else if (GameManager.instance.StageValue6 == 2 || GameManager.instance.StageValue6 == 4) clearScore3 = 4000;
            else if (GameManager.instance.StageValue6 == 3 || GameManager.instance.StageValue6 == 5) clearScore3 = 5000;
            else if (GameManager.instance.StageValue6 == 6 || GameManager.instance.StageValue6 == 7) clearScore3 = 6000;
            else if (GameManager.instance.StageValue6 == 8 || GameManager.instance.StageValue6 == 10) clearScore3 = 8000;
            else if (GameManager.instance.StageValue6 == 9 || GameManager.instance.StageValue6 == 11 || GameManager.instance.StageValue6 == 13) clearScore3 = 10000;
            else if (GameManager.instance.StageValue6 == 12) clearScore3 = 12000;
            else if (GameManager.instance.StageValue6 == 14 || GameManager.instance.StageValue6 == 16) clearScore3 = 14000;
            else if (GameManager.instance.StageValue6 == 15 || GameManager.instance.StageValue6 == 17) clearScore3 = 18000;
            else if (GameManager.instance.StageValue6 == 19 || GameManager.instance.StageValue6 == 22 || GameManager.instance.StageValue6 == 25 || GameManager.instance.StageValue6 == 28) clearScore3 = 15000;
            else if (GameManager.instance.StageValue6 == 18) clearScore3 = 22000;
            else if (GameManager.instance.StageValue6 == 20) clearScore3 = 20000;
            else if (GameManager.instance.StageValue6 == 21) clearScore3 = 25000;
            else if (GameManager.instance.StageValue6 == 23) clearScore3 = 22000;
            else if (GameManager.instance.StageValue6 == 24) clearScore3 = 29000;
            else if (GameManager.instance.StageValue6 == 26) clearScore3 = 24000;
            else if (GameManager.instance.StageValue6 == 27) clearScore3 = 33000;
            else if (GameManager.instance.StageValue6 == 29) clearScore3 = 30000;
            else if (GameManager.instance.StageValue6 == 30) clearScore3 = 45000;
            clearScore2 = Mathf.Round((clearScore3 / 2) / 10) * 10;
            clearScore1 = 0;
            Bonus_Enagy[3] = 2;
            Bonus_Enagy[2] = 1;
            if(GameManager.instance.StageValue6 == 1)
            {
                Bonus_Gold[3] = 100;
                Bonus_Exp[3] = 100;
            }
            else if (GameManager.instance.StageValue6 == 2)
            {
                Bonus_Gold[3] = 300;
                Bonus_Exp[3] =  250;
            }
            else if (GameManager.instance.StageValue6 == 3)
            {
                Bonus_Gold[3] = 550;
                Bonus_Exp[3] =  450;
            }
            else if (GameManager.instance.StageValue6 == 4)
            {
                Bonus_Gold[3] = 250;
                Bonus_Exp[3] =  250;
            }
            else if (GameManager.instance.StageValue6 == 5)
            {
                Bonus_Gold[3] = 550;
                Bonus_Exp[3] =  450;
            }
            else if (GameManager.instance.StageValue6 == 6)
            {
                Bonus_Gold[3] = 900;
                Bonus_Exp[3] =  700;
            }
            else if (GameManager.instance.StageValue6 == 7)
            {
                Bonus_Gold[3] = 500;
                Bonus_Exp[3] =  400;
            }
            else if (GameManager.instance.StageValue6 == 8)
            {
                Bonus_Gold[3] = 950;
                Bonus_Exp[3] = 650;
            }
            else if (GameManager.instance.StageValue6 == 9)
            {
                Bonus_Gold[3] = 1500;
                Bonus_Exp[3] =  950;
            }
            else if (GameManager.instance.StageValue6 == 10)
            {
                Bonus_Gold[3] = 700;
                Bonus_Exp[3] =  550;
            }
            else if (GameManager.instance.StageValue6 == 11)
            {
                Bonus_Gold[3] = 1200;
                Bonus_Exp[3] =  800;
            }
            else if (GameManager.instance.StageValue6 == 12)
            {
                Bonus_Gold[3] = 1800;
                Bonus_Exp[3] =  1150;
            }
            else if (GameManager.instance.StageValue6 == 13)
            {
                Bonus_Gold[3] = 1200;
                Bonus_Exp[3] =  700;
            }
            else if (GameManager.instance.StageValue6 == 14)
            {
                Bonus_Gold[3] = 1800;
                Bonus_Exp[3] =  1050;
            }
            else if (GameManager.instance.StageValue6 == 15)
            {
                Bonus_Gold[3] = 2700;
                Bonus_Exp[3] =  1550;
            }
            else if (GameManager.instance.StageValue6 == 16)
            {
                Bonus_Gold[3] = 1400;
                Bonus_Exp[3] =  850;
            }
            else if (GameManager.instance.StageValue6 == 17)
            {
                Bonus_Gold[3] = 2100;
                Bonus_Exp[3] =  1350;
            }
            else if (GameManager.instance.StageValue6 == 18)
            {
                Bonus_Gold[3] = 3100;
                Bonus_Exp[3] =  1950;
            }
            else if (GameManager.instance.StageValue6 == 19)
            {
                Bonus_Gold[3] = 2100;
                Bonus_Exp[3] =  1250;
            }
            else if (GameManager.instance.StageValue6 == 20)
            {
                Bonus_Gold[3] = 2900;
                Bonus_Exp[3] =  1750;
            }
            else if (GameManager.instance.StageValue6 == 21)
            {
                Bonus_Gold[3] = 3700;
                Bonus_Exp[3] =  2350;
            }
            else if (GameManager.instance.StageValue6 == 22)
            {
                Bonus_Gold[3] = 2400;
                Bonus_Exp[3] =  1650;
            }
            else if (GameManager.instance.StageValue6 == 23)
            {
                Bonus_Gold[3] = 3300;
                Bonus_Exp[3] =  2150;
            }
            else if (GameManager.instance.StageValue6 == 24)
            {
                Bonus_Gold[3] = 4300;
                Bonus_Exp[3] =  2750;
            }
            else if (GameManager.instance.StageValue6 == 25)
            {
                Bonus_Gold[3] = 2700;
                Bonus_Exp[3] =  1850;
            }
            else if (GameManager.instance.StageValue6 == 26)
            {
                Bonus_Gold[3] = 3700;
                Bonus_Exp[3] =  2350;
            }
            else if (GameManager.instance.StageValue6 == 27)
            {
                Bonus_Gold[3] = 4700;
                Bonus_Exp[3] =  2950;
            }
            else if (GameManager.instance.StageValue6 == 28)
            {
                Bonus_Gold[3] = 3100;
                Bonus_Exp[3] =  2050;
            }
            else if (GameManager.instance.StageValue6 == 29)
            {
                Bonus_Gold[3] = 4100;
                Bonus_Exp[3] =  2550;
            }
            else if (GameManager.instance.StageValue6 == 30)
            {
                Bonus_Gold[3] = 5300;
                Bonus_Exp[3] =  3150;
            }
            
            for(int i = 3; i <= 180; i += 3)
            {
                if(i == GameManager.instance.StageValue1)
                {
                    Bonus_Gold[3] *= 1.5f;
                    Bonus_Exp[3] *= 1.5f;
                    Bonus_Enagy[3] = 4;
                    Bonus_Enagy[2] = 2;
                }
            }
            Bonus_Gold[2] = Mathf.Round((Bonus_Gold[3] / 2) / 10) * 10;
            Bonus_Gold[1] = Mathf.Round((Bonus_Gold[2] * 2 / 3) / 10) * 10;
            Bonus_Gold[0] = Mathf.Round((Bonus_Gold[2] * 1 / 3) / 10) * 10;
            Bonus_Exp[2] = Mathf.Round((Bonus_Exp[3] / 2) / 10) * 10;
            Bonus_Exp[1] = Mathf.Round((Bonus_Exp[2] * 2 / 3) / 10) * 10;
            Bonus_Exp[0] = Mathf.Round((Bonus_Exp[2] * 1 / 3) / 10) * 10;

        }
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (GameManager.instance.isLive == false) return;

        curGuideTime += Time.deltaTime;
        if (curGuideTime >= 5 && GameManager.instance.gameTime > 10f && GameManager.instance.gameTime != GameManager.instance.maxGameTime)
        {
            guide.SetActive(true);
        }
        else
        {
            guide.SetActive(false);
        }
        

        if(Vic_cur == true)
        {
            Vic_curTime += Time.deltaTime;
            if(Vic_curTime >= 3f)
            {
                Victory.SetActive(false);
                victoryOnbtn.SetActive(true);
                VictoryOffbtn.SetActive(false);
                Vic_curTime = 0;
                Vic_cur = false;
            }
        }
        else
        {
            Vic_curTime = 0;
        }
        
    }
    public void Stop()
    {
        GameManager.instance.isLive = false;
        AudioManager.instance.PlaySfx(AudioManager.Sfx.NoramlBTN);
        gameStop.SetActive(true);
        Time.timeScale = 0;
    }
    public void Resume()
    {
        GameManager.instance.isLive = true;
        AudioManager.instance.PlaySfx(AudioManager.Sfx.NoramlBTN);
        gameStop.SetActive(false);
        reCircle1.SetActive(false);
        reCircle2.SetActive(false);
        fastSpeedWindow.SetActive(false);
        if(fastOn == true) Time.timeScale = 1.5f;
        else Time.timeScale = 1;
    }
    public void FastSpeed()
    {
        AudioManager.instance.PlaySfx(AudioManager.Sfx.NoramlBTN);
        if (GameManager.instance.fastPlayShop == true)
        {
            GameManager.instance.isLive = true;
            fastSpeed.SetActive(true);
            fastOn = true;
            Time.timeScale = 1.5f;
            normalSpeed.SetActive(false);
        }
        else
        {
            if (fastPlay == false)
            {
                GameManager.instance.isLive = false;
                fastSpeedWindow.SetActive(true);
                Time.timeScale = 0f;
            }
            else if (fastPlay == true)
            {
                GameManager.instance.isLive = true;
                fastSpeed.SetActive(true);
                Time.timeScale = 1.5f;
                fastOn = true;
                normalSpeed.SetActive(false);
            }
        }
   
    }
    public void FastSpeed_On()
    {
        AudioManager.instance.PlaySfx(AudioManager.Sfx.NoramlBTN);
        GameManager.instance.isLive = true;
        fastPlay = true;
        fastSpeedWindow.SetActive(false);
        fastSpeed.SetActive(true);
        Time.timeScale = 1.5f;
        fastOn = true;
        normalSpeed.SetActive(false);
    }
    public void NormalSpeed()
    {
        AudioManager.instance.PlaySfx(AudioManager.Sfx.NoramlBTN);
        GameManager.instance.isLive = true;
        fastSpeed.SetActive(false);
        fastOn = false;
        Time.timeScale = 1f;
        normalSpeed.SetActive(true);
    }

    public void ReCirclebtn()
    {
        GameManager.instance.isLive = false;
        AudioManager.instance.PlaySfx(AudioManager.Sfx.NoramlBTN);
        Time.timeScale = 0f;
        if (GameManager.instance.reCircle > 0)
        {
            reCircle2.SetActive(true);
        }
        else
        {
            reCircle1.SetActive(true);
        }
    }
    public void ReCircle_On()
    {
        GameManager.instance.isLive = true;
        AudioManager.instance.PlaySfx(AudioManager.Sfx.NoramlBTN);
        GameManager.instance.reCircle += 3;
        Time.timeScale = 0f;
        reCircle1.SetActive(false);
        reCircle2.SetActive(true);
    }
    public void ReCircle_Sound()
    {
        AudioManager.instance.PlaySfx(AudioManager.Sfx.Recircle);
    }
    
    public void goHome()
    {        
        AudioManager.instance.PlaySfx(AudioManager.Sfx.NoramlBTN);
        if (GameManager.instance.buffCurtime >= GameManager.instance.buffMaxtime)
        {
                GameManager.instance.buffCurtime = 0;
                GameManager.instance.buff = 0;
        }
        GameManager.instance.SaveAcceptEenergy = 0;
        GameManager.instance.gameCount++;
        PlayerPrefs.SetInt("SaveAcceptEenergy", GameManager.instance.SaveAcceptEenergy);
        PlayerPrefs.SetInt("GameCount", GameManager.instance.gameCount);
        PlayerPrefs.Save();
        GameManager.instance.Save();
        SceneManager.LoadScene(0);
        
        if (GameManager.instance.gameCount >2)
        {

            GameManager.instance.admobManager.ShowAd();
            GameManager.instance.gameCount = -1;
            PlayerPrefs.SetInt("GameCount", GameManager.instance.gameCount);
            PlayerPrefs.Save();
            
        }
           

    }
    public void Timestop()
    {
        Time.timeScale = 0;
        AudioManager.instance.PlaySfx(AudioManager.Sfx.NoramlBTN);
    }

    public void ReStart()
    {        
        AudioManager.instance.PlaySfx(AudioManager.Sfx.NoramlBTN);
        if (GameManager.instance.buffCurtime >= GameManager.instance.buffMaxtime)
        {
            GameManager.instance.buffCurtime = 0;
            GameManager.instance.buff = 0;
        }
        GameManager.instance.gameCount++;
        PlayerPrefs.SetInt("GameCount", GameManager.instance.gameCount);
        PlayerPrefs.Save();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GameManager.instance.Setting_Save();
        if (GameManager.instance.gameCount >2)
        {
            GameManager.instance.intersadsNo = 1;
            GameManager.instance.admobManager.ShowAd();
            GameManager.instance.gameCount = -1;
            PlayerPrefs.SetInt("GameCount", GameManager.instance.gameCount);
            PlayerPrefs.Save();
        }
    }
    public void VictoryWindowOn_Btn()
    {
        Vic_cur = true;
    }
    public void VictoryWindowOff_Btn()
    {
        Vic_cur = false;
    }

    
    public void GameWin()
    {
        AudioManager.instance.PlaySfx(AudioManager.Sfx.Win);
        clearStarobj[0].SetActive(false);
        clearStarobj[1].SetActive(false);
        clearStarobj[2].SetActive(false);        
        Bonus_EangyObj.SetActive(false);
        Bonus_GoldObj.SetActive(false);
        Bonus_ExpObj.SetActive(false);
        ClearStar = stageClear[StageNo];
        if (stageClear[StageNo] == 0)
        {           
            if (GameManager.instance.levelObject.currentScore >= clearScore3 && clearHp3 <= GameManager.instance.health)
            {                
                clearStarobj[2].SetActive(true);                            
                Bonus_GoldObj.SetActive(true);
                Bonus_ExpObj.SetActive(true);
                Bonus_EangyObj.SetActive(true);
                ClearStar = 3;
                
                Accpet_Gold = (int)Bonus_Gold[3];
                Accpet_Exp = Bonus_Exp[3];
                Accpet_Enagy = Bonus_Enagy[3];
            }
            else if (GameManager.instance.levelObject.currentScore >= clearScore2 && clearHp2 <= GameManager.instance.health)
            {
                clearStarobj[1].SetActive(true);                
                Bonus_GoldObj.SetActive(true);
                Bonus_ExpObj.SetActive(true);
                Bonus_EangyObj.SetActive(true);
                ClearStar = 2;                
                Accpet_Gold = (int)Bonus_Gold[2];
                Accpet_Exp = Bonus_Exp[2];
                Accpet_Enagy = Bonus_Enagy[2];
            }
            else if (GameManager.instance.levelObject.currentScore >= clearScore1 && clearHp1 <= GameManager.instance.health)
            {
                clearStarobj[0].SetActive(true);
                Bonus_GoldObj.SetActive(true);
                Bonus_ExpObj.SetActive(true);
                ClearStar = 1;
                Accpet_Gold = (int)Bonus_Gold[1];
                Accpet_Exp = Bonus_Exp[1];

            }           
            
        }
        else if (stageClear[StageNo] == 1)
        {
            if (GameManager.instance.levelObject.currentScore >= clearScore3 && clearHp3 <= GameManager.instance.health)
            {
                clearStarobj[2].SetActive(true);
                Bonus_GoldObj.SetActive(true);
                Bonus_ExpObj.SetActive(true);
                Bonus_EangyObj.SetActive(true);
                ClearStar = 3;                
                Accpet_Gold = (int)Bonus_Gold[3] - (int)Bonus_Gold[1];
                Accpet_Exp = Bonus_Exp[3] - Bonus_Exp[1];
                Accpet_Enagy = (Bonus_Enagy[3] - Bonus_Enagy[1]);
            }
            else if (GameManager.instance.levelObject.currentScore >= clearScore2 && clearHp2 <= GameManager.instance.health)
            {
                clearStarobj[1].SetActive(true);
                Bonus_GoldObj.SetActive(true);
                Bonus_ExpObj.SetActive(true);
                Bonus_EangyObj.SetActive(true);
                ClearStar = 2;                
                Accpet_Gold = (int)Bonus_Gold[2] - (int)Bonus_Gold[1];
                Accpet_Exp = Bonus_Exp[2] - Bonus_Exp[1];
                Accpet_Enagy = (Bonus_Enagy[2] - Bonus_Enagy[1]);
            }
            else if (GameManager.instance.levelObject.currentScore >= clearScore1 && clearHp1 <= GameManager.instance.health)
            {
                clearStarobj[0].SetActive(true);
                Bonus_GoldObj.SetActive(true);
                Bonus_ExpObj.SetActive(true);
                ClearStar = 1;
                Accpet_Gold = (int)Bonus_Gold[0];
                Accpet_Exp = Bonus_Exp[0];
            }           
            
        }
        else if (stageClear[StageNo] == 2)
        {
            if (GameManager.instance.levelObject.currentScore >= clearScore3 && clearHp3 <= GameManager.instance.health)
            {
                clearStarobj[2].SetActive(true);
                Bonus_GoldObj.SetActive(true);
                Bonus_ExpObj.SetActive(true);
                Bonus_EangyObj.SetActive(true);
                ClearStar = 3;                
                Accpet_Gold = (int)Bonus_Gold[3] - (int)Bonus_Gold[2];
                Accpet_Exp = Bonus_Exp[3] - Bonus_Exp[2];
                Accpet_Enagy = (Bonus_Enagy[3] - Bonus_Enagy[2]);
            }
            else if (GameManager.instance.levelObject.currentScore >= clearScore2 && clearHp2 <= GameManager.instance.health)
            {
                clearStarobj[1].SetActive(true);
                Bonus_GoldObj.SetActive(true);
                Bonus_ExpObj.SetActive(true);
                ClearStar = 2;
                Accpet_Gold = (int)Bonus_Gold[0];
                Accpet_Exp = Bonus_Exp[0];
            }
            else if (GameManager.instance.levelObject.currentScore >= clearScore1 && clearHp1 <= GameManager.instance.health)
            {
                clearStarobj[0].SetActive(true);
                Bonus_GoldObj.SetActive(true);
                Bonus_ExpObj.SetActive(true);
                ClearStar = 2;
                Accpet_Gold = (int)Bonus_Gold[0];
                Accpet_Exp = Bonus_Exp[0];            
            }                    
            
        }
        else if (stageClear[StageNo] == 3)
        {
            if (GameManager.instance.levelObject.currentScore >= clearScore3 && clearHp3 <= GameManager.instance.health)
            {
                clearStarobj[2].SetActive(true);
                Bonus_GoldObj.SetActive(true);
                Bonus_ExpObj.SetActive(true);
                ClearStar = 3;
                Accpet_Gold = (int)Bonus_Gold[0];
                Accpet_Exp = Bonus_Exp[0];
            }
            else if (GameManager.instance.levelObject.currentScore >= clearScore2 && clearHp2 <= GameManager.instance.health)
            {
                clearStarobj[1].SetActive(true);
                Bonus_GoldObj.SetActive(true);
                Bonus_ExpObj.SetActive(true);
                ClearStar = 3;
                Accpet_Gold = (int)Bonus_Gold[0];
                Accpet_Exp = Bonus_Exp[0];
            }
            else if (GameManager.instance.levelObject.currentScore >= clearScore1 && clearHp1 <= GameManager.instance.health)
            {
                clearStarobj[0].SetActive(true);
                Bonus_GoldObj.SetActive(true);
                Bonus_ExpObj.SetActive(true);
                ClearStar = 3;
                Accpet_Gold = (int)Bonus_Gold[0];
                Accpet_Exp = Bonus_Exp[0];
            }
        }        
        stageClear[StageNo] = ClearStar;                
        gameClear.SetActive(true);

    }
    public void GameLose()
    {
        if (GameManager.instance.buffCurtime >= GameManager.instance.buffMaxtime)
        {
            GameManager.instance.buffCurtime = 0;
            GameManager.instance.buff = 0;
        }
        
        gameLose.SetActive(true);
        AudioManager.instance.PlaySfx(AudioManager.Sfx.Lose);
    }   

    public void ClearAccept()
    {
        AudioManager.instance.PlaySfx(AudioManager.Sfx.NoramlBTN);
            float remainExp;

            GameManager.instance.SaveAcceptEenergy = Accpet_Enagy;
            GameManager.instance.gold += Accpet_Gold;
            GameManager.instance.exp += Accpet_Exp;
            if (GameManager.instance.exp >= GameManager.instance.nextExp[Mathf.Min(GameManager.instance.playerLevel, GameManager.instance.nextExp.Length - 1)])
            {
                remainExp = GameManager.instance.exp - GameManager.instance.nextExp[Mathf.Min(GameManager.instance.playerLevel, GameManager.instance.nextExp.Length - 1)];
                GameManager.instance.playerLevel++;
                GameManager.instance.playerLevelPoint += 3;
                GameManager.instance.exp = remainExp;
                AudioManager.instance.PlaySfx(AudioManager.Sfx.LevelUp);
            }
            if (GameManager.instance.exp >= GameManager.instance.nextExp[Mathf.Min(GameManager.instance.playerLevel, GameManager.instance.nextExp.Length - 1)])
            {
                remainExp = GameManager.instance.exp - GameManager.instance.nextExp[Mathf.Min(GameManager.instance.playerLevel, GameManager.instance.nextExp.Length - 1)];
                GameManager.instance.playerLevel++;
                GameManager.instance.playerLevelPoint += 3;
                GameManager.instance.exp = remainExp;
                AudioManager.instance.PlaySfx(AudioManager.Sfx.LevelUp);
            }
            if (GameManager.instance.exp >= GameManager.instance.nextExp[Mathf.Min(GameManager.instance.playerLevel, GameManager.instance.nextExp.Length - 1)])
            {
                remainExp = GameManager.instance.exp - GameManager.instance.nextExp[Mathf.Min(GameManager.instance.playerLevel, GameManager.instance.nextExp.Length - 1)];
                GameManager.instance.playerLevel++;
                GameManager.instance.playerLevelPoint += 3;
                GameManager.instance.exp = remainExp;
                AudioManager.instance.PlaySfx(AudioManager.Sfx.LevelUp);
            }

            if (GameManager.instance.buffCurtime >= GameManager.instance.buffMaxtime)
            {
                GameManager.instance.buffCurtime = 0;
                GameManager.instance.buff = 0;
            }
            StageSave();
            PlayerPrefs.SetInt("SaveAcceptEenergy", GameManager.instance.SaveAcceptEenergy);
            GameManager.instance.Save();
            GameManager.instance.gameCount++;            
            PlayerPrefs.SetInt("GameCount", GameManager.instance.gameCount);
            PlayerPrefs.Save();
            SceneManager.LoadScene(0);
        
        if (GameManager.instance.gameCount >2)
        {
            GameManager.instance.intersadsNo = 3;
            GameManager.instance.admobManager.ShowAd();
            GameManager.instance.gameCount = -1;
            PlayerPrefs.SetInt("GameCount", GameManager.instance.gameCount);
            PlayerPrefs.Save();
        }
    }
    public void ClearAccept_Reward()
    {
        GameManager.instance.adsStart = 1;
    }
        
    public void ClearAccept_2()
    {
        AudioManager.instance.PlaySfx(AudioManager.Sfx.NoramlBTN);
        float remainExp;
        GameManager.instance.SaveAcceptEenergy = Accpet_Enagy * 2;
        GameManager.instance.gold += Accpet_Gold*2;
        GameManager.instance.exp += Accpet_Exp*2;
        if (GameManager.instance.exp >= GameManager.instance.nextExp[Mathf.Min(GameManager.instance.playerLevel, GameManager.instance.nextExp.Length - 1)])
        {
            remainExp = GameManager.instance.exp - GameManager.instance.nextExp[Mathf.Min(GameManager.instance.playerLevel, GameManager.instance.nextExp.Length - 1)];
            GameManager.instance.playerLevel++;
            GameManager.instance.playerLevelPoint += 3;
            GameManager.instance.exp = remainExp;
            AudioManager.instance.PlaySfx(AudioManager.Sfx.LevelUp);
        }
        if (GameManager.instance.exp >= GameManager.instance.nextExp[Mathf.Min(GameManager.instance.playerLevel, GameManager.instance.nextExp.Length - 1)])
        {
            remainExp = GameManager.instance.exp - GameManager.instance.nextExp[Mathf.Min(GameManager.instance.playerLevel, GameManager.instance.nextExp.Length - 1)];
            GameManager.instance.playerLevel++;
            GameManager.instance.playerLevelPoint += 3;
            GameManager.instance.exp = remainExp;
            AudioManager.instance.PlaySfx(AudioManager.Sfx.LevelUp);
        }
        if (GameManager.instance.exp >= GameManager.instance.nextExp[Mathf.Min(GameManager.instance.playerLevel, GameManager.instance.nextExp.Length - 1)])
        {
            remainExp = GameManager.instance.exp - GameManager.instance.nextExp[Mathf.Min(GameManager.instance.playerLevel, GameManager.instance.nextExp.Length - 1)];
            GameManager.instance.playerLevel++;
            GameManager.instance.playerLevelPoint += 3;
            GameManager.instance.exp = remainExp;
            AudioManager.instance.PlaySfx(AudioManager.Sfx.LevelUp);
        }
        if (GameManager.instance.buffCurtime >= GameManager.instance.buffMaxtime)
        {
            GameManager.instance.buffCurtime = 0;
            GameManager.instance.buff = 0;
        }
        StageSave();
        PlayerPrefs.SetInt("SaveAcceptEenergy", GameManager.instance.SaveAcceptEenergy);        
        GameManager.instance.Save();        
        SceneManager.LoadScene(0);

    }
    public void BtnSound()
    {
        AudioManager.instance.PlaySfx(AudioManager.Sfx.NoramlBTN);
    }
        public void StageSave()
    {
        PlayerPrefs.SetInt("StageClear1_1", stageClear[1]);
        PlayerPrefs.SetInt("StageClear1_2", stageClear[2]);
        PlayerPrefs.SetInt("StageClear1_3", stageClear[3]);
        PlayerPrefs.SetInt("StageClear1_4", stageClear[4]);
        PlayerPrefs.SetInt("StageClear1_5", stageClear[5]);
        PlayerPrefs.SetInt("StageClear1_6", stageClear[6]);
        PlayerPrefs.SetInt("StageClear1_7", stageClear[7]);
        PlayerPrefs.SetInt("StageClear1_8", stageClear[8]);
        PlayerPrefs.SetInt("StageClear1_9", stageClear[9]);
        PlayerPrefs.SetInt("StageClear1_10", stageClear[10]);
        PlayerPrefs.SetInt("StageClear1_11", stageClear[11]);
        PlayerPrefs.SetInt("StageClear1_12", stageClear[12]);
        PlayerPrefs.SetInt("StageClear1_13", stageClear[13]);
        PlayerPrefs.SetInt("StageClear1_14", stageClear[14]);
        PlayerPrefs.SetInt("StageClear1_15", stageClear[15]);
        PlayerPrefs.SetInt("StageClear1_16", stageClear[16]);
        PlayerPrefs.SetInt("StageClear1_17", stageClear[17]);
        PlayerPrefs.SetInt("StageClear1_18", stageClear[18]);
        PlayerPrefs.SetInt("StageClear2_1", stageClear[19]);
        PlayerPrefs.SetInt("StageClear2_2", stageClear[20]);
        PlayerPrefs.SetInt("StageClear2_3", stageClear[21]);
        PlayerPrefs.SetInt("StageClear2_4", stageClear[22]);
        PlayerPrefs.SetInt("StageClear2_5", stageClear[23]);
        PlayerPrefs.SetInt("StageClear2_6", stageClear[24]);
        PlayerPrefs.SetInt("StageClear2_7", stageClear[25]);
        PlayerPrefs.SetInt("StageClear2_8", stageClear[26]);
        PlayerPrefs.SetInt("StageClear2_9", stageClear[27]);
        PlayerPrefs.SetInt("StageClear2_10", stageClear[28]);
        PlayerPrefs.SetInt("StageClear2_11", stageClear[29]);
        PlayerPrefs.SetInt("StageClear2_12", stageClear[30]);
        PlayerPrefs.SetInt("StageClear2_13", stageClear[31]);
        PlayerPrefs.SetInt("StageClear2_14", stageClear[32]);
        PlayerPrefs.SetInt("StageClear2_15", stageClear[33]);
        PlayerPrefs.SetInt("StageClear2_16", stageClear[34]);
        PlayerPrefs.SetInt("StageClear2_17", stageClear[35]);
        PlayerPrefs.SetInt("StageClear2_18", stageClear[36]);
        PlayerPrefs.SetInt("StageClear3_1", stageClear[37]);
        PlayerPrefs.SetInt("StageClear3_2", stageClear[38]);
        PlayerPrefs.SetInt("StageClear3_3", stageClear[39]);
        PlayerPrefs.SetInt("StageClear3_4", stageClear[40]);
        PlayerPrefs.SetInt("StageClear3_5", stageClear[41]);
        PlayerPrefs.SetInt("StageClear3_6", stageClear[42]);
        PlayerPrefs.SetInt("StageClear3_7", stageClear[43]);
        PlayerPrefs.SetInt("StageClear3_8", stageClear[44]);
        PlayerPrefs.SetInt("StageClear3_9", stageClear[45]);
        PlayerPrefs.SetInt("StageClear3_10", stageClear[46]);
        PlayerPrefs.SetInt("StageClear3_11", stageClear[47]);
        PlayerPrefs.SetInt("StageClear3_12", stageClear[48]);
        PlayerPrefs.SetInt("StageClear3_13", stageClear[49]);
        PlayerPrefs.SetInt("StageClear3_14", stageClear[50]);
        PlayerPrefs.SetInt("StageClear3_15", stageClear[51]);
        PlayerPrefs.SetInt("StageClear3_16", stageClear[52]);
        PlayerPrefs.SetInt("StageClear3_17", stageClear[53]);
        PlayerPrefs.SetInt("StageClear3_18", stageClear[54]);
        PlayerPrefs.SetInt("StageClear4_1", stageClear[55]);
        PlayerPrefs.SetInt("StageClear4_2", stageClear[56]);
        PlayerPrefs.SetInt("StageClear4_3", stageClear[57]);
        PlayerPrefs.SetInt("StageClear4_4", stageClear[58]);
        PlayerPrefs.SetInt("StageClear4_5", stageClear[59]);
        PlayerPrefs.SetInt("StageClear4_6", stageClear[60]);
        PlayerPrefs.SetInt("StageClear4_7", stageClear[61]);
        PlayerPrefs.SetInt("StageClear4_8", stageClear[62]);
        PlayerPrefs.SetInt("StageClear4_9", stageClear[63]);
        PlayerPrefs.SetInt("StageClear4_10", stageClear[64]);
        PlayerPrefs.SetInt("StageClear4_11", stageClear[65]);
        PlayerPrefs.SetInt("StageClear4_12", stageClear[66]);
        PlayerPrefs.SetInt("StageClear4_13", stageClear[67]);
        PlayerPrefs.SetInt("StageClear4_14", stageClear[68]);
        PlayerPrefs.SetInt("StageClear4_15", stageClear[69]);
        PlayerPrefs.SetInt("StageClear4_16", stageClear[70]);
        PlayerPrefs.SetInt("StageClear4_17", stageClear[71]);
        PlayerPrefs.SetInt("StageClear4_18", stageClear[72]);
        PlayerPrefs.SetInt("StageClear5_1", stageClear[73]);
        PlayerPrefs.SetInt("StageClear5_2", stageClear[74]);
        PlayerPrefs.SetInt("StageClear5_3", stageClear[75]);
        PlayerPrefs.SetInt("StageClear5_4", stageClear[76]);
        PlayerPrefs.SetInt("StageClear5_5", stageClear[77]);
        PlayerPrefs.SetInt("StageClear5_6", stageClear[78]);
        PlayerPrefs.SetInt("StageClear5_7", stageClear[79]);
        PlayerPrefs.SetInt("StageClear5_8", stageClear[80]);
        PlayerPrefs.SetInt("StageClear5_9", stageClear[81]);
        PlayerPrefs.SetInt("StageClear5_10", stageClear[82]);
        PlayerPrefs.SetInt("StageClear5_11", stageClear[83]);
        PlayerPrefs.SetInt("StageClear5_12", stageClear[84]);
        PlayerPrefs.SetInt("StageClear5_13", stageClear[85]);
        PlayerPrefs.SetInt("StageClear5_14", stageClear[86]);
        PlayerPrefs.SetInt("StageClear5_15", stageClear[87]);
        PlayerPrefs.SetInt("StageClear5_16", stageClear[88]);
        PlayerPrefs.SetInt("StageClear5_17", stageClear[89]);
        PlayerPrefs.SetInt("StageClear5_18", stageClear[90]);
        PlayerPrefs.SetInt("StageClear6_1", stageClear[91]);
        PlayerPrefs.SetInt("StageClear6_2", stageClear[92]);
        PlayerPrefs.SetInt("StageClear6_3", stageClear[93]);
        PlayerPrefs.SetInt("StageClear6_4", stageClear[94]);
        PlayerPrefs.SetInt("StageClear6_5", stageClear[95]);
        PlayerPrefs.SetInt("StageClear6_6", stageClear[96]);
        PlayerPrefs.SetInt("StageClear6_7", stageClear[97]);
        PlayerPrefs.SetInt("StageClear6_8", stageClear[98]);
        PlayerPrefs.SetInt("StageClear6_9", stageClear[99]);
        PlayerPrefs.SetInt("StageClear6_10", stageClear[100]);
        PlayerPrefs.SetInt("StageClear6_11", stageClear[101]);
        PlayerPrefs.SetInt("StageClear6_12", stageClear[102]);
        PlayerPrefs.SetInt("StageClear6_13", stageClear[103]);
        PlayerPrefs.SetInt("StageClear6_14", stageClear[104]);
        PlayerPrefs.SetInt("StageClear6_15", stageClear[105]);
        PlayerPrefs.SetInt("StageClear6_16", stageClear[106]);
        PlayerPrefs.SetInt("StageClear6_17", stageClear[107]);
        PlayerPrefs.SetInt("StageClear6_18", stageClear[108]);
        PlayerPrefs.SetInt("StageClear7_1", stageClear[109]);
        PlayerPrefs.SetInt("StageClear7_2", stageClear[110]);
        PlayerPrefs.SetInt("StageClear7_3", stageClear[111]);
        PlayerPrefs.SetInt("StageClear7_4", stageClear[112]);
        PlayerPrefs.SetInt("StageClear7_5", stageClear[113]);
        PlayerPrefs.SetInt("StageClear7_6", stageClear[114]);
        PlayerPrefs.SetInt("StageClear7_7", stageClear[115]);
        PlayerPrefs.SetInt("StageClear7_8", stageClear[116]);
        PlayerPrefs.SetInt("StageClear7_9", stageClear[117]);
        PlayerPrefs.SetInt("StageClear7_10", stageClear[118]);
        PlayerPrefs.SetInt("StageClear7_11", stageClear[119]);
        PlayerPrefs.SetInt("StageClear7_12", stageClear[120]);
        PlayerPrefs.SetInt("StageClear7_13", stageClear[121]);
        PlayerPrefs.SetInt("StageClear7_14", stageClear[122]);
        PlayerPrefs.SetInt("StageClear7_15", stageClear[123]);
        PlayerPrefs.SetInt("StageClear7_16", stageClear[124]);
        PlayerPrefs.SetInt("StageClear7_17", stageClear[125]);
        PlayerPrefs.SetInt("StageClear7_18", stageClear[126]);
        PlayerPrefs.SetInt("StageClear8_1", stageClear[127]);
        PlayerPrefs.SetInt("StageClear8_2", stageClear[128]);
        PlayerPrefs.SetInt("StageClear8_3", stageClear[129]);
        PlayerPrefs.SetInt("StageClear8_4", stageClear[130]);
        PlayerPrefs.SetInt("StageClear8_5", stageClear[131]);
        PlayerPrefs.SetInt("StageClear8_6", stageClear[132]);
        PlayerPrefs.SetInt("StageClear8_7", stageClear[133]);
        PlayerPrefs.SetInt("StageClear8_8", stageClear[134]);
        PlayerPrefs.SetInt("StageClear8_9", stageClear[135]);
        PlayerPrefs.SetInt("StageClear8_10", stageClear[136]);
        PlayerPrefs.SetInt("StageClear8_11", stageClear[137]);
        PlayerPrefs.SetInt("StageClear8_12", stageClear[138]);
        PlayerPrefs.SetInt("StageClear8_13", stageClear[139]);
        PlayerPrefs.SetInt("StageClear8_14", stageClear[140]);
        PlayerPrefs.SetInt("StageClear8_15", stageClear[141]);
        PlayerPrefs.SetInt("StageClear8_16", stageClear[142]);
        PlayerPrefs.SetInt("StageClear8_17", stageClear[143]);
        PlayerPrefs.SetInt("StageClear8_18", stageClear[144]);
        PlayerPrefs.SetInt("StageClear9_1", stageClear[145]);
        PlayerPrefs.SetInt("StageClear9_2", stageClear[146]);
        PlayerPrefs.SetInt("StageClear9_3", stageClear[147]);
        PlayerPrefs.SetInt("StageClear9_4", stageClear[148]);
        PlayerPrefs.SetInt("StageClear9_5", stageClear[149]);
        PlayerPrefs.SetInt("StageClear9_6", stageClear[150]);
        PlayerPrefs.SetInt("StageClear9_7", stageClear[151]);
        PlayerPrefs.SetInt("StageClear9_8", stageClear[152]);
        PlayerPrefs.SetInt("StageClear9_9", stageClear[153]);
        PlayerPrefs.SetInt("StageClear9_10", stageClear[154]);
        PlayerPrefs.SetInt("StageClear9_11", stageClear[155]);
        PlayerPrefs.SetInt("StageClear9_12", stageClear[156]);
        PlayerPrefs.SetInt("StageClear9_13", stageClear[157]);
        PlayerPrefs.SetInt("StageClear9_14", stageClear[158]);
        PlayerPrefs.SetInt("StageClear9_15", stageClear[159]);
        PlayerPrefs.SetInt("StageClear9_16", stageClear[160]);
        PlayerPrefs.SetInt("StageClear9_17", stageClear[161]);
        PlayerPrefs.SetInt("StageClear9_18", stageClear[162]);
        PlayerPrefs.SetInt("StageClear10_1", stageClear[163]);
        PlayerPrefs.SetInt("StageClear10_2", stageClear[164]);
        PlayerPrefs.SetInt("StageClear10_3", stageClear[165]);
        PlayerPrefs.SetInt("StageClear10_4", stageClear[166]);
        PlayerPrefs.SetInt("StageClear10_5", stageClear[167]);
        PlayerPrefs.SetInt("StageClear10_6", stageClear[168]);
        PlayerPrefs.SetInt("StageClear10_7", stageClear[169]);
        PlayerPrefs.SetInt("StageClear10_8", stageClear[170]);
        PlayerPrefs.SetInt("StageClear10_9", stageClear[171]);
        PlayerPrefs.SetInt("StageClear10_10", stageClear[172]);
        PlayerPrefs.SetInt("StageClear10_11", stageClear[173]);
        PlayerPrefs.SetInt("StageClear10_12", stageClear[174]);
        PlayerPrefs.SetInt("StageClear10_13", stageClear[175]);
        PlayerPrefs.SetInt("StageClear10_14", stageClear[176]);
        PlayerPrefs.SetInt("StageClear10_15", stageClear[177]);
        PlayerPrefs.SetInt("StageClear10_16", stageClear[178]);
        PlayerPrefs.SetInt("StageClear10_17", stageClear[179]);
        PlayerPrefs.SetInt("StageClear10_18", stageClear[180]);


    }
    public void StageLoad()
    {
        stageClear[1] = PlayerPrefs.GetInt("StageClear1_1");
        stageClear[2] = PlayerPrefs.GetInt("StageClear1_2");
        stageClear[3] = PlayerPrefs.GetInt("StageClear1_3");
        stageClear[4] = PlayerPrefs.GetInt("StageClear1_4");
        stageClear[5] = PlayerPrefs.GetInt("StageClear1_5");
        stageClear[6] = PlayerPrefs.GetInt("StageClear1_6");
        stageClear[7] = PlayerPrefs.GetInt("StageClear1_7");
        stageClear[8] = PlayerPrefs.GetInt("StageClear1_8");
        stageClear[9] = PlayerPrefs.GetInt("StageClear1_9");
        stageClear[10] = PlayerPrefs.GetInt("StageClear1_10");
        stageClear[11] = PlayerPrefs.GetInt("StageClear1_11");
        stageClear[12] = PlayerPrefs.GetInt("StageClear1_12");
        stageClear[13] = PlayerPrefs.GetInt("StageClear1_13");
        stageClear[14] = PlayerPrefs.GetInt("StageClear1_14");
        stageClear[15] = PlayerPrefs.GetInt("StageClear1_15");
        stageClear[16] = PlayerPrefs.GetInt("StageClear1_16");
        stageClear[17] = PlayerPrefs.GetInt("StageClear1_17");
        stageClear[18] = PlayerPrefs.GetInt("StageClear1_18");
        stageClear[19] = PlayerPrefs.GetInt("StageClear2_1");
        stageClear[20] = PlayerPrefs.GetInt("StageClear2_2");
        stageClear[21] = PlayerPrefs.GetInt("StageClear2_3");
        stageClear[22] = PlayerPrefs.GetInt("StageClear2_4");
        stageClear[23] = PlayerPrefs.GetInt("StageClear2_5");
        stageClear[24] = PlayerPrefs.GetInt("StageClear2_6");
        stageClear[25] = PlayerPrefs.GetInt("StageClear2_7");
        stageClear[26] = PlayerPrefs.GetInt("StageClear2_8");
        stageClear[27] = PlayerPrefs.GetInt("StageClear2_9");
        stageClear[28] = PlayerPrefs.GetInt("StageClear2_10");
        stageClear[29] = PlayerPrefs.GetInt("StageClear2_11");
        stageClear[30] = PlayerPrefs.GetInt("StageClear2_12");
        stageClear[31] = PlayerPrefs.GetInt("StageClear2_13");
        stageClear[32] = PlayerPrefs.GetInt("StageClear2_14");
        stageClear[33] = PlayerPrefs.GetInt("StageClear2_15");
        stageClear[34] = PlayerPrefs.GetInt("StageClear2_16");
        stageClear[35] = PlayerPrefs.GetInt("StageClear2_17");
        stageClear[36] = PlayerPrefs.GetInt("StageClear2_18");
        stageClear[37] = PlayerPrefs.GetInt("StageClear3_1");
        stageClear[38] = PlayerPrefs.GetInt("StageClear3_2");
        stageClear[39] = PlayerPrefs.GetInt("StageClear3_3");
        stageClear[40] = PlayerPrefs.GetInt("StageClear3_4");
        stageClear[41] = PlayerPrefs.GetInt("StageClear3_5");
        stageClear[42] = PlayerPrefs.GetInt("StageClear3_6");
        stageClear[43] = PlayerPrefs.GetInt("StageClear3_7");
        stageClear[44] = PlayerPrefs.GetInt("StageClear3_8");
        stageClear[45] = PlayerPrefs.GetInt("StageClear3_9");
        stageClear[46] = PlayerPrefs.GetInt("StageClear3_10");
        stageClear[47] = PlayerPrefs.GetInt("StageClear3_11");
        stageClear[48] = PlayerPrefs.GetInt("StageClear3_12");
        stageClear[49] = PlayerPrefs.GetInt("StageClear3_13");
        stageClear[50] = PlayerPrefs.GetInt("StageClear3_14");
        stageClear[51] = PlayerPrefs.GetInt("StageClear3_15");
        stageClear[52] = PlayerPrefs.GetInt("StageClear3_16");
        stageClear[53] = PlayerPrefs.GetInt("StageClear3_17");
        stageClear[54] = PlayerPrefs.GetInt("StageClear3_18");
        stageClear[55] = PlayerPrefs.GetInt("StageClear4_1");
        stageClear[56] = PlayerPrefs.GetInt("StageClear4_2");
        stageClear[57] = PlayerPrefs.GetInt("StageClear4_3");
        stageClear[58] = PlayerPrefs.GetInt("StageClear4_4");
        stageClear[59] = PlayerPrefs.GetInt("StageClear4_5");
        stageClear[60] = PlayerPrefs.GetInt("StageClear4_6");
        stageClear[61] = PlayerPrefs.GetInt("StageClear4_7");
        stageClear[62] = PlayerPrefs.GetInt("StageClear4_8");
        stageClear[63] = PlayerPrefs.GetInt("StageClear4_9");
        stageClear[64] = PlayerPrefs.GetInt("StageClear4_10");
        stageClear[65] = PlayerPrefs.GetInt("StageClear4_11");
        stageClear[66] = PlayerPrefs.GetInt("StageClear4_12");
        stageClear[67] = PlayerPrefs.GetInt("StageClear4_13");
        stageClear[68] = PlayerPrefs.GetInt("StageClear4_14");
        stageClear[69] = PlayerPrefs.GetInt("StageClear4_15");
        stageClear[70] = PlayerPrefs.GetInt("StageClear4_16");
        stageClear[71] = PlayerPrefs.GetInt("StageClear4_17");
        stageClear[72] = PlayerPrefs.GetInt("StageClear4_18");
        stageClear[73] = PlayerPrefs.GetInt("StageClear5_1");
        stageClear[74] = PlayerPrefs.GetInt("StageClear5_2");
        stageClear[75] = PlayerPrefs.GetInt("StageClear5_3");
        stageClear[76] = PlayerPrefs.GetInt("StageClear5_4");
        stageClear[77] = PlayerPrefs.GetInt("StageClear5_5");
        stageClear[78] = PlayerPrefs.GetInt("StageClear5_6");
        stageClear[79] = PlayerPrefs.GetInt("StageClear5_7");
        stageClear[80] = PlayerPrefs.GetInt("StageClear5_8");
        stageClear[81] = PlayerPrefs.GetInt("StageClear5_9");
        stageClear[82] = PlayerPrefs.GetInt("StageClear5_10");
        stageClear[83] = PlayerPrefs.GetInt("StageClear5_11");
        stageClear[84] = PlayerPrefs.GetInt("StageClear5_12");
        stageClear[85] = PlayerPrefs.GetInt("StageClear5_13");
        stageClear[86] = PlayerPrefs.GetInt("StageClear5_14");
        stageClear[87] = PlayerPrefs.GetInt("StageClear5_15");
        stageClear[88] = PlayerPrefs.GetInt("StageClear5_16");
        stageClear[89] = PlayerPrefs.GetInt("StageClear5_17");
        stageClear[90] = PlayerPrefs.GetInt("StageClear5_18");
        stageClear[91] = PlayerPrefs.GetInt("StageClear6_1");
        stageClear[92] = PlayerPrefs.GetInt("StageClear6_2");
        stageClear[93] = PlayerPrefs.GetInt("StageClear6_3");
        stageClear[94] = PlayerPrefs.GetInt("StageClear6_4");
        stageClear[95] = PlayerPrefs.GetInt("StageClear6_5");
        stageClear[96] = PlayerPrefs.GetInt("StageClear6_6");
        stageClear[97] = PlayerPrefs.GetInt("StageClear6_7");
        stageClear[98] = PlayerPrefs.GetInt("StageClear6_8");
        stageClear[99] = PlayerPrefs.GetInt("StageClear6_9");
        stageClear[100] = PlayerPrefs.GetInt("StageClear6_10");
        stageClear[101] = PlayerPrefs.GetInt("StageClear6_11");
        stageClear[102] = PlayerPrefs.GetInt("StageClear6_12");
        stageClear[103] = PlayerPrefs.GetInt("StageClear6_13");
        stageClear[104] = PlayerPrefs.GetInt("StageClear6_14");
        stageClear[105] = PlayerPrefs.GetInt("StageClear6_15");
        stageClear[106] = PlayerPrefs.GetInt("StageClear6_16");
        stageClear[107] = PlayerPrefs.GetInt("StageClear6_17");
        stageClear[108] = PlayerPrefs.GetInt("StageClear6_18");
        stageClear[109] = PlayerPrefs.GetInt("StageClear7_1");
        stageClear[110] = PlayerPrefs.GetInt("StageClear7_2");
        stageClear[111] = PlayerPrefs.GetInt("StageClear7_3");
        stageClear[112] = PlayerPrefs.GetInt("StageClear7_4");
        stageClear[113] = PlayerPrefs.GetInt("StageClear7_5");
        stageClear[114] = PlayerPrefs.GetInt("StageClear7_6");
        stageClear[115] = PlayerPrefs.GetInt("StageClear7_7");
        stageClear[116] = PlayerPrefs.GetInt("StageClear7_8");
        stageClear[117] = PlayerPrefs.GetInt("StageClear7_9");
        stageClear[118] = PlayerPrefs.GetInt("StageClear7_10");
        stageClear[119] = PlayerPrefs.GetInt("StageClear7_11");
        stageClear[120] = PlayerPrefs.GetInt("StageClear7_12");
        stageClear[121] = PlayerPrefs.GetInt("StageClear7_13");
        stageClear[122] = PlayerPrefs.GetInt("StageClear7_14");
        stageClear[123] = PlayerPrefs.GetInt("StageClear7_15");
        stageClear[124] = PlayerPrefs.GetInt("StageClear7_16");
        stageClear[125] = PlayerPrefs.GetInt("StageClear7_17");
        stageClear[126] = PlayerPrefs.GetInt("StageClear7_18");
        stageClear[127] = PlayerPrefs.GetInt("StageClear8_1");
        stageClear[128] = PlayerPrefs.GetInt("StageClear8_2");
        stageClear[129] = PlayerPrefs.GetInt("StageClear8_3");
        stageClear[130] = PlayerPrefs.GetInt("StageClear8_4");
        stageClear[131] = PlayerPrefs.GetInt("StageClear8_5");
        stageClear[132] = PlayerPrefs.GetInt("StageClear8_6");
        stageClear[133] = PlayerPrefs.GetInt("StageClear8_7");
        stageClear[134] = PlayerPrefs.GetInt("StageClear8_8");
        stageClear[135] = PlayerPrefs.GetInt("StageClear8_9");
        stageClear[136] = PlayerPrefs.GetInt("StageClear8_10");
        stageClear[137] = PlayerPrefs.GetInt("StageClear8_11");
        stageClear[138] = PlayerPrefs.GetInt("StageClear8_12");
        stageClear[139] = PlayerPrefs.GetInt("StageClear8_13");
        stageClear[140] = PlayerPrefs.GetInt("StageClear8_14");
        stageClear[141] = PlayerPrefs.GetInt("StageClear8_15");
        stageClear[142] = PlayerPrefs.GetInt("StageClear8_16");
        stageClear[143] = PlayerPrefs.GetInt("StageClear8_17");
        stageClear[144] = PlayerPrefs.GetInt("StageClear8_18");
        stageClear[145] = PlayerPrefs.GetInt("StageClear9_1");
        stageClear[146] = PlayerPrefs.GetInt("StageClear9_2");
        stageClear[147] = PlayerPrefs.GetInt("StageClear9_3");
        stageClear[148] = PlayerPrefs.GetInt("StageClear9_4");
        stageClear[149] = PlayerPrefs.GetInt("StageClear9_5");
        stageClear[150] = PlayerPrefs.GetInt("StageClear9_6");
        stageClear[151] = PlayerPrefs.GetInt("StageClear9_7");
        stageClear[152] = PlayerPrefs.GetInt("StageClear9_8");
        stageClear[153] = PlayerPrefs.GetInt("StageClear9_9");
        stageClear[154] = PlayerPrefs.GetInt("StageClear9_10");
        stageClear[155] = PlayerPrefs.GetInt("StageClear9_11");
        stageClear[156] = PlayerPrefs.GetInt("StageClear9_12");
        stageClear[157] = PlayerPrefs.GetInt("StageClear9_13");
        stageClear[158] = PlayerPrefs.GetInt("StageClear9_14");
        stageClear[159] = PlayerPrefs.GetInt("StageClear9_15");
        stageClear[160] = PlayerPrefs.GetInt("StageClear9_16");
        stageClear[161] = PlayerPrefs.GetInt("StageClear9_17");
        stageClear[162] = PlayerPrefs.GetInt("StageClear9_18");
        stageClear[163] = PlayerPrefs.GetInt("StageClear10_1");
        stageClear[164] = PlayerPrefs.GetInt("StageClear10_2");
        stageClear[165] = PlayerPrefs.GetInt("StageClear10_3");
        stageClear[166] = PlayerPrefs.GetInt("StageClear10_4");
        stageClear[167] = PlayerPrefs.GetInt("StageClear10_5");
        stageClear[168] = PlayerPrefs.GetInt("StageClear10_6");
        stageClear[169] = PlayerPrefs.GetInt("StageClear10_7");
        stageClear[170] = PlayerPrefs.GetInt("StageClear10_8");
        stageClear[171] = PlayerPrefs.GetInt("StageClear10_9");
        stageClear[172] = PlayerPrefs.GetInt("StageClear10_10");
        stageClear[173] = PlayerPrefs.GetInt("StageClear10_11");
        stageClear[174] = PlayerPrefs.GetInt("StageClear10_12");
        stageClear[175] = PlayerPrefs.GetInt("StageClear10_13");
        stageClear[176] = PlayerPrefs.GetInt("StageClear10_14");
        stageClear[177] = PlayerPrefs.GetInt("StageClear10_15");
        stageClear[178] = PlayerPrefs.GetInt("StageClear10_16");
        stageClear[179] = PlayerPrefs.GetInt("StageClear10_17");
        stageClear[180] = PlayerPrefs.GetInt("StageClear10_18");
    }
}
