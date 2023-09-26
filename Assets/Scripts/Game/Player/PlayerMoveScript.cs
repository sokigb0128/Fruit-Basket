using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{
    Rigidbody m_rigidbody;
    Vector3 m_movingVelocity;
    Vector3 m_movingDirection;


    // Start is called before the first frame update
    void Start()
    {
        m_rigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        m_movingDirection = new Vector3(x, 0, 0);
        m_movingDirection.Normalize();
        m_movingVelocity = m_movingDirection * 10;

    }

    void FixedUpdate()
    {
        m_rigidbody.velocity = new Vector3(m_movingVelocity.x, m_rigidbody.velocity.y, m_rigidbody.velocity.z);
    }
}
