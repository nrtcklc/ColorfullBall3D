using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;
using System;

public class IAPController : MonoBehaviour, IStoreListener
{
    public UIManager UIManager; 
    IStoreController controller;
    public SoundManager soundManager;

    public string[] product;
    public void Start()
    {
        IAPStart();
    }
    public void IAPStart()
    {
        var module = StandardPurchasingModule.Instance();
        ConfigurationBuilder builder = ConfigurationBuilder.Instance(module);
        foreach (string item in product)
        {
            builder.AddProduct(item, ProductType.Consumable);
        }

        UnityPurchasing.Initialize(this, builder);
    }
    public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
    {
        this.controller = controller;
    }
    public void OnInitializeFailed(InitializationFailureReason error, string message)
    {
        Debug.Log("Failed initiliaze");
    }
    public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
    {
        Debug.Log("Purchuase failed");
    }
    public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs purchaseEvent)
    {
        if (string.Equals(purchaseEvent.purchasedProduct.definition.id, product[0], StringComparison.Ordinal))
        {
            PlayerPrefs.SetInt("moneyy", PlayerPrefs.GetInt("moneyy") + 2500);
            UIManager.CoinTextUpdate();
            soundManager.CashSound();
            return PurchaseProcessingResult.Complete;
        }
        else if (string.Equals(purchaseEvent.purchasedProduct.definition.id, product[1], StringComparison.Ordinal))
        {
            PlayerPrefs.SetInt("moneyy", PlayerPrefs.GetInt("moneyy") + 5000);
            UIManager.CoinTextUpdate();
            soundManager.CashSound();
            return PurchaseProcessingResult.Complete;
        }
        else if (string.Equals(purchaseEvent.purchasedProduct.definition.id, product[2], StringComparison.Ordinal))
        {
            PlayerPrefs.SetInt("moneyy", PlayerPrefs.GetInt("moneyy") + 10000);
            UIManager.CoinTextUpdate();
            soundManager.CashSound();
            return PurchaseProcessingResult.Complete;
        }
        else if (string.Equals(purchaseEvent.purchasedProduct.definition.id, product[3], StringComparison.Ordinal))
        {
            if (PlayerPrefs.HasKey("NoAds") == true)
            {
                PlayerPrefs.SetInt("NoAds", 1);
                UIManager.NoAdsRemove();
                soundManager.CashSound();
            }
            return PurchaseProcessingResult.Complete;
        }

        else
        {
            return PurchaseProcessingResult.Pending;
        }

    }
    public void IAPButton(string id)
    {
        Product product = controller.products.WithID(id);
        if (product != null && product.availableToPurchase)
        {
            controller.InitiatePurchase(product);
            Debug.Log("Buying");
        }
        else
        {
            Debug.Log("Not Buying");
        }

    }

    public void OnInitializeFailed(InitializationFailureReason error)
    {
        throw new NotImplementedException();
    }
}
