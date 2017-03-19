//
//  ViewController.h
//  R-Cast
//
//  Created by System Administrator on 3/19/17.
//  Copyright © 2017 R-Works. All rights reserved.
//

#import <Cocoa/Cocoa.h>

@interface ViewController : NSViewController


//----------------------------------------------------------------------------------------------//
// ||||||||||||||||||||||||||||||||||||||||||   LAN   ||||||||||||||||||||||||||||||||||||||||| //
//----------------------------------------------------------------------------------------------//

// This is the "LAN" panel

////    These are the elements found under the "Available Devices" subpanel.

@property (strong) IBOutlet NSTextFieldCell *ButtonAvailable;

@property (strong) IBOutlet NSButtonCell *ButtonRefresh;

@property (strong) IBOutlet NSButtonCell *ButtonSearch;

@property (strong) IBOutlet NSButtonCell *ButtonConnect;

@property (strong) IBOutlet NSButtonCell *ButtonRemember;


////    These are the elements found under the "Toggle Available Services" subpanel.

@property (strong) IBOutlet NSSegmentedControl *SwitchLAN;

@property (strong) IBOutlet NSSegmentedControl *SwitchWLAN;

@property (strong) IBOutlet NSSegmentedControl *SwitchBT;

@property (strong) IBOutlet NSSegmentedControl *SwitchVPN;


//----------------------------------------------------------------------------------------------//
// |||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| //
//----------------------------------------------------------------------------------------------//



//----------------------------------------------------------------------------------------------//
// ||||||||||||||||||||||||||||||||||||||||||   I|O   ||||||||||||||||||||||||||||||||||||||||| //
//----------------------------------------------------------------------------------------------//

// This is the "I|O" panel

////    These are the elements found under the "Monitors | Audio Devices" subpanel.

@property (strong) IBOutlet NSSegmentedControl *SwitchMonitor;

@property (strong) IBOutlet NSSegmentedControl *SwitchWebcam;

@property (strong) IBOutlet NSSegmentedControl *SwitchAudioOut;

@property (strong) IBOutlet NSSegmentedControl *SwitchAudioIn;


////    These are the elements found under the "Peripherals | Input Devices" subpanel.

@property (strong) IBOutlet NSBox *SwitchMouse;

@property (strong) IBOutlet NSBox *SwitchKeyboard;

@property (strong) IBOutlet NSBox *SwitchUSB;

@property (strong) IBOutlet NSBox *SwitchPrint;


//----------------------------------------------------------------------------------------------//
// |||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| //
//----------------------------------------------------------------------------------------------//

@end

