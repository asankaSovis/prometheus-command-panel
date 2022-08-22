# 🔥 Prometheus Command Panel
![Control Panel Poster](https://user-images.githubusercontent.com/46389631/170832714-0587bb0c-a896-40c6-9f3f-a69c376b9818.png)

---

## Project Introduction

**Prometheus** is a next generation fire alarm system Designed to take fire safety to the next level. This fire alarm system is designed to detect, indicate and extinguish fire by using necessary precautions. The system consists of three main stages:
1. Fire sensing and extinguishing system
2. Control stage
3. Alarming and notification stage

There are four main sections and components for the proper functioning of the system. It will help to complete that all the stages that are mentioned above.
1. Fire sensors
2. Extinguishing valves
3. Control unit
4. Software system
5. structural design

## Command Panel Software

The control software is a piece of software that is written so that the user can interface with the device. It connects to the device, displays data and statuses, allows the user to change settings and also view historical data for devices. The control software supports multiple devices to be operated at the same time. It is written in C# and is currently only available for Microsoft® Windows™. This program uses Windows APIs to connect to the COM ports of the computer to identify Prometheus devices connected.

> ![Software SS1](https://user-images.githubusercontent.com/46389631/185791330-9794a8b8-9144-4d10-bf61-85f5d442953d.png)
> Overview of the Interface

> ![Software SS2](https://user-images.githubusercontent.com/46389631/185791474-babe76c7-a6ea-4eeb-9597-21bb262580bf.png)
> Graph View

> ![Software SS3](https://user-images.githubusercontent.com/46389631/185791490-082c3bd4-f3d9-412f-afbc-05c06bf16098.png)
> Notification System

## Features

-	Connect multiple devices and add alias names to them for easy identification
-	Monitor all sensor data from the devices from dedicated control panels
-	Notifications for critical events
-	Override warnings and control devices right from the PC
-	Log sensor readings, visualise and export them
-	Automatic reconnecting

## Specification

-	OS: Windows 7 or higher
-	Processor: 1GHz or higher
-	Dot Net Framework: 4.7 or higher
-	RAM: 32MB or higher
-	Storage: 16MB or higher

## Protocol

The protocol was also an important aspect of the device. It allows the device to communicate with the Control Panel. All communication happen via USB between the PC and the FS232 module. The device communicate from its end via the COM ports while the device communicate from its end via the USB to TTL module. The communication is carried out in JSON. The communication protocol can be summed up as follows.

> ![Communication Protocol](https://user-images.githubusercontent.com/46389631/185858973-9d774f34-22ac-4df5-a44c-d62a1f4d3c27.png)
> Communication Protocol Breakdown

## Limitations

-	Sometimes the application fails to detect the devices connected
-	Protocol uses JSON strings which is not efficient
-	Protocol doesn’t have parity checks in place
-	Communication is not encrypted and fool proof
-	Minor bugs in the software

[![Prometheus Fire Alarm System - Demonstration](https://www.youtube.com/watch?v=5h3k6kufkHo/0.jpg)](https://www.youtube.com/watch?v=5h3k6kufkHo "Prometheus Fire Alarm System - Demonstration")

`© 2022 Asanka Sovis`
