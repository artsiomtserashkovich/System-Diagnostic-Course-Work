using System;

namespace SystemDiagnostic.Diagnostic.CommandResponseProtocol.Entities
{
    public class ClientCommandDTO
    {
        public ClientCommandDTO(ClientCommandInformation information,string command){
            Information=information;
            Command = Command;
        }
        public string IdCommand {get;set;}
        public string Command {get;set;}
        public ClientCommandInformation Information {get;set;}
    }
}
