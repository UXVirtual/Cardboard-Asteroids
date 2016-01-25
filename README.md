# Gladeye Hackathon Project: Asteroids

VR Version of Asteroids that can be compiled to either Android or iOS from Unity.
Look in the direction you want to move, and push the magnetic button to toggle the engines

## Setup Instructions

*	If loading the project in Unity for the first time, you may need to also download and add the Google Cardboard SDK 
    to your project before all the script linkages will work correctly for the Cardboard related prefabs.

## Build Instructions

### iOS

1.	Open in Unity and go to `File -> Build and Run`.

2.	When XCode opens, make sure to add `Security.framework` in the XCode project under 
    `Build Phases -> Link Binary With Libraries` in Project Settings otherwise your will receive a build error.

### Android

1.  Open in unity and go to `File -> Build`.

2.  When you choose android in Build, make sure you choose Landscape left as the default orientation.

## Run Instructions

1.  Deploy the app to your device and run it.

2.  Tap the cog at the bottom of the screen when the game boots up and scan the QR code on your cardboard device.

3.  Stick your device in the Google Cardboard.

### Game Controls

*   Use your head to aim the ship / turret. The turret on the ship is locked to the forward facing direction 
    of the ship and it will shoot where you look if the ship is standing still. If you are moving, there may be some
    slight drift in the stream of plasma released by the turret that you will need to correct for.
    
*   Aiming at an asteroid will cause the white reticule in the centre of the screen to turn red and the turret will 
    automatically open fire.

*   Use the thrusters to move in space. While on, the thrusters will accelerate up to the maximum velocity. When 
    switched off, the ship will glide until it comes to a complete stop. With careful aiming and toggling the thrusters
    the ship can navigate in space and fly around the asteroid field.

#### Thruster Controls for Cardboard V1

*   Pull down and release the magnetic button on the side of the cardboard viewer to toggle thrusters on/off.

#### Thruster Controls for Cardboard V2

*   Tap the button on the right-top side of the cardboard viewer to toggle engines on/off. 

## Licence

### THE BEER-WARE LICENSE (Revision 42):

[Walter Lim](mailto:walter.lim@gladeye.co.nz), [Elliot Whiley](mailto:elliot.w@hotmail.com), 
[Michael Andrew](mailto:michael@uxvirtual.com), [Tim Dawson](mailto:Tim@ghost.st), and [Jordan](mailto:Jordan@ghost.st) 
wrote this project.  As long as you retain this notice you can do whatever you want with this stuff. If you meet any of 
us some day, and you think this stuff is worth it, you can buy us a beer in return.
