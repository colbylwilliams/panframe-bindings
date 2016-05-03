## Panframe bindings

This is a set of Xamarin bindings for the [Panframe iOS SDK][0] and [Panframe Android SDK][1].


## Building

Clone this repo.

Download the [Panframe iOS SDK][0] and [Panframe Android SDK][1].
Drop the `Panframe.framework` file in `extern/ios` folder.
Drop the `panframe-1.9.jar` file in the `extern/android` folder.
Open `bindings/ios/Panframe/Panframe.sln` and `bindings/android/Panframe/Panframe.sln` in Xamarin Studio and build.  Or simply reference the respective Panframe projects from your Xamarin.iOS and Xamarin.Android project.


## Requirements

* Xamarin Studio 6.0+ (currently in Beta/Alpha Channel)

[0]:http://www.panframe.com/get-it/panframe-1-9-for-ios/
[1]:http://www.panframe.com/get-it/panframe-1-9-for-android/


