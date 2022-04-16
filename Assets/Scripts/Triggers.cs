using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Triggers : MonoBehaviour
{
    [SerializeField]
    private TriggerObjective triggerObjctiveScript;
    public bool activate;
    public bool desactivate;
    public bool changeScene;
    public int numberOfScene;


    // Start is called before the first frame update
    void Start()
    {
        triggerObjctiveScript = GameObject.Find("GameObjectiveController").gameObject.GetComponent<TriggerObjective>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (activate)
            {
                triggerObjctiveScript.Activate();
            }
            if (desactivate)
            {
                triggerObjctiveScript.Desactivate();
            }
            if (changeScene)
            {
                SceneManager.LoadScene(numberOfScene);
            }

        }
    }

   
}
