using System.Security.Cryptography;
using UnityEngine;

namespace Assets
{
    public class MovePoster : MonoBehaviour
    {
        public void OnCollisionEnter(Collision collision)
        {

            if (collision.gameObject.GetComponent<IsaHit>() != null)
            {
                delta = 0.0f;
                speed = 0.0f;
                Destroy(GetComponent<MovePoster>());
                Destroy(GetComponent<isaTarget>());
            }
        }

        public float delta = 1.5f;

        public float speed = 3.0f;
        private Vector3 startPos;


        // Start is called before the first frame update
        void Start()
        {
            startPos = transform.position;
        }

        // Update is called once per frame
        void Update()
        {

            Vector3 v = startPos;
            v.z += delta * Mathf.Sin(Time.time * speed);  //z for horizontal
            transform.position = v;

        }
    }
}
