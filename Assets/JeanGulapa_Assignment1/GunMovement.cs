using UnityEngine;

namespace Assets
{
    public class GunMovement : MonoBehaviour
    {
        public Vector2 axis;

        public float rotSpeed;

        public float moveSpeed;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        public void gunMovementUpdate()
        {
            float deltaT = Time.deltaTime;

            axis.x = Input.GetAxis("Horizontal");
            axis.y = Input.GetAxis("Vertical");

            //this.transform.Rotate(Vector3.up, axis.x * deltaT * rotSpeed, Space.Self);
            this.transform.Translate(moveSpeed * axis.y * deltaT* Vector3.up, Space.Self);
            this.transform.Translate(moveSpeed * axis.x * deltaT * Vector3.forward, Space.Self);


        }

        // Update is called once per frame
        void Update()
        {
            gunMovementUpdate();
        }
    }
}
