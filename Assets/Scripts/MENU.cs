using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MENU : MonoBehaviour
{
    GameObject Wall;

    float t = 0f;
    int click = 0;

    // Start is called before the first frame update
    void Start()
    {
        Wall = GameObject.Find("Quad");
    }

    // Update is called once per frame
    void Update()
    {
        if (click == 1)
            t += Time.deltaTime;

        if(t > 3f)
        {
            SceneManager.LoadScene("MAINGAME");
        }
    }

    public void Start_Click()
    {
        Wall.transform.position = new Vector3(0, 0, 1);
        Wall.transform.rotation = Quaternion.Euler(25 + Random.Range(0, 6), 0, 0);

        click = 1;
    }
}
