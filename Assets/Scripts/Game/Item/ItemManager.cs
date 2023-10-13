using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField] List<GameObject> m_fruit;

    readonly int FRUIT_GENERATE_POS_X_MIN = -11;
    readonly int FRUIT_GENERATE_POS_X_MAX = 11;
    readonly int FRUIT_GENERATE_POS_Y = 12;
    readonly int FRUIT_GENERATE_POS_Z = -5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.IsTitle) { return; }

        if (Time.frameCount % 30 == 0)
        {
            Vector3 pos = new Vector3(Random.Range(-FRUIT_GENERATE_POS_X_MIN, FRUIT_GENERATE_POS_X_MAX), FRUIT_GENERATE_POS_Y, -FRUIT_GENERATE_POS_Z);
            Instantiate(m_fruit[Random.Range(0, m_fruit.Count)], pos, Quaternion.identity);
        }
    }
}
