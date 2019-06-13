using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spheremove : MonoBehaviour
{
    public float MehirutTezuza = 0.01f;
    public float MehirutSivuv = 1.0f;

    void Start()
    {
         Time.timeScale = 1;
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.localRotation * Vector3.right * MehirutTezuza;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += transform.localRotation * Vector3.left * MehirutTezuza;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.localRotation * Vector3.forward * MehirutTezuza;
        }


        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += transform.localRotation * Vector3.back * MehirutTezuza;
        }

        if (transform.position.y < -1)
        {
            Time.timeScale = 0;
            StartAgain();
        }
    }
    void OnCollisionEnter(Collision hitnagshut)
    {

         if (hitnagshut.gameObject.tag == "block")
         {
            Time.timeScale = 0;
            StartAgain();
         }
        
    }
    void StartAgain()
    {
        if (Time.timeScale == 0)

        {
            SceneManager.LoadScene(0);
        }
    }
}
