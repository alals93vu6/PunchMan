using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public static bool is_BGM = false;
    public GameObject BGM_sound;
    public  AudioSource bgm_music;
    // Start is called before the first frame update
    void Start()
    {
        if (is_BGM == false)
        {
            Instantiate(bgm_music, this.gameObject.transform.position, new Quaternion(0, 0, 0, 0));
            bgm_music.UnPause();
            DontDestroyOnLoad(this.gameObject);
            is_BGM = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
        bgm_music.UnPause();
    }
}
