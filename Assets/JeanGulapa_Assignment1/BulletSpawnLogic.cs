using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawnLogic : MonoBehaviour
{
    public GameObject obj;
    public KeyCode keyToPress;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void BulletSpawnLogicUpdate()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            Transform tf = GetComponent<Transform>();
            if (tf != null)
            {
                Instantiate(obj, tf.position, tf.rotation);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        BulletSpawnLogicUpdate();
    }
}
