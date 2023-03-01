using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class losing : MonoBehaviour
{
    public GameObject text;
    public GameObject button;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (text.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
        {

            button.SetActive(true);
        }
        else
        {
            button.SetActive(false);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene("game");
    }
    public void menu()
    {
        SceneManager.LoadScene("меню");
    }
}
