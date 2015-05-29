using System;

using UIKit;
using CRToast;
using System.Diagnostics;
using PureLayout;

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
                CRToastManager.ShowNotificationWithMessage("aa", () =>
                    {
                        Debug.WriteLine("Complete");
                    }); 
            };

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

