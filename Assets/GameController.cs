using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    public float gameSpeed;
    public float gameScore;
    public Transform gameCamera;
    public GameObject gamePlayer;

    public List<Image> healthImages;

    public int playerLives;

    // Start is called before the first frame update
    private void Awake()
    {
        playerLives = 3;
        gamePlayer.GetComponent<PlayerCollisions>().OnDie += Die;
        gameScore = 0;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameCamera.Translate(Vector3.right * gameSpeed * Time.deltaTime);
        gamePlayer.transform.Translate(Vector3.right * gameSpeed * Time.deltaTime);

        gameScore += Time.deltaTime;
    }

    void Die()
    {
        playerLives -= 1;

        for(int i = 1; i < 4; i++)
        {
            if(i == playerLives)
            {
                healthImages[i].enabled = true;
            } else
            {
                healthImages[i].enabled = false;
            }
        }

        ResetPlayer();

        if(playerLives == 0) {
            GameOver();
        }
    }

    void ResetPlayer()
    {

    }

    void GameOver()
    {

    }
}
