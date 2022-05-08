namespace Websocket_Shared
{
    public abstract class Message
    {
        public abstract string MessageType { get; }
        public abstract MessageRouting Routing { get; }
    }

}
