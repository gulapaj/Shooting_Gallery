using UnityEngine;

namespace Assets
{
    public class BulletAction : MonoBehaviour
    {
        public void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.GetComponent<IsDoublePointTarget>() == null)
                Destroy(GetComponent<IsDoublePointTarget>());
                this.GetComponent<ConstantForce>().enabled = false;
            Invoke("SelfDestruct", 3.0f);
            if (collision.gameObject.GetComponent<IsDoublePointTarget>() != null)
            {

                ScoreMgr.instance.score = ScoreMgr.instance.score + 2;
             //   SoundMngr.instance.PlayDoubleImpactSfx();
                Destroy(GetComponent<IsDoublePointTarget>());
                
                this.GetComponent<ConstantForce>().enabled = false;
                Invoke("SelfDestruct", 3.0f);
            }

            if (collision.gameObject.GetComponent<isaTarget>() == null)
                Destroy(GetComponent<isaTarget>());
            this.GetComponent<ConstantForce>().enabled = false;
            Invoke("SelfDestruct", 3.0f);
            if (collision.gameObject.GetComponent<isaTarget>() != null)
            {
                ScoreMgr.instance.score++;
            //    SoundMngr.instance.PlayImpactSfx();
                Destroy(GetComponent<isaTarget>());
                this.GetComponent<ConstantForce>().enabled = false;
                Invoke("SelfDestruct", 3.0f);
            }

       
        }

        private void SelfDestruct()
        {
            Destroy(this.gameObject);
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
