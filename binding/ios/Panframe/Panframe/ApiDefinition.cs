using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;
using CoreMedia;

namespace Panframe
{
	// @protocol PFAssetTimeMonitor <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface PFAssetTimeMonitor
	{
		// @required -(void)onPlayerTime:(id<PFAsset>)asset hasTime:(CMTime)time;
		[Abstract]
		[Export ("onPlayerTime:hasTime:")]
		void HasTime (PFAsset asset, CMTime time);
	}

	// @protocol PFAsset <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface PFAsset
	{
		// @required -(void)play;
		[Abstract]
		[Export ("play")]
		void Play ();

		// @required -(void)playWithSeekTo:(CMTime)start onKeyFrame:(BOOL)keyframe;
		[Abstract]
		[Export ("playWithSeekTo:onKeyFrame:")]
		void PlayWithSeekTo (CMTime start, bool keyframe);

		// @required -(void)pause;
		[Abstract]
		[Export ("pause")]
		void Pause ();

		// @required -(void)stop;
		[Abstract]
		[Export ("stop")]
		void Stop ();

		// @required -(CMTimeRange)getTimeRange;
		[Abstract]
		[Export ("getTimeRange")]
		//[Verify (MethodToProperty)]
		CMTimeRange TimeRange { get; }

		// @required -(void)setTimeRange:(CMTime)start duration:(CMTime)duration onKeyFrame:(BOOL)keyframe;
		[Abstract]
		[Export ("setTimeRange:duration:onKeyFrame:")]
		void SetTimeRange (CMTime start, CMTime duration, bool keyframe);

		// @required -(CMTime)getPlaybackTime;
		[Abstract]
		[Export ("getPlaybackTime")]
		//[Verify (MethodToProperty)]
		CMTime PlaybackTime { get; }

		// @required -(CMTime)getDuration;
		[Abstract]
		[Export ("getDuration")]
		//[Verify (MethodToProperty)]
		CMTime Duration { get; }

		// @required -(NSURL *)getUrl;
		[Abstract]
		[Export ("getUrl")]
		//[Verify (MethodToProperty)]
		NSUrl Url { get; }

		// @required -(void)addObserver:(PFAssetObserver *)observer;
		[Abstract]
		[Export ("addObserver:")]
		void AddObserver (PFAssetObserver observer);

		// @required -(void)removeObserver:(PFAssetObserver *)observer;
		[Abstract]
		[Export ("removeObserver:")]
		void RemoveObserver (PFAssetObserver observer);

		// @required -(enum PFASSETMESSAGE)getStatus;
		[Abstract]
		[Export ("getStatus")]
		//[Verify (MethodToProperty)]
		PFAssetMessage Status { get; }

		// @required -(float)getDownloadProgress;
		[Abstract]
		[Export ("getDownloadProgress")]
		//[Verify (MethodToProperty)]
		float DownloadProgress { get; }

		// @required -(_Bool)setTimeMonitor:(id<PFAssetTimeMonitor>)monitor;
		[Abstract]
		[Export ("setTimeMonitor:")]
		bool SetTimeMonitor (PFAssetTimeMonitor monitor);

		// @required -(void)setVolume:(float)volume;
		[Abstract]
		[Export ("setVolume:")]
		void SetVolume (float volume);
	}

	// @protocol PFAssetObserver <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface PFAssetObserver
	{
		// @required -(void)onStatusMessage:(PFAsset *)asset message:(enum PFASSETMESSAGE)m;
		[Abstract]
		[Export ("onStatusMessage:message:")]
		void Message (PFAsset asset, PFAssetMessage m);
	}

	// @protocol PFHotspot
	[Protocol, Model]
	interface PFHotspot
	{
		// @required -(void)setSize:(float)radius;
		[Abstract]
		[Export ("setSize:")]
		void SetSize (float radius);

		// @required -(void)setHitRadius:(float)radius;
		[Abstract]
		[Export ("setHitRadius:")]
		void SetHitRadius (float radius);

		// @required -(void)setCoordinates:(float)rotY andX:(float)rotX andZ:(float)rotZ;
		[Abstract]
		[Export ("setCoordinates:andX:andZ:")]
		void SetCoordinates (float rotY, float rotX, float rotZ);

		// @required -(void)setTag:(int)tag;
		[Abstract]
		[Export ("setTag:")]
		void SetTag (int tag);

		// @required -(int)getTag;
		[Abstract]
		[Export ("getTag")]
		//[Verify (MethodToProperty)]
		int Tag { get; }

		// @required -(void)addTarget:(id)target action:(SEL)action;
		[Abstract]
		[Export ("addTarget:action:")]
		void AddTarget (NSObject target, Selector action);

