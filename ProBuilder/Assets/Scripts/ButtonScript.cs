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
        EventBroadcaster.Instance.AddObserver(EventNames.S18_Events.ON_SPAWN_CLICK, this.OnSpawnEvent);
    }

    private void OnDestroy()
    {
        EventBroadcaster.Instance.RemoveObserver(EventNames.S18_Events.ON_SPAWN_CLICK);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnSpawnEvent()
    {
        Vector3 position = new Vector3(Random.Range(-10.0f, 10.0f), 0.0f, Random.Range(-5.0f, 10.0f));
        GameObject instance = GameObject.Instantiate(this.template,position, Quaternion.identity);
        instance.SetActive(true);
        objectList.Add(instance);
    }
}
