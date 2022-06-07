using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public AudioSource bgm_music;
    // Start is called before the first frame update
    void Start()
    {
        bgm_music.UnPause();
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        bgm_music.UnPause();
    }
}
