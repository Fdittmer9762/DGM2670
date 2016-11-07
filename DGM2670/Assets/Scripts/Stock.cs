using UnityEngine;
using System.Collections;

public class Stock {
/*
    string symbol; decimal price;

    public Stock(string symbol) { this.symbol = symbol; } //not sure what there doing here, they are creating a symbol that is within and then setting it to itself; or so it seems

    public event EventHandler<PriceChangedArgs> Pricechanged;

    protected virtual void OnPriceChanged(PriceChangedArgs e) {
        if (Pricechanged != null)
            Pricechanged(this, e);
    }

    public decimal Price {
        get { return price; }
        set {
            if (price == value) return;

            OnPriceChanged(new PriceChangedArgs(price, value));
            /*if (Pricechanged != null){
                Pricechanged(price, value);
            //}

            price = value;
        }
    }*/
}
