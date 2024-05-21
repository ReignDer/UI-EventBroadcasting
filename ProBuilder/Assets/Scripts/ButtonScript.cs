using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] private GameObject template;
    [SerializeField] private List<GameObject> objectList;
    // Start is called before the first frame update
    void Start()
    {
        this.template.SetActive(false);  
        for(int i = 0; i < 10; i++)
        {
            this.OnSpawnEvent();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnSpawnEvent()
    {
        GameObject instance = GameObject.Instantiate(this.template,this.transform);
        instance.SetActive(true);
        objectList.Add(instance);
    }
}
