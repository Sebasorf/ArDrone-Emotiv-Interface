#include <sys/socket.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <sys/types.h> 
#include <netinet/in.h>
#include <fcntl.h>
#include <unistd.h>
#include <arpa/inet.h>

#define MAXBUFSIZE 10

void error(const char *);

int main(int argc, char *argv[])
{
    //Variables de aplicacion
    int socket_fd, newsocket_fd, binded, server_length, msg_received;
    socklen_t client_length;
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

    //Listen();
    listen(socket_fd, 1); //Maximun connections on queue

    while(1)
    {
        printf("Esperando conexion... \n");
        client_length = sizeof(client_addr);
        
        //Acept();
        newsocket_fd = accept(socket_fd, (struct sockaddr *)&client_addr, &client_length );
        printf("Conexion aceptada... \n");

	//Read(); messages in buffer
        msg_received = recv(newsocket_fd, buf, MAXBUFSIZE, 0);
        while(msg_received > 0 && msg_received <= MAXBUFSIZE)
        {
            if (msg_received ==-1 ) error("Hubo un error al intentar leer el buffer");
            buf[msg_received]='\0';
            printf("%s", buf);
            msg_received = recv(newsocket_fd, buf, MAXBUFSIZE, 0);
        }
  
        printf("\n");     
        printf("Finalizo todo... \n");
        printf("\n");
        
        //Close();
        close(newsocket_fd);
    }

    close(newsocket_fd);
    return 0;

}

void error(const char *msg)
{
    perror(msg);
    exit(0);
}

