using System;
using System.Runtime.InteropServices;
using CoreGraphics;
using ObjCRuntime;
using UIKit;

namespace CRToast
{
    [Native]
    public enum CRToastInteractionType : long
    {
        SwipeUp = 1 << 0,
        SwipeLeft = 1 << 1,
        SwipeDown = 1 << 2,
        SwipeRight = 1 << 3,
        TapOnce = 1 << 4,
        TapTwice = 1 << 5,
        TwoFingerTapOnce = 1 << 6,
        TwoFingerTapTwice = 1 << 7,
        Swipe = (SwipeUp | SwipeLeft | SwipeDown | SwipeRight),
        Tap = (TapOnce | TapTwice | TwoFingerTapOnce | TwoFingerTapTwice),
        All = (Swipe | Tap)
    }

   

    [Native]
    public enum CRToastType : long
    {
        StatusBar,
        NavigationBar,
        Custom
    }

    [Native]
    public enum CRToastPresentationType : long
    {
        Cover,
        Push
    }

    [Native]
    public enum CRToastAnimationDirection : long
    {
        Top,
        Bottom,
        Left,
        Right
    }

    [Native]
    public enum CRToastAnimationType : long
    {
        Linear,
        Spring,
        Gravity
    }

    [Native]
    public enum CRToastState : long
    {
        Waiting,
        Entering,
        Displaying,
        Exiting,
        Completed
    }

    [Native]
    public enum CRToastAccessoryViewAlignment : long
    {
        Left,
        Center,
        Right
    }
}
