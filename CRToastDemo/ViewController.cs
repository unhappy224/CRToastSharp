using System;

using UIKit;
using CRToast;
using System.Diagnostics;
using PureLayout;
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

            btn.AutoCenterInSuperview();
            btn.SetTitle("Click!", UIControlState.Normal);
            btn.BackgroundColor = UIColor.Red;
            btn.AutoSetDimensionsToSize(new CoreGraphics.CGSize(100, 50)); 

            btn.TouchUpInside += (s, e) =>
            {
                    
//                var opt = new NSMutableDictionary();
//                opt.Add(new NSString("kCRToastNotificationTypeKey"), NSObject.FromObject(CRToastType.NavigationBar));
//                opt.Add(new NSString("kCRToastTextKey"), new NSString("Hello Word"));
//                opt.Add(new NSString("kCRToastNotificationPresentationTypeKey"), NSObject.FromObject(CRToastPresentationType.Push));
//                opt.Add(new NSString("kCRToastAnimationInDirectionKey"), NSObject.FromObject(CRToastAnimationDirection.Right));
//                opt.Add(new NSString("kCRToastAnimationOutDirectionKey"), NSObject.FromObject(CRToastAnimationDirection.Left));
//                opt.Add(new NSString("kCRToastShowActivityIndicatorKey"), NSObject.FromObject(true));
//                CRToastManager.ShowNotificationWithOptions(opt, () =>
//                    {
//                    });
//                    
                CRToastManager.ShowNotification(title: "Hello World",
                    titleColor : UIColor.White,
                    type: CRToastType.NavigationBar,
                    isUnderStatusBar: true,
                    isShowActivityIndicator: true,
                    titleFont: UIFont.BoldSystemFontOfSize(24),
                    animationTime: 10,
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

