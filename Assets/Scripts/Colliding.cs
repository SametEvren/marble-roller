using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Colliding : MonoBehaviour
{
    public GameObject gameOverScreen;
    public AudioClip coinPickUp1;
    public AudioClip coinPickUp2;
    int rand;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle") || other.CompareTag("Obstaclee"))
        {
            Time.timeScale = 0;
            gameOverScreen.SetActive(true);
            UIManager.instance.score.text = "Score: " + Score.instance.score.text;
            if (Convert.ToInt32(Score.instance.score.text) > PlayerPrefs.GetInt("HighestScore", 0))
                PlayerPrefs.SetInt("HighestScore", Convert.ToInt32(Score.instance.score.text));
            UIManager.instance.highestScore.text = "Highest Score: " + PlayerPrefs.GetInt("HighestScore").ToString();
        }
        if(other.CompareTag("Gold"))
        {
            ParticleManager.instance.goldParticle.transform.position = other.transform.position;
            ParticleManager.instance.goldParticle.Clear();
            ParticleManager.instance.goldParticle.Play();
            rand = Random.Range(1, 2);
            if(rand == 1)
                AudioSource.PlayClipAtPoint(coinPickUp1, transform.position);
            else
                AudioSource.PlayClipAtPoint(coinPickUp2, transform.position);
            Destroy(other.gameObject);
        }
        if(other.CompareTag("MidSpawner"))
        {
            print("duh");
            transform.position = new Vector3(transform.position.x, 10, transform.position.z);
        }
    }
    
}