		// @required -(void)setAlpha:(float)alpha;
		[Abstract]
		[Export ("setAlpha:")]
		void SetAlpha (float alpha);

		// @required -(float)getAlpha;
		[Abstract]
		[Export ("getAlpha")]
		//[Verify (MethodToProperty)]
		float Alpha { get; }

		// @required -(void)animate;
		[Abstract]
		[Export ("animate")]
		void Animate ();

		// @required -(int)getState;
		[Abstract]
		[Export ("getState")]
		//[Verify (MethodToProperty)]
		int State { get; }
	}

	// @interface PFView : UIView
	[BaseType (typeof (UIView))]
	interface PFView
	{
		// -(void)setInterfaceOrientation:(UIInterfaceOrientation)orientation;
		[Export ("setInterfaceOrientation:")]
		void SetInterfaceOrientation (UIInterfaceOrientation orientation);

		// -(void)displayAsset:(PFAsset *)asset;
		[Export ("displayAsset:")]
		void DisplayAsset (PFAsset asset);

		// -(void)injectImage:(UIImage *)image;
		[Export ("injectImage:")]
		void InjectImage (UIImage image);

		// -(void)run;
		[Export ("run")]
		void Run ();

		// -(void)halt;
		[Export ("halt")]
		void Halt ();

		// -(void)clear;
		[Export ("clear")]
		void Clear ();

		// -(void)setNavigationMode:(enum PFNAVIGATIONMODE)mode;
		[Export ("setNavigationMode:")]
		void SetNavigationMode (PFNavigationMode mode);

		// -(void)setBlindSpotImage:(NSString *)resourceImageName;
		[Export ("setBlindSpotImage:")]
		void SetBlindSpotImage (string resourceImageName);

		// -(void)setBlindSpotLocation:(enum PFBLINDSPOTLOCATION)location;
		[Export ("setBlindSpotLocation:")]
		void SetBlindSpotLocation (PFBlindspotLocation location);

		// -(void)setFieldOfView:(float)fov;
		[Export ("setFieldOfView:")]
		void SetFieldOfView (float fov);

		// -(float)getRotationX;
		[Export ("getRotationX")]
		//[Verify (MethodToProperty)]
		float RotationX { get; }

		// -(float)getRotationY;
		[Export ("getRotationY")]
		//[Verify (MethodToProperty)]
		float RotationY { get; }

		// -(float)getRotationZ;
		[Export ("getRotationZ")]
		//[Verify (MethodToProperty)]
		float RotationZ { get; }

		// -(void)setRotationX:(float)rx;
		[Export ("setRotationX:")]
		void SetRotationX (float rx);

		// -(void)setRotationY:(float)ry;
		[Export ("setRotationY:")]
		void SetRotationY (float ry);

		// -(void)setRotationZ:(float)rz;
		[Export ("setRotationZ:")]
		void SetRotationZ (float rz);

		// -(void)setViewMode:(int)mode andAspect:(float)aspect;
		[Export ("setViewMode:andAspect:")]
		void SetViewMode (int mode, float aspect);

		// -(void)resetView;
		[Export ("resetView")]
		void ResetView ();

		// -(id)createHotspot:(UIImage *)image;
		[Export ("createHotspot:")]
		NSObject CreateHotspot (UIImage image);

		// -(id)createHotspotWithView:(UIView *)view;
		[Export ("createHotspotWithView:")]
		NSObject CreateHotspotWithView (UIView view);

		// -(void)removeHotspot:(id<PFHotspot>)hotspot;
		[Export ("removeHotspot:")]
		void RemoveHotspot (NSObject hotspot);

		// -(void)setAutoLevel:(BOOL)autolevel afterSeconds:(float)seconds;
		[Export ("setAutoLevel:afterSeconds:")]
		void SetAutoLevel (bool autolevel, float seconds);

		// -(void)setStereo:(BOOL)bStereo;
		[Export ("setStereo:")]
		void SetStereo (bool bStereo);

		// -(void)setHitOnFocus:(BOOL)bfocus;
		[Export ("setHitOnFocus:")]
		void SetHitOnFocus (bool bfocus);
	}

	// @interface PFObjectFactory : NSObject
	[BaseType (typeof (NSObject))]
	interface PFObjectFactory
	{
		// +(PFAsset *)assetFromUrl:(NSURL *)url observer:(PFAssetObserver *)o;
		[Static]
		[Export ("assetFromUrl:observer:")]
		PFAsset AssetFromUrl (NSUrl url, PFAssetObserver o);

		// +(PFView *)viewWithFrame:(CGRect)frame;
		[Static]
		[Export ("viewWithFrame:")]
		PFView ViewWithFrame (CGRect frame);
	}
}

