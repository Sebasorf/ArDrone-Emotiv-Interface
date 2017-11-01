# ArDrone-Emotiv-Interface
This repo contains an interface for controlling Ar.Drone using an Emotiv (Epoc / Insight EEG Headset).

It's composed by a folder with Emotiv Controller Client (it works as a controller for the drone) that could receive input as a key on the keyboard using Emotiv Emokey, you could click a command or press a key button for controlling the drone; and a server that must be run once the drone is turned on. It will connect to drone access point and will start to listen in a predefined port (8000 defauld) for incoming connectios. This connection must be the Emotiv client.

The client is written in C# using Microsoft Visual Studio 2013 and only works on Windows.

The server is written in C and can run in every OS. But it's tested on Ubuntu 16.04 xenial.
