using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuScript : MonoBehaviour
{
    public GameObject resumeBtn;
    // Start is called before the first frame update
    void Start()
    {
        resumeBtn.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            resumeBtn.SetActive(true);
        }
    }
}
