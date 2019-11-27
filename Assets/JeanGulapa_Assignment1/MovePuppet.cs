using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

namespace Assets
{
    public class MovePuppet : MonoBehaviour
    {
        public void OnCollisionEnter(Collision collision)
        {

            if (collision.gameObject.GetComponent<IsaHit>() != null)
            {
                this.GetComponent<Rigidbody>().useGravity = true;
               // Destroy(this.gameObject);
                Destroy(GetComponent<isaTarget>());
            }
        }
        public float delta = 1.5f;  // Amount to move left and right from the start point
        public float speed = 2.0f;
        public float direction = 1;
        private Quaternion startPos;
        // Start is called before the first frame update
        void Start()
        {
            startPos = transform.rotation;
        }

        // Update is called once per frame
        void Update()
        {
            Quaternion a = startPos;
            a.x += direction * (delta * Mathf.Sin(Time.time * speed));
            transform.rotation = a;
        }
    }
}
