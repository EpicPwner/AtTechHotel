using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour {

    private SpriteRenderer _CoinRender;
    
    public int CoinCounter;
    private int dropProb;
    private static int TotalDrop;
    public static int coinPurse=0;
    public static bool _OnOrOff = true;

    // Use this for initialization
    void Start () {

        _CoinRender = GetComponent<SpriteRenderer>();
        _CoinRender.enabled = true;
       
        
    }
	
	// Update is called once per frame
	void Update () {
   

        _OnOrOff = _CoinRender.enabled;

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (_CoinRender.enabled)
        {
            dropProb = Random.Range(0, 100);
            if (dropProb > 0 && dropProb < 70)
            {
                TotalDrop = Random.Range(1, 70);
            }
            else if (dropProb >= 70 && dropProb < 90)
            {
                TotalDrop = Random.Range(71, 250);
            }
            else if (dropProb >= 90 && dropProb < 97)
            {
                TotalDrop = Random.Range(251, 500);
            }
            else if (dropProb >= 97 && dropProb < 100)
            {
                TotalDrop = Random.Range(251, 1000);
            }  
        coinPurse += TotalDrop;
        Debug.Log("Coins Dropped: " + TotalDrop);
        
        }
        _CoinRender.enabled = false;
        
    }



}
