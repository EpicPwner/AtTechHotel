using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class UIController : MonoBehaviour {

    [Header("Linkage")]
    [SerializeField] private Text DeathCounter;
    [SerializeField] private Text CoinCounter;
    [SerializeField] private PopUp popUp;

    private int CoinDrop;
    private int Wallet;
    private CoinCollect CoinCollider;


	// Use this for initialization
	void Start () {

        popUp.Close();
        
        
    }
	
	// Update is called once per frame
	void Update () {

        

    }

    public void OnOpenSettings()
    {
        popUp.Open();
    }



    public void WalletUpdate()
    {
        CoinDrop = CoinCollect.coinPurse;

        if (!CoinCollect._OnOrOff)
        {
            Wallet += CoinDrop;
            CoinCounter.text = Wallet.ToString();
            Debug.Log(Wallet);
            CoinCollect._OnOrOff = true;
            CoinDrop = 0;
            
        }
        

    }


}
