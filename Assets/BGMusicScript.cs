using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusicScript : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource bg;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
