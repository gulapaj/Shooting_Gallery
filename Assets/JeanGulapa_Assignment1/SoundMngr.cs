using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMngr : MonoBehaviour
{
    internal static object instance;

    public static implicit operator SoundMngr(SoundMgr v)
    {
        throw new NotImplementedException();
    }

    public class SoundMgr : MonoBehaviour
    {
        public static SoundMngr instance;
        public AudioClip impactSfx;
        public AudioClip doubleImpactSfx;
        private AudioSource asource;

        public void Awake()
        {
            if (instance == null)
            {
                SoundMgr soundMgr = this;
                instance = soundMgr;
            }
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

        public void PlayImpactSfx()
        {
            if (asource != null)
            {
                if (impactSfx != null)
                    asource.PlayOneShot(impactSfx);
            }
        }

        public void PlayDoubleImpactSfx()
        {
            if (asource != null)
            {
                if (doubleImpactSfx != null)
                    asource.PlayOneShot(doubleImpactSfx);
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
