
# Simple .Net Core GPIO Controller with Raspberry PI 

This simple projec will show you how to toggle Raspberry Pi GPIO Pins with .NET Core 2

> .NET Core only runs on the Raspberry Pi 2 or 3. It will not run on the Raspberry Pi Zero or Zero W


# How to run
1. Clone repo
2. Publish project with `dotnet publish -c Release -r linux-arm`
3. Copy all files in `bin/release/netcoreapp/linux-arm/publish` into a folder on your Raspberry Pi OS SD Card.
4. Turn on your Raspberry and config its Lan/wi-fi network if it's not done yet.
5. run project with `sudo ./rpi`

# How to control pins
Open this links in your favorite device browser:

##### Make a pin on: 
http://(your raspberry ip):5000/on/[pinNumber] 

##### Make a pin off: 
http://(your raspberry ip):5000/off/[pinNumber] 

##### Get current pin status 
http://(your raspberry ip):5000/status/[pinNumber] 

**Meisam Malekzadeh**
