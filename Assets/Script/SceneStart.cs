using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStart : MonoBehaviour
{
    // Start is called before the first frame update
    public void startbuttom()
    {
        SceneManager.LoadScene(1);
    }
}
