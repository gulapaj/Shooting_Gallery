using UnityEngine;

namespace Assets
{
    public class MoveSpider : MonoBehaviour
    {
        public void OnCollisionEnter(Collision collision)
        {

            if (collision.gameObject.GetComponent<IsaHit>() != null)
            {
                delta = 0.0f;
                speed = 0.0f;

                Destroy(GetComponent<MoveSpider>());
                Destroy(GetComponent<isaTarget>());
            }
        }
        public float delta = 2f;

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
            v.y += delta * Mathf.Sin(Time.time * speed);  //vertical
            transform.position = v;
        }
    }
}
