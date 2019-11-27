using UnityEngine;

namespace Assets
{
    public class SpecialWinLoseMusic : MonoBehaviour
    {
        public static SpecialWinLoseMusic instance;
        public AudioClip winSfx;
        public AudioClip loseSfx;
        private AudioSource asource;
        public void Awake()
        {
            if (instance == null)
                instance = this;
            else
                Destroy(this);

            // create the audiosource if we need it
            if (asource == null)
            {
                asource = this.gameObject.AddComponent<AudioSource>();
                if (asource)
                {
                    asource.playOnAwake = false;
                }
            }
        }

        public void PlayWinSfx()
        {
            if (asource != null)
            {
                if (winSfx != null)
                    asource.PlayOneShot(winSfx);
            }
        }

        public void PlayLoseSfx()
        {
            if (asource != null)
            {
                if (loseSfx != null)
                    asource.PlayOneShot(loseSfx);
            }
        }
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
