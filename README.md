# Systray-Experiments
## Process and Service Handler with Systray Implementation

A simple program in C# that starts minimized in the systray. With the program the user can set a list of programs to be killed or a list of services to stopp. 
The user can add processes to the kill list by choose them from the list of currently running processess. The program then checks in an intervall if this process is running, 
if so it is being terminated immediately. It is the same with the services, they can be stopped accordingly, when added to the list.

The list is saved automatically when the user adds a new process or service. On restart of the program or the OS the list is still avaiable and the program kills the processes and
services on the list if they´re up and running.
The user gets a notification if a process has been terminated or if a service has been stopped. 
