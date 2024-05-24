using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [SerializeField] private Text spawnText;
    [SerializeField] private InputField spawnAmount;
    private int spawnCounter = 10;
    private int NUM_SPAWN = 0;
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
        string input = spawnAmount.text;
        int.TryParse(input, out NUM_SPAWN);
        Parameters parameters = new Parameters();
        parameters.PutExtra(ButtonScript.NUM_SPAWN_KEY, NUM_SPAWN);
        if(spawnCounter != 0)
        {
            EventBroadcaster.Instance.PostEvent(EventNames.S18_Events.ON_SPAWN_CLICK, parameters);
            this.spawnCounter--;
            this.spawnText.text = "Available balls: " + this.spawnCounter;

        }
    }
}
