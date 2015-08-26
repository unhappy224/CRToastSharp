using System;

using UIKit;
using CRToast;
using System.Diagnostics;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;

namespace CRToastDemo
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.


            var btn = new UIButton();
            View.Add(btn);

            
            btn.SetTitle("Click!", UIControlState.Normal);
            btn.BackgroundColor = UIColor.FromRGB(78, 183, 54);
            btn.Frame = new CGRect(100, 200, 100, 44);


            var btn2 = new UIButton();
            View.Add(btn2);


            btn2.SetTitle("Click!", UIControlState.Normal);
            btn2.BackgroundColor = UIColor.Orange;
            btn2.Frame = new CGRect(100, 400, 100, 44);

            btn.TouchUpInside += (_, __) =>
            { 
                CRToastManager.ShowNotification(title: "Hello World",
                    titleColor : UIColor.White,
                    type: CRToastType.NavigationBar,
                    isUnderStatusBar: true,
                    isShowActivityIndicator: true,
                    titleFont: UIFont.BoldSystemFontOfSize(24),
                    animationTime: 1,
                    backgroundColor: UIColor.FromRGB(78, 183, 54));
            };

            btn2.TouchUpInside += (_, __) =>
            {
                CRToastManager.ShowNotification(title: "Hello World 2",
                    titleColor : UIColor.White,
                    type: CRToastType.NavigationBar,
                    animationInDirection: CRToastAnimationDirection.Left,
                    animationInType: CRToastAnimationType.Spring,
                    titleFont: UIFont.BoldSystemFontOfSize(24),
                    animationTime: 1,
                    backgroundColor: UIColor.Orange);
            };
             
        }

   

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

