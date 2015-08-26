using System;
using Foundation;
using UIKit;
using CRToast;
using CoreGraphics;

namespace CRToast
{
    public partial class CRToastManager
    {
        public static void ShowNotification(
            string title,
            Action completeAction = null,
            Action appearanceAction = null,
            UIColor titleColor = null,
            UIFont titleFont = null,
            UITextAlignment? titleAlignment = null,
            UIColor titleShadowColor = null,
            CGSize? titleShadowOffset = null,
            int? titleMaxnumOfLine = null,

            string subtitle = null,
            UIColor subtitleColor = null,
            UIFont subtitleFont = null,
            UITextAlignment? subtitleAlignment = null,
            UIColor subtitleShadowColor = null,
            CGSize? subtitleShadowOffset = null,
            int? subtitleMaxnumOfLine = null,

            CRToastType? type = null,
            bool? isUnderStatusBar = null,
            bool? isKeepNavigationBarBorder = null,

            CRToastAnimationType?  animationInType = null,
            CRToastAnimationType?  animationOutType = null,
            CRToastAnimationDirection? animationInDirection = null,
            CRToastAnimationDirection? animationOutDirection = null,
            double? animationInTimeInterval = null,
            double? animationOutTimeInterval = null,
            double? animationTime = null,

            UIStatusBarStyle? statusBarStyle = null,
            UIColor backgroundColor = null,
            UIView backgroundView = null,
            UIImage image = null,
            UIViewContentMode? imageContentModel = null,
            UITextAlignment? imageAlignment = null,

            bool? isShowActivityIndicator = null,
            UIActivityIndicatorViewStyle? activityIndicatorStyle = null,
            UITextAlignment? activityIndicatorAlignment = null,

            CRToastInteractionResponder interactionResponder = null,

            bool? isForceUserInteraction = null,
            bool? isAutorotate = null,

            string identifie = null,
            UIWindow window = null
        )
        {
            var opt = new NSMutableDictionary();
            opt.Add(new NSString("kCRToastTextKey"), new NSString(title));

            if (titleColor != null)
            {
                opt.Add(new NSString("kCRToastTextColorKey"), titleColor);
            }
            if (titleFont != null)
            {
                opt.Add(new NSString("kCRToastFontKey"), titleFont);
            }

            if (titleAlignment != null)
            {
                opt.Add(new NSString("kCRToastTextAlignmentKey"), NSObject.FromObject(titleAlignment));
            }

            if (titleShadowColor != null)
            {
                opt.Add(new NSString("kCRToastTextShadowColorKey"), titleShadowColor);
            }

            if (titleShadowOffset != null)
            {
                opt.Add(new NSString("kCRToastTextShadowOffsetKey"), NSObject.FromObject(titleShadowOffset));
            }

            if (titleMaxnumOfLine != null)
            {
                opt.Add(new NSString("kCRToastTextMaxNumberOfLinesKey"), NSObject.FromObject(titleMaxnumOfLine));
            }


            //====
            if (subtitle != null)
            {
                opt.Add(new NSString("kCRToastSubtitleTextKey"), new NSString(subtitle));
            }

            if (subtitleColor != null)
            {
                opt.Add(new NSString("kCRToastSubtitleTextColorKey"), subtitleColor);
            }
            if (subtitleFont != null)
            {
                opt.Add(new NSString("kCRToastSubtitleFontKey"), subtitleFont);
            }

            if (subtitleAlignment != null)
            {
                opt.Add(new NSString("kCRToastSubtitleTextAlignmentKey"), NSObject.FromObject(subtitleAlignment));
            }

            if (subtitleShadowColor != null)
            {
                opt.Add(new NSString("kCRToastSubtitleTextShadowColorKey"), subtitleShadowColor);
            }

            if (subtitleShadowOffset != null)
            {
                opt.Add(new NSString("kCRToastSubtitleTextShadowOffsetKey"), NSObject.FromObject(subtitleShadowOffset));
            }

            if (subtitleMaxnumOfLine != null)
            {
                opt.Add(new NSString("kCRToastSubtitleTextMaxNumberOfLinesKey"), NSObject.FromObject(subtitleMaxnumOfLine));
            }

            //======
            if (type != null)
            {
                opt.Add(new NSString("kCRToastNotificationTypeKey"), NSObject.FromObject(type));
            }

            if (isUnderStatusBar != null)
            {
                opt.Add(new NSString("kCRToastUnderStatusBarKey"), NSObject.FromObject(isUnderStatusBar));
            }

            if (isKeepNavigationBarBorder != null)
            {
                opt.Add(new NSString("kCRToastKeepNavigationBarBorderKey"), NSObject.FromObject(isKeepNavigationBarBorder));
            }

            //=====

            if (animationInType != null)
            {
                opt.Add(new NSString("kCRToastAnimationInTypeKey"), NSObject.FromObject(animationInType));
            }

            if (animationOutType != null)
            {
                opt.Add(new NSString("kCRToastAnimationOutTypeKey"), NSObject.FromObject(animationOutType));
            }
            if (animationInDirection != null)
            {
                opt.Add(new NSString("kCRToastAnimationInDirectionKey"), NSObject.FromObject(animationInDirection));
            }
            if (animationOutDirection != null)
            {
                opt.Add(new NSString("kCRToastAnimationOutDirectionKey"), NSObject.FromObject(animationOutDirection));
            }
            if (animationInTimeInterval != null)
            {
                opt.Add(new NSString("kCRToastAnimationInTimeIntervalKey"), NSObject.FromObject(animationInTimeInterval));
            }
            if (animationTime != null)
            {
                opt.Add(new NSString("kCRToastTimeIntervalKey"), NSObject.FromObject(animationTime));
            }

            if (animationOutTimeInterval != null)
            {
                opt.Add(new NSString("kCRToastAnimationOutTimeIntervalKey"), NSObject.FromObject(animationOutTimeInterval));
            }

            if (statusBarStyle != null)
            {
                opt.Add(new NSString("kCRToastStatusBarStyleKey"), NSObject.FromObject(statusBarStyle));
            }

            if (backgroundColor != null)
            {
                opt.Add(new NSString("kCRToastBackgroundColorKey"), backgroundColor);
            }

            if (backgroundView != null)
            {
                opt.Add(new NSString("kCRToastBackgroundViewKey"), backgroundView);
            }

            if (image != null)
            {
                opt.Add(new NSString("kCRToastImageKey"), image);
            }

            if (imageContentModel != null)
            {
                opt.Add(new NSString("kCRToastImageContentModeKey"), NSObject.FromObject(imageContentModel));
            }

            if (imageAlignment != null)
            {
                opt.Add(new NSString("kCRToastImageAlignmentKey"), NSObject.FromObject(imageAlignment));
            }
            if (isShowActivityIndicator != null)
            {
                opt.Add(new NSString("kCRToastShowActivityIndicatorKey"), NSObject.FromObject(isShowActivityIndicator));
            }
            if (activityIndicatorStyle != null)
            {
                opt.Add(new NSString("kCRToastActivityIndicatorViewStyleKey"), NSObject.FromObject(activityIndicatorStyle));
            }
            if (activityIndicatorAlignment != null)
            {
                opt.Add(new NSString("kCRToastActivityIndicatorAlignmentKey"), NSObject.FromObject(activityIndicatorAlignment));
            }

            if (interactionResponder != null)
            {
                opt.Add(new NSString("kCRToastInteractionRespondersKey"), NSObject.FromObject(interactionResponder));
            }
            if (isForceUserInteraction != null)
            {
                opt.Add(new NSString("kCRToastForceUserInteractionKey"), NSObject.FromObject(isForceUserInteraction));
            }
            if (isAutorotate != null)
            {
                opt.Add(new NSString("kCRToastAutorotateKey"), NSObject.FromObject(isAutorotate));
            }
            if (identifie != null)
            {
                opt.Add(new NSString("kCRToastIdentifierKey"), NSObject.FromObject(identifie));
            }
            if (window != null)
            {
                opt.Add(new NSString("kCRToastCaptureDefaultWindowKey"), window);
            }


           
            if (appearanceAction != null)
            {  
                typeof(CRToastManager).GetMethod("ShowNotificationWithOptions", new Type[]{ typeof(NSMutableDictionary), typeof(Action), typeof(Action) }).Invoke(null, new object[]{ opt, appearanceAction, completeAction });
            }
            else
            { 
                typeof(CRToastManager).GetMethod("ShowNotificationWithOptions", new Type[]{ typeof(NSMutableDictionary),  typeof(Action) }).Invoke(null, new object[]{ opt,  completeAction });
            }
        }
    }
}

