using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallmiddle : MonoBehaviour
{
    public Logicscript logic;

    // Start is called before the first frame update
    void Start()
    {
      logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
        logic.addScore();
        }
    }
 
}
