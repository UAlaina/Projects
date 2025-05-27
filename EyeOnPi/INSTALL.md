# Set Up MotionEye on Raspberry Pi

**Required items for this:** 

* Raspberry Pi ([Amazon](https://www.amazon.ca/s?k=Raspberry+Pi&linkCode=gg3&linkId=6f1d7762f53ddc0baae7d70955e10a98&tag=pimylifeup-20))  
* Any Web Camera.  
* Power Supply ([Amazon](https://www.amazon.ca/s?k=Raspberry+Pi+Power+Supply&linkCode=gg3&linkId=aed9105ddfbe3fbca2281c6d516689fd&tag=pimylifeup-20))  
* Micro SD Card ([Amazon](https://www.amazon.ca/s?k=Micro+SD+Card&linkCode=gg3&linkId=713df7956eee2eb8029711d263519a2e&tag=pimylifeup-20))  
* Ethernet Cable ([Amazon](https://www.amazon.ca/s?k=ethernet+cable&i=electronics&linkCode=gg3&linkId=0b80850d72d4ff1498294007146b5694&tag=pimylifeup-20))

1. **Set Up your Raspberry Pi**  
   If you haven’t already set up your Raspberry Pi, follow these steps:   
1. **Connect Hardware:**   
* Insert your Raspberry Pi into its case (if you have one).  
* Connect a keyboard, mouse, Monitor, and power supply to the Raspberry Pi.  
* Insert a microSD card with Raspberry Pi OS (if you need help installing Raspberry Pi OS, use the [Raspberry Pi Imager tool](https://www.raspberrypi.com/software/)).  
2. **Boot your Raspberry Pi:**   
* Turn on the power, and your Raspberry Pi should boot up. Following the on-screen instructions to complete the initial setup.  
    
2. **Update Your Raspberry Pi**  
   To make sure your Raspberry Pi has the latest software:  
* Open the terminal (found in the taskbar or menu).  
* Type the following commands one at a time and press enter after each:  
- sudo apt update  
- sudo apt upgrade

            This will update and upgrade your Raspberry Pi’s software.

3. **Install Essential tools for MotionEye**  
   Now, install the necessary tools for MotionEye to work:  
* Certificates for secure communication, file-downloading tools, and Python programs for handling cameras.  
* Type this command in the terminal and press **Enter:**

- sudo apt \--no-install-recommends install ca-certificates curl python3 python3-dev libcurl4-openssl-dev gcc libssl-dev  
    
    
4. **Install Python Pip**  
   Pip is a program that helps install MotionEye and its extra features.  
* First, check if Pip is already installed by typing:


- pip –verison


* If it’s not installed, install it by typing:  
- sudo apt install python3-pip \-y


  

5. **Fix Potential Errors**  
   To prevent errors during installation, run this command:

     
- sudo python3 \-m pip config set global.break-system-packages true


6. **Install MotionEye**  
   Now, install MotionEye using Python Pip:  
* Type this command and press **Enter**:


- sudo python3 \-m pip install \--pre MotionEye

7. **Set up MotionEye**  
   To prepare MotionEye for managing your cameras:  
     
- sudo motioneye\_init


8. **Access the Motion Web Interface**  
   To control MotionEye through your browser:  
1. Find your Raspberry Pi’s IP address:

   

- hostname \-I


                       Write down the IP address shown (e.g., `192.168.1.2`).

2. On your computer or phone, open a web browser.  
3. Type this in the address bar:  
- `http://(your IP address):8765`  
- Example: `http://192.168.1.2:8765`  
4. Log in as **admin** (leave the password blank).  
* Once logged in, go to settings and create a password for security.  
9. **Connect your USB Camera**  
   1\. In the MotionEye web interface:  
* Click **Add Camera**  
* Select **UVC Camera** as the camera type.  
  2\. Your camera should now appear on the screen.  
  