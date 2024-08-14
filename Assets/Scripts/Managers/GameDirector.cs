using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    public PlayerScoreUI playerScoreUI;

    public MapGenerator mapGenerator;

    public Player player;

    public CameraHolder cameraHolder;

    // Start is called before the first frame update
    void Start()
    {
        mapGenerator.StartMapGenerator();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)) {
            RestartLevel();
        }
    }

    private void RestartLevel()
    {
        // Player Position ResetLe
        player.ResetPlayer();
        // Kameranýn pozisyonunu resetle
        cameraHolder.ResetCameraHolder();
        // Haritayý Sil
        // Haritayý Yeniden Oluþtur
        // Player Skorunu 0la
        


    }

    public void UpdatePlayerScore(int playerScore)
    {
        playerScoreUI.UpdatePlayerScore(playerScore);
    }
}
