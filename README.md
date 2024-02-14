# Basic TCP/IP and SerialPort COM

 This is a simple communication app which includes Serial Port Communication and TCP/IP protocol. We have two different apps. First one is Client. We needed that for sending messages and configuring connection variables. In top we can connect our TCP/IP connection and send messages. In bottom section we can open a serial port and send messages. Second one is Server which needed for only TCP/IP communication. We can configure host and port variables and start a connection in this app. Instructions for use will be provided below.

Preview of CLient: 
https://i.imgur.com/2ZeZzEb.png 

Preview of Server: 
https://i.imgur.com/M3u8H0C.png
 
Installation: 
To install my project you can easily clone my repo:
git clone https://github.com/Aurora1917/Basic-TCP-IP-and-SerialPort-COM.git
It its not come with required packs you should get SimpleTcp(1.0.24) and System.IO.Ports(8.0.0) packages. 

Usage: 
For TCP/IP connection we need both apps. Firstly we should open both apps and in Server we should configure our Host and Port then start connection. After that in client, we should write the same variables then click the Connect button. Then we've the connection! We can write our text messages in first textbox. After clicking the send button we'll see our message in the second textbox after a few seconds. We can also see the passed data in the textbox of Server app. 
https://i.imgur.com/ueDu66a.png

For Serial Port connection, we only need Client app. We can see the Serial Ports of our device in the comboBox. We can select the port from here BUT if this port is not avaliable, we'll have problems in this port so im heavily advicing to create a virtual port with 3rd party apps. Otherwise probably you'll face freezing and crashing issues. After we choose our Serial Port from comboBox, we should click Open to open port. Then we can write our message in first textBox. After this, we should click to send button. To see our message in the bottom textbox, we should click receive button.
https://i.imgur.com/RdUXok0.png

In this project, i've used Microsoft.NETCore 8.0 and two packages ( SimpleTcp(1.0.24) and System.IO.Ports(8.0.0)). 
