using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField] List<GameObject> m_fruit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.IsTitle()) { return; }

        if (Time.frameCount % 30 == 0)
        {
            Vector3 pos = new Vector3(Random.Range(-11, 11), 12, -5);
            Instantiate(m_fruit[Random.Range(0, m_fruit.Count)], pos, Quaternion.identity);
        }
    }
}
