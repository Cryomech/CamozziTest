CamozziTest - Valve island proof-of-concept
===========================================
This is a dotnet 6.0 program to test out Ethernet/IP controll of the Camozzi CX4 valve island.

Dependencies
------------
- [.NET 6.0 Framework](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) SDK version 6.0.302
- [EEIP.dll](eeip-library.de) included with this project

Compilation
-----------
By default, this program uses 10.32.100.24 as the target IP.
This can be edited in the source code, or optionally specified by command line argument.

Compile:

	dotnet build

Execute:
	
	dotnet run [IP]
