using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
public class Adds : MonoBehaviour
{
    public BannerView bannerView;
    public InterstitialAd interstitial;
    private bool isRealAdds = true;

    public void Start()
    {
        string appId;
        if (isRealAdds)
        {
            appId = "ca-app-pub-2945346553316838~1653570636";//box run 3d
        }
        else
        {
            appId = "ca-app-pub-3940256099942544~3347511713";//test appId
        }

        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(appId);
        this.RequestBanner();
        this.RequestInter();
    }
    public void RequestBanner()
    {
        string adUnitId;
        if (isRealAdds)
        {
            adUnitId = "ca-app-pub-2945346553316838/6472042226";// box run 3d
        }
        else
        {
            adUnitId = "ca-app-pub-3940256099942544/6300978111";//test
        }

        // Create a 320x50 banner at the top of the screen.
        bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        bannerView.LoadAd(request);
    }


    public void RequestInter()
    {
        string adUnitId;
        if (isRealAdds)
        {
            adUnitId = "ca-app-pub-2945346553316838/5869406990";//box run 3d
        }
        else
        {
            adUnitId = "ca-app-pub-3940256099942544/1033173712";//test
        }

        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd(adUnitId);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        interstitial.LoadAd(request);
    }
}
