using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [SerializeField] private Text spawnText;
    private int spawnCounter = 10;
    // Start is called before the first frame update
    void Start()
    {
        this.spawnText.text = "Available balls: " + this.spawnCounter;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClicked()
    {
        if(spawnCounter != 0)
        {
            EventBroadcaster.Instance.PostEvent(EventNames.S18_Events.ON_SPAWN_CLICK);
            this.spawnCounter--;
            this.spawnText.text = "Available balls: " + this.spawnCounter;

        }
    }
}
