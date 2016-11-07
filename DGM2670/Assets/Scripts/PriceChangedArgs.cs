using UnityEngine;
using System.Collections;

public class PriceChangedArgs : EventArgs {

    public readonly decimal LastPrice, NewPrice;

    public PriceChangedArgs(decimal lastPrice, decimal newPrice) {
        LastPrice = lastPrice; NewPrice = newPrice;
    }

}
