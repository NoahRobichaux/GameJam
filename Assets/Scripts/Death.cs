using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public GameObject deathScreen;
    public AudioSource deathSFX;
    public float sceneLoadDelay;
    bool isDead;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
        {
            sceneLoadDelay -= Time.deltaTime;
            if (sceneLoadDelay <= 0)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        deathSFX.Play();
        deathScreen.SetActive(true);
        isDead = true;
    }
}
