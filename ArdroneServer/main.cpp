#include "ardrone.h"

#define MAXBUFSIZE 10

// --------------------------------------------------------------------------
// main(Number of arguments, Argument values)
// Description  : This is the entry point of the program.
// Return value : SUCCESS:0  ERROR:-1
// --------------------------------------------------------------------------
void error(const char *msg);

int main(int argc, char *argv[])
{
    //Variables de aplicacion
    int socket_fd, newsocket_fd, binded, server_length, msg_received;
    socklen_t client_length;
    int counter=0;
    struct sockaddr_in server_addr, client_addr;
    char buf[MAXBUFSIZE];

    //Socket();
    socket_fd = socket(AF_INET, SOCK_STREAM, 0);
    if(socket_fd == -1) error("Hubo un error al abrir el socket\n");

    //Configuro server_addr
    server_addr.sin_family = AF_INET;
    server_addr.sin_addr.s_addr = inet_addr("192.168.0.21"); //or =INADDR_ANY
    server_addr.sin_port = htons(8000);

    //Configuro server length
    server_length = sizeof(struct sockaddr_in);

    //Bind();
    binded = bind(socket_fd, (struct sockaddr *)&server_addr, server_length);
    if (binded == -1) error("Hubo un error al intentar hacer un bind\n");
	
    // AR.Drone class
    /*ARDrone ardrone;*/

    // Initialize
    /*if (!ardrone.open()) {
        std::cout << "Failed to initialize." << std::endl;
        return -1;
    }*/

    // Battery
    /*std::cout << "Battery = " << ardrone.getBatteryPercentage() << "[%]" << std::endl;*/

    // Instructions
    std::cout << "***************************************" << std::endl;
    std::cout << "*       CV Drone sample program       *" << std::endl;
    std::cout << "*           - How to play -           *" << std::endl;
    std::cout << "***************************************" << std::endl;
    std::cout << "*                                     *" << std::endl;
    std::cout << "* - Controls -                        *" << std::endl;
    std::cout << "*    'Space' -- Takeoff/Landing       *" << std::endl;
    std::cout << "*    'Up'    -- Move forward          *" << std::endl;
    std::cout << "*    'Down'  -- Move backward         *" << std::endl;
    std::cout << "*    'Left'  -- Turn left             *" << std::endl;
    std::cout << "*    'Right' -- Turn right            *" << std::endl;
    std::cout << "*    'Q'     -- Move upward           *" << std::endl;
    std::cout << "*    'A'     -- Move downward         *" << std::endl;
    std::cout << "*                                     *" << std::endl;
    std::cout << "* - Others -                          *" << std::endl;
    std::cout << "*    'C'     -- Change camera         *" << std::endl;
    std::cout << "*    'Esc'   -- Exit                  *" << std::endl;
    std::cout << "*                                     *" << std::endl;
    std::cout << "***************************************" << std::endl;

    //Listen();
    listen(socket_fd, 1); //Maximun connections on queu

    while (1) {
        printf("%d - ", counter);
	//printf("Esperando conexion... \n");
        client_length = sizeof(client_addr);
        
        //Acept();
        newsocket_fd = accept(socket_fd, (struct sockaddr *)&client_addr, &client_length );
        //printf("Conexion aceptada... \n");

        // Get an image
        /*cv::Mat image = ardrone.getImage();*/

	//Read(); messages in buffer
        msg_received = recv(newsocket_fd, buf, MAXBUFSIZE, 0);
        while(msg_received > 0 && msg_received <= MAXBUFSIZE)
        {
    	    double vx = 0.0, vy = 0.0, vz = 0.0, vr = 0.0;

            if (msg_received ==-1 ) error("Hubo un error al intentar leer el buffer");
                	buf[msg_received]='\0';
    	
    		if (buf[0]=='t'){
    			/*if (ardrone.onGround()) {*/
                    printf("Taking off... \n");
                    /*ardrone.takeoff();
                }*/
            }
    		if (buf[0]=='a'){
    			/*if (!ardrone.onGround()){*/
                    printf("Landing... \n");
                    /*ardronelanding();
                }*/
            }
    		if (buf[0]=='f'){
            	vx =  1.0;
                printf("Movement: Forward... \n");
            }
    		if (buf[0]=='l'){	
                vr =  1.0;
                printf("Direction: Turn Left... \n");
            }
    		if (buf[0]=='r'){	
                vr = -1.0;
                printf("Direction: Turn Right... \n");
            }
    		if (buf[0]=='b'){
                vx = -1.0;
                printf("Movement: Backward\n");
            }
    		if (buf[0]=='u'){
                vy =  1.0;
                printf("Height: Moving UP\n");
            }	
    		if (buf[0]=='n'){	
                vz =  1.0;
                printf("Movement: Left\n");
            }
    		if (buf[0]=='h'){	
                vz = -1.0;
                printf("Movement: Right\n");
            }
    		if (buf[0]=='d'){	
                vy = -1.0;
                printf("Height: Moving Down\n");
            }
    		/*ardrone.move3D(vx, vy, vz, vr);*/
			
            //printf("%s", buf);
            msg_received = recv(newsocket_fd, buf, MAXBUFSIZE, 0);
        }
        // Move
        //if (key == 'i' || key == CV_VK_UP)    vx =  1.0;
        //if (key == 'k' || key == CV_VK_DOWN)  vx = -1.0;
        //if (key == 'u' || key == CV_VK_LEFT)  vr =  1.0;
        //if (key == 'o' || key == CV_VK_RIGHT) vr = -1.0;
        //if (key == 'j') vy =  1.0;
        //if (key == 'l') vy = -1.0;
        //if (key == 'q') vz =  1.0;
        //if (key == 'a') vz = -1.0;
        /*ardrone.move3D(vx, vy, vz, vr);*/

        // Change camera
        //static int mode = 0;
        //if (key == 'c') ardrone.setCamera(++mode % 4);

        // Display the image
        /*cv::imshow("camera", image);*/
        counter ++;
    }

    // See you
    /*ardrone.close();*/
    return 0;
}

void error(const char *msg)
{
    perror(msg);
    exit(0);
}
