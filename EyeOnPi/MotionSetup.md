This file is the setup for Motion, which is the second option from the
README.md file.

1.sudo apt update

2.sudo apt install motion

3.sudo nano /etc/motion/motion.conf

4.Change daemon off to daemon on to run Motion as a background service
(a \"daemon\" is a background process running without user interaction).

5.Adjust the framerate from 15 to 30 for better video quality.

6.Set webcontrol_localhost to off to enable remote access to the web
control interface

Always Ctrl x,y,enter to exit the file and restart it with the new
changes.

7.Enable Motion to start at boot: sudo systemctl enable motion

8.Start the Motion service: sudo systemctl start motion

9.Navigate to Interfacing Options then Camera then Enable it and reboot
with this command: sudo raspi-config

10.Test your camera with a screen capture: - sudo apt install fswebcam
 - fswebcam test.jpg

11.Make directory: sudo mkdir -p /var/log/motion

12\. Give permission to a specific user and group with : sudo chown
csuser:csuser /var/log/motion csuser is the name of your user that will
run the motion software and can be the user of Raspberry Pi 400.

13.Check the user running motion: ps aux \| grep motion

14.Locate your IP of Raspberry Pi 400: hostname --I

15\. Run this command to properly run the motion config file on web the
camera will be turned on this command is essential to run properly each
time you want to quickly get to motion on web to work: motion -c
/etc/motion/motion.conf

16\. Go to a web browser and run: http://10.0.0.135:8081 8081 is your
stream port number found in the motion.conf file and replace the rest of
numbers with your ip.At this point your camera must be working.

17\. Enable motion detection, edit the config file, setting the
motion_detection to on: sudo nano /etc/motion/motion.conf

-If you ever want to find faster anything press Ctrl W on keybord in
your motion.conf file.

18.Change the frequent processes to 30: event_gap 30

19.max_missed_steps 1 :To ensure system end the motion after a frame.

20.sudo systemctl restart motion

21.In the motion.conf file, target_dir sets the directory that contain
all recorded videos, we saved to a directory like:

mkdir /home/pi/videos

22.Commands that starts Motion automatically when the raspberry pi
boots:

sudo systemctl enable motion

sudo systemctl start motion

\*Note: this command is still needed each time: motion -c
/etc/motion/motion.conf

And You are Done!
